using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoMVC.Models.TodoDB;
using TodoMVC.Services;

namespace TodoMVC.Controllers
{
    public class TodoController : Controller
    {
        TodoService todoService = new TodoService();

        // GET: Todo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTodos()
        {
            var data = todoService.GetTodos();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public bool Add(string value)
        {
            return todoService.Add(value);
        }

        [HttpPost]
        public bool Edit(IEnumerable<Todo> todos)
        {
            return todoService.Edit(todos);
        }

        public bool Delete(int _id)
        {
            return todoService.Delete(_id);
        }

        public bool DeleteCompleted()
        {
            return todoService.DeleteCompleted();
        }
    }
}