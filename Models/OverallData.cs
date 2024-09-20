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
using System.Threading.Tasks;

namespace EJ2MVCSampleBrowser.Models
{
    public class OverAllData
    {
        public OverAllData()
        {

        }
        public OverAllData(string Month, int Sales, int MarketingSpend, int NewCustomers, int ReturningCustomers, int WebTraffic)
        {
            this.Month = Month;
            this.Sales = Sales;
            this.MarketingSpend = MarketingSpend;
            this.NewCustomers = NewCustomers;
            this.ReturningCustomers = ReturningCustomers;
            this.WebTraffic = WebTraffic;
        }
        public string Month { get; set; }
        public int Sales { get; set; }
        public int MarketingSpend { get; set; }
        public int NewCustomers { get; set; }
        public int ReturningCustomers { get; set; }
        public int WebTraffic {get; set; }

        public static List<OverAllData> GetAllRecords()
        {
            List<OverAllData> OverAllDataList = new List<Models.OverAllData>();
            OverAllDataList.Add(new OverAllData("January 2022", 51000, 9000, 180, 150, 200));
            OverAllDataList.Add(new OverAllData("February 2022", 46000, 9200, 190, 160, 320));
            OverAllDataList.Add(new OverAllData("March 2022", 45000, 9400, 200, 155, 190));
            OverAllDataList.Add(new OverAllData("April 2022", 48000, 9600, 210, 165, 100));
            OverAllDataList.Add(new OverAllData("May 2022", 49000, 9800, 220, 170, 230));
            OverAllDataList.Add(new OverAllData("June 2022", 52000, 9600, 210, 160, 300));
            OverAllDataList.Add(new OverAllData("July 2022", 48000, 9700, 215, 170, 175));
            OverAllDataList.Add(new OverAllData("August 2022", 50000, 9800, 225, 180, 190));
            OverAllDataList.Add(new OverAllData("September 2022", 45000, 9700, 220, 175, 120));
            OverAllDataList.Add(new OverAllData("October 2022", 46000, 10000, 230, 190, 160));
            OverAllDataList.Add(new OverAllData("November 2022", 50000, 9900, 225, 185, 230));
            OverAllDataList.Add(new OverAllData("December 2022", 47000, 10200, 240, 200, 145));
            return OverAllDataList;
        }
    }
}
