﻿using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    // GET: /lol
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;

        return View();
    }
}