﻿using Microsoft.AspNetCore.Mvc;

namespace ProjetoNP2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
