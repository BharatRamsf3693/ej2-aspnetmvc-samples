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
using Newtonsoft.Json;
using Syncfusion.EJ2.Maps;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: MarkerTemplate
        public ActionResult MarkerTemplate()
        {
            ViewBag.shapeData = this.GetAustralia();
            
            ViewBag.palette = new string[] { "#E2B247", "#88DB46", "#42C4E2", "#C08AF8", "#52BACC", "#F4CE2F", "#6986ED" };
            return View();
        }
        public object GetAustralia()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Australia.js"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }       
    }
}