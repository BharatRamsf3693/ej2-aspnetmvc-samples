﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class ComboBoxController : Controller
    {
        public ActionResult Filtering()
        {
            ViewBag.data = new Countries().CountriesList();
            return View();
        }
    }
}