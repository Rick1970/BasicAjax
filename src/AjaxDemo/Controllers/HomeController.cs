﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!",
                "text/plain");
        }
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }
        public IActionResult DisplayObject()
        {
            Destination destination = new Destination("Tokyo", "Japan", 1);
            return Json(destination);
        }
        public IActionResult DisplayViewWithAjax()
        {
            return View();
        } 
    }
}
