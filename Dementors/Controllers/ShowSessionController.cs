﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
    public class ShowSessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}