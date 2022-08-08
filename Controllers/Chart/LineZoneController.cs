﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: LineZone
        public ActionResult LineZone()
        {
            
            ViewBag.content = "<div style='width:80px; padding: 5px;'><table style='width: 100%'>" +
    "<tr> <td><div style='width: 10px; height: 10px; background:blue;border-radius: 15px;'></div>" +
    "</td> <td style='padding-left: 5px;'>High</td></tr><tr><td>" +
    "<div style='width: 10px; height: 10px; background:green;;border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Medium </td></tr><tr><td>" +
    "<div style='width: 10px; height: 10px; background:red;;border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Low</td></tr></table></div>";
            return View();
        }
    }
}