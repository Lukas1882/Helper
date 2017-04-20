using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SqlReportHelper;
using SqlReportHelper.Comman;

namespace SqlReportHelper.Models
{
    class AppModel
    {
        public static string settingPath = AppDomain.CurrentDomain.BaseDirectory + "Setting.json";
        public static string scriptFolder = AppDomain.CurrentDomain.BaseDirectory + "/Scripts/";
        public static string reportFolder = AppDomain.CurrentDomain.BaseDirectory  + "/Reports/";
        public static string connectionString { get; set; }
        public static bool overWriteFile { get; set; }
        public static bool addNewSheet { get; set; }
    }
}
