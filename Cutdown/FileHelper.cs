using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutdown
{
    /// <summary>
    /// 文件操作
    /// </summary>
    public class FileHelper
    {
        public static string SettingUrl = "\\setting.json";

        public static (string description, DateTime targetDate) GetSetting()
        {
            try
            {
                string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                if (string.IsNullOrEmpty(exeDir))
                {
                    return ("倒计时：", DateTime.Now);
                }
                var url = exeDir + SettingUrl;
                var result = new FileHelper().ReadAllText(url);
                var data = JsonConvert.DeserializeObject<JObject>(result);
                if (data == null || !data.ContainsKey("Description") || !data.ContainsKey("TargetDate"))
                {
                    return ("倒计时：", DateTime.Now);
                }
                DateTime targetDate;
                DateTime.TryParse(data["TargetDate"]?.ToString() ?? "", out targetDate);
                return (data["Description"]?.ToString()??"", targetDate);
            }
            catch
            {
                return ("倒计时：", DateTime.Now);
            } 
           
        }

        public static void UpdateSetting(string description, DateTime targetDate)
        {
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            if (string.IsNullOrEmpty(exeDir))
            {
                return;
            }
            var url = exeDir + SettingUrl;
            var data = JsonConvert.SerializeObject(new { Description = description, TargetDate = targetDate.ToString("yyyy/MM/dd HH:mm:ss") });
            new FileHelper().WriteAllText(url, data);
        }

        // 打开指定文件夹
        public static void OpenApplationFolder()
        {
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            OpenFolder(exeDir);
        }

        // 打开指定文件夹
        private static void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("文件夹不存在！");
            }
        }

        public string ReadAllText(string path)
        {
            if (System.IO.File.Exists(path))
            {
                return System.IO.File.ReadAllText(@path);
            }
            return "";
        }

        public void WriteAllText(string path, string data)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.WriteAllText(@path, data);
            }
        }
    }
}
