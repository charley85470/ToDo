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
                return _db.Todos.AsEnumerable();
            }
        }
    }
}