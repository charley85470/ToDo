using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoMVC.Models.TodoDB
{
    public class TodoContextInitializer : CreateDatabaseIfNotExists<TodoContext>
    {
        protected override void Seed(TodoContext context)
        {
            // 設定初始值
            context.Todos.AddRange(new List<Todo>
            {
                new Todo { Content = "Taste JavaScript", IsComplete = true },
                new Todo { Content = "Buy a unicorn", IsComplete = false }
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}