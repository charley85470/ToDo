using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoMVC.Models.TodoDB;

namespace TodoMVC.Services
{
    public class TodoService
    {
        public IEnumerable<Todo> GetTodos()
        {
            using (TodoContext _db = new TodoContext())
            {
                return _db.Todos.Select(x => x).ToList();
            }
        }

        public bool Add(string value)
        {
            using (TodoContext _db = new TodoContext())
            {
                _db.Todos.Add(new Todo { Content = value, IsComplete = false });
                return _db.SaveChanges() > 0;
            }
        }

        public bool Edit(IEnumerable<Todo> todos)
        {
            using (TodoContext _db = new TodoContext())
            {
                foreach (var todo in todos)
                {
                    _db.Todos.Attach(todo);
                    _db.Entry(todo).State = System.Data.Entity.EntityState.Modified;
                }
                return _db.SaveChanges() > 0;
            }
        }

        public bool Delete(int _id)
        {
            using (TodoContext _db = new TodoContext())
            {
                var todo = _db.Todos.Find(_id);
                _db.Todos.Remove(todo);
                return _db.SaveChanges() > 0;
            }
        }

        public bool DeleteCompleted()
        {
            using (TodoContext _db = new TodoContext())
            {
                var completed = _db.Todos.Where(x => x.IsComplete);
                _db.Todos.RemoveRange(completed);
                return _db.SaveChanges() > 0;
            }
        }
    }
}