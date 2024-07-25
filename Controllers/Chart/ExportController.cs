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
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Export
        public ActionResult Export()
        {
            List<ExportChartData> ChartPoints = new List<ExportChartData>
            {
                new ExportChartData {Country="India", GigaWatts = 35.5, DataLabelMappingName="35.5"},
                new ExportChartData {Country="China", GigaWatts = 18.3, DataLabelMappingName="18.3"},
                new ExportChartData {Country="Italy", GigaWatts = 17.6, DataLabelMappingName="17.6"},
                new ExportChartData {Country="Japan", GigaWatts = 13.6, DataLabelMappingName="13.6"},
                new ExportChartData {Country="United state", GigaWatts = 12, DataLabelMappingName="12"},
                new ExportChartData {Country="Spain", GigaWatts = 5.6, DataLabelMappingName="5.6"},
                new ExportChartData {Country="France", GigaWatts = 4.6, DataLabelMappingName="4.6"},
                new ExportChartData {Country="Australia", GigaWatts = 3.3, DataLabelMappingName="3.3"},
                new ExportChartData {Country="Belgium", GigaWatts = 3, DataLabelMappingName="3"},
                new ExportChartData {Country="United Kingdom", GigaWatts = 2.9, DataLabelMappingName="2.9"},
                
            };
            ViewBag.ChartPoints = ChartPoints;
            ViewBag.data = new string[] { "JPEG", "PNG", "SVG", "PDF", "XLSX", "CSV" };
            return View();
        }
        public class ExportChartData
        {
            public string Country;
            public double GigaWatts;
            public string DataLabelMappingName;
        }
    }
}