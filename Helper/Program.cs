using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlReportHelper.Comman;
using SqlReportHelper.Models;
using SqlReportHelper.Models;
using System.Collections.Generic;
using SqlReportHelper.Common;

namespace SqlReportHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read setting from json file and sync to app model.
            AppSetting setting = FileHelper.ReadSetting(AppModel.settingPath);
            setting.UpdateAppModel();
            // Get the list of the scripts
            List<Script> scripts = FileHelper.ReadScripts();
            // Run scripts and get the sql data.
            DataHelper.ExecuteScripts(scripts);
            Console.WriteLine("\n");
            // Export the script sql data into excel.
            ExcelHelper.ExportFiles(scripts);
            //Console.ReadKey();
        }
    }
}
