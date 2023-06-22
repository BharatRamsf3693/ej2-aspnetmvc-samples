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
        public ActionResult Overview()
        {
            ViewBag.Tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase", "SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "EmojiPicker", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            string hostUrl = "https://ej2-aspcore-service.azurewebsites.net/";
            ViewBag.AjaxSettings = new
            {
                url = hostUrl + "api/FileManager/FileOperations",
                getImageUrl = hostUrl + "api/FileManager/GetImage",
                uploadUrl = hostUrl + "api/FileManager/Upload",
                downloadUrl = hostUrl + "api/FileManager/Download"
            };
            ViewBag.Table = new[] {
                "TableHeader", "TableRows", "TableColumns", "TableCell", "-", "BackgroundColor", "TableRemove", "TableCellVerticalAlign", "Styles"
            };
            return View();
        }
    }
}
