using Newtonsoft.Json;
using SqlReportHelper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlReportHelper.Comman
{
    public class FileHelper
    {
        public static AppSetting ReadSetting(string filePath)
        {
            string fileStr = String.Empty;
            try
            {
                fileStr = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            try
            {
                AppSetting setting = JsonConvert.DeserializeObject<AppSetting>(fileStr);
                return setting;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Script> ReadScripts()
        {
            List<Script> scripts = new List<Script>();
            if (!Directory.Exists(AppModel.scriptFolder))
                Directory.CreateDirectory(AppModel.scriptFolder);
            foreach (string filePath in Directory.GetFiles(AppModel.scriptFolder))
            {
                string dd = Path.GetExtension(filePath).ToLower();
                if (Path.GetExtension(filePath).ToLower() != ".sql")
                    continue;
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                scripts.Add(new Script(fileName, File.ReadAllText(filePath)));
            }
            return scripts;
        }

        public static string GetRootPath()
        {
            return AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));
        }
    }

}
