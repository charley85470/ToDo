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
                return new List<Todo>
                {
                    new Todo { Content = "測試資料1", IsComplete = false },
                    new Todo { Content = "測試資料2", IsComplete = false },
                    new Todo { Content = "測試資料3", IsComplete = false },
                    new Todo { Content = "測試資料4", IsComplete = false },
                };


                return _db.Todos.AsEnumerable();
            }
        }
    }
}