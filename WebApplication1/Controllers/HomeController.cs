﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            _listDemo = new List<ListDemo>
            {
            new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
            new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
            new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
            };
        }

        private List<ListDemo> _listDemo;
        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2";
            ViewData["Lst"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }
    }

}

public class ListDemo
{
    public int ListItemValue { get; set; }
    public string ListItemText { get; set; }
}