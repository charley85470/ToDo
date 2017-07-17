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

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}