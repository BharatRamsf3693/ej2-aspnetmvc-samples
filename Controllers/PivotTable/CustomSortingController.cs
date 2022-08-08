﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotTableController : Controller
    {

        public ActionResult CustomSorting()
        {
            ViewBag.data = new PivotTableData().GetPivot_Data();
            ViewBag.drilledMembers = new string[] { "Germany" };
            ViewBag.sortSettings = new string[] { "France", "United States" };
            ViewBag.sortSettings_1 = new string[] { "FY 2018", "FY 2017" };
            ViewBag.sortSettings_2 = new string[] { "Gloves", "Bottles and Cages" };
            return View();
        }
    }
}
