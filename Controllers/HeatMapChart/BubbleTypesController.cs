#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: BubbleHeatmap
        public ActionResult BubbleTypes()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "inherit"
            };
            ViewBag.labelTextStyle = new
            {
                fontFamily = "inherit"
            };
            string[] xlabels = new string[8] { "Singapore", "Spain", "Australia", "Germany", "Belgium", "USA", "France", "UK" };
            ViewBag.xLabels = xlabels;
            ViewBag.border = new
            {
                width = 1
            };
            string[] yLabels = new string[5] { "1995", "2000", "2005", "2010", "2015" };
            ViewBag.yLabels = yLabels;
            ViewBag.dataSource = new HeatMapData().tableBubbleData();
            return View();
        }
    }
}