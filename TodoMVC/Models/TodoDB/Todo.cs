using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoMVC.Models.TodoDB
{
    public class Todo
    {
        [Key]
        public int _id { get; set; }
        public string Content { get; set; }
        public bool IsComplete { get; set; }
    }
}