﻿using Microsoft.AspNetCore.Mvc;

namespace ETicaretSitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
