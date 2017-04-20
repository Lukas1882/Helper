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
        public static string scriptFolder = FileHelper.GetRootPath() + "/Scripts/";
        public static string reportFolder = FileHelper.GetRootPath() + "/Reports/";
        public static string connectionString { get; set; }
        public static bool overWriteFile { get; set; }
        public static bool addNewSheet { get; set; }
    }
}
