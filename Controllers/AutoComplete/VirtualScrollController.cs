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
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public ActionResult VirtualScroll()
        {
            AutoCompleteRecord model = new AutoCompleteRecord();
            model.RecordList = new AutoCompleteRecord().RecordModelList();
            return View(model);
        }
    }
    public class AutoCompleteRecord
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public string Group { get; set; }
        public List<AutoCompleteRecord> RecordList { set; get; }
        public List<AutoCompleteRecord> RecordModelList()
        {
            Random random = new Random();
            return Enumerable.Range(1, 150).Select(i => new AutoCompleteRecord()
            {
                ID = i.ToString(),
                Text = "Item " + i,
                Group = GetRandomGroup(random),
            }).ToList();
        }
        public string GetRandomGroup(Random random)
        {
            // Generate a random number between 1 and 4 to determine the group
            int randomGroup = random.Next(1, 5);
            switch (randomGroup)
            {
                case 1:
                    return "Group A";
                case 2:
                    return "Group B";
                case 3:
                    return "Group C";
                case 4:
                    return "Group D";
                default:
                    return string.Empty;
            }
        }
    }
}