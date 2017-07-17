using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoMVC.Models.TodoDB;

namespace TodoMVC.Services
{
    public class TodoService
    {
        public IEnumerable<Todo> GetTodos(bool? status)
        {
            using (TodoContext _db = new TodoContext())
            {
                var list = new List<Todo>
                {
                    new Todo { _id = 0, Content = "測試資料1", IsComplete = true },
                    new Todo { _id = 1, Content = "測試資料2", IsComplete = false },
                    new Todo { _id = 2, Content = "測試資料3", IsComplete = true },
                    new Todo { _id = 3, Content = "測試資料4", IsComplete = false },
                };

                if (status.HasValue)
                {
                    list = list.Where(x => x.IsComplete == status.Value).ToList();
                }

                return list;


                return _db.Todos.AsEnumerable();
            }
        }

        //public bool DeleteTodo(int _id)
        //{
        //    using (TodoContext _db = new TodoContext())
        //    {
        //        var todo = _db.Todos.Find(_id);
        //        _db.Todos.Remove()
        //    }
        //}
    }
}