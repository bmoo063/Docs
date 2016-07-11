﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact(int ? id)
        {
            var viewName = id==null ? "Contact" : "Contact" + id.ToString();

            return View(viewName);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
