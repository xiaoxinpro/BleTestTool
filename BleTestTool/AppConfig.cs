using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace BleTestTool
{
    public class AppConfig
    {
        private Configuration objConfig = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public void SetConfig(string Key,string Value)
        {
            try
            {
                objConfig.AppSettings.Settings[Key].Value = Value;
            }
            catch (Exception)
            {
                objConfig.AppSettings.Settings.Add(Key, Value);
            }
            SaveConfig();
        }

        public void SetConfig(Dictionary<string,string> dicConfig)
        {
            foreach (string key in dicConfig.Keys)
            {
                try
                {
                    objConfig.AppSettings.Settings[key].Value = dicConfig[key];
                }
                catch (Exception)
                {
                    objConfig.AppSettings.Settings.Add(key, dicConfig[key]);
                }
            }
            SaveConfig();
        }

        public string GetConfig(string Key)
        {
            try
            {
                return objConfig.AppSettings.Settings[Key].Value;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void RemoveConfig(string Key)
        {
            try
            {
                objConfig.AppSettings.Settings.Remove(Key);
                SaveConfig();
            }
            catch (Exception)
            {
                return;
            }

        }

        public void ClearConfig(string Key)
        {
            objConfig.AppSettings.Settings.Clear();
            SaveConfig();
        }

        private void SaveConfig()
        {
            //一定要记得保存，写不带参数的config.Save()也可以
            objConfig.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
