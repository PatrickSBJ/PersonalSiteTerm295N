﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Writing()
        {
            return View();
        }
        public IActionResult Photography()
        {
            return View();
        }
        public IActionResult Programming()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }



    }
}