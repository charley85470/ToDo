using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoMVC.Models.TodoDB
{
    public class Todo
    {
        public string Content { get; set; }
        public bool IsComplete { get; set; }
    }
}