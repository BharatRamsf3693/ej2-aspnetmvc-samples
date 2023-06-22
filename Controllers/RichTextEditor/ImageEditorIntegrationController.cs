#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult ImageEditorIntegration()
        {
            ViewBag.header = "Image Editor";
            ViewBag.insertButton = new
            {
                content = "Save",
                isPrimary = true
            };
            ViewBag.cancelButton = new
            {
                content = "Cancel"
            };
            var imageEdit = new
            {
                tooltipText = "Image Editor",
                template = "<button class=\"e-tbar-btn e-btn\" id=\"imageEditor\"><span class=\"e-btn-icon e-icons e-rte-image-editor\"></span></button>"
            };
            ViewBag.image = new object[] { "Replace", "Align", "Caption", "Remove", "-", "InsertLink", "Display", "AltText", imageEdit };
            return View();
        }
    }
}