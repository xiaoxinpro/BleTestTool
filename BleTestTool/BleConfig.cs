using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BleTestTool
{
    public class BleConfig
    {
        #region 常量
        //配置文件后缀
        private const string FILE_FIX = ".ble";
        private const string FILE_NAME_BLACK_LIST = "BlackList";
        private const string FILE_NAME_BLE_NAME_REPLACE = "BleNameReplace";
        #endregion

        #region 字段
        private string _bleConfigFilePath;
        private Dictionary<string, string> _dicBleBlackListConfig = new Dictionary<string, string>();
        private Dictionary<string, string> _dicBleNameReplaceConfig = new Dictionary<string, string>();
        #endregion

        #region 属性
        public string BleConfigFilePath { get => _bleConfigFilePath; set => _bleConfigFilePath = value; }
        public Dictionary<string, string> DicBleBlackListConfig { get => _dicBleBlackListConfig; set => _dicBleBlackListConfig = value; }
        public Dictionary<string, string> DicBleNameReplaceConfig { get => _dicBleNameReplaceConfig; set => _dicBleNameReplaceConfig = value; }
        #endregion

        #region 构造函数
        public BleConfig()
        {
            BleConfigFilePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            InitBleConfig();
        }

        public BleConfig(string path) : this()
        {
            //去除路径的前后空格
            path = path.Trim();

            //判断配置文件夹是否存在  
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path); //新建文件夹   
            }

            //判断文件末尾是否有\
            if (path.Substring(path.Length-1,1) != @"\")
            {
                path = path + @"\";
            }

            BleConfigFilePath = path;
            InitBleConfig();
        }

        private void InitBleConfig()
        {
            GetBleBlackListConfig();
            GetBleNameReplaceConfig();
        }
        #endregion

        #region 蓝牙黑名单配置
        /// <summary>
        /// 保存蓝牙黑名单配置
        /// </summary>
        public void SaveBleBlackListConfig()
        {
            WriteFile(BleConfigFilePath + FILE_NAME_BLACK_LIST + FILE_FIX, DicBleBlackListConfig);
        }

        /// <summary>
        /// 获取蓝牙黑名单配置
        /// </summary>
        public void GetBleBlackListConfig()
        {
            ReadFile(BleConfigFilePath + FILE_NAME_BLACK_LIST + FILE_FIX, DicBleBlackListConfig);
        }
        #endregion

        #region 蓝牙名称替换配置
        /// <summary>
        /// 保存蓝牙黑名单配置
        /// </summary>
        public void SaveBleNameReplaceConfig()
        {
            WriteFile(BleConfigFilePath + FILE_NAME_BLE_NAME_REPLACE + FILE_FIX, DicBleNameReplaceConfig);
        }

        /// <summary>
        /// 获取蓝牙黑名单配置
        /// </summary>
        public void GetBleNameReplaceConfig()
        {
            ReadFile(BleConfigFilePath + FILE_NAME_BLE_NAME_REPLACE + FILE_FIX, DicBleNameReplaceConfig);
        }
        #endregion

        #region 静态方法
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="dic">数据</param>
        private void WriteFile(string path, Dictionary<string, string> dic)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (KeyValuePair<string,string> item in dic)
                {
                    sw.WriteLine(item.Key + "," + item.Value);
                }
            }
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="dic">数据</param>
        private void ReadFile(string path, Dictionary<string, string> dic)
        {
            dic.Clear();
            if (!File.Exists(path))
            {
                return;
            }
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string[] arrData = sr.ReadLine().Trim().ToString().Split(',');
                    if (arrData.Length >= 2)
                    {
                        dic.Add(arrData[0], arrData[1]);
                    }
                }
            }
        }
        #endregion
    }
}
