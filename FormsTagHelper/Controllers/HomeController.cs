﻿using FormsTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormsTagHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel registerViewModel)
        {
            if(!ModelState.IsValid)
            return View(registerViewModel);

            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            // return View("AboutBoldOnly");
            return View();
        }

        public IActionResult Contact(int id = 0)
        {
            ViewData["Message"] = "Your contact page.";

            string view = "Contact";

            switch (id)
            {
                case 1:
                    view = "ContactCopy";
                    break;

                case 2:
                    view = "ContactVoid";
                    break;

                case 0:
                default:
                    view = "Contact";
                    break;
            }
            return View(view);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
