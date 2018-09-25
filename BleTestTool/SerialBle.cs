using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BleTestTool
{
    public class SerialBle
    {
        #region 字段
        private enumBleCmd _serialBleCmd;
        private System.Timers.Timer _timBleWrite;
        private string _bakBleLinkData = "";
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialBle(ToolStripComboBox comboBox)
        {
            ComboBle = comboBox;
            DicListBle = new Dictionary<string, string>();
            DicListBleRssi = new Dictionary<string, int>();
            initTimBleWrite();
        }

        public SerialBle(ToolStripComboBox comboBox, DelegateBleSerialWrite eventBleSerialWrite) : this(comboBox)
        {
            this.EventBleSerialWrite = eventBleSerialWrite;
        }

        public SerialBle(ToolStripComboBox comboBox, DelegateBleSerialWrite eventBleSerialWrite, DelegateBleLog eventBleLog) : this(comboBox, eventBleSerialWrite)
        {
            this.EventBleLog = eventBleLog;
        }
        #endregion

        #region 属性
        public bool IsAutoReLink = false;
        public int TimeAutoReLink = 100;
        public enumBleStatus SerialBleStatus { get; private set; } = enumBleStatus.Stop;
        public ToolStripComboBox ComboBle { get; set; }
        public Dictionary<string, string> DicBleBlackListConfig { get; set; }
        public Dictionary<string, string> DicBleNameReplaceConfig { get; set; }
        public Dictionary<string, string> DicBleNameFilterConfig { get; set; }
        public Dictionary<string, string> DicListBle { get; private set; }
        public Dictionary<string, int> DicListBleRssi { get; private set; }
        #endregion

        #region 事件
        /// <summary>
        /// 定义发送数据委托
        /// </summary>
        /// <param name="arrData">发送数据数组</param>
        public delegate void DelegateBleSerialWrite(string[] arrData);

        /// <summary>
        /// 定义蓝牙日志委托
        /// </summary>
        /// <param name="strLog"></param>
        public delegate void DelegateBleLog(string strLog);

        /// <summary>
        /// 定义发送数据事件
        /// </summary>
        public event DelegateBleSerialWrite EventBleSerialWrite;

        /// <summary>
        /// 定义蓝牙日志事件
        /// </summary>
        public event DelegateBleLog EventBleLog;
        #endregion

        #region 公共函数
        /// <summary>
        /// 获取蓝牙命令
        /// </summary>
        /// <param name="cmd">命令枚举</param>
        /// <returns>串口命令字符串</returns>
        public string[] GetBleCmd(enumBleCmd cmd)
        {
            List<string> listBleCmd = new List<string>();
            setSerialBleCmd(cmd);
            switch (cmd)
            {
                case enumBleCmd.Init:
                    setSerialBleStatus(enumBleStatus.Stop);
                    listBleCmd.Add("AT");
                    break;
                case enumBleCmd.Find:
                    if (SerialBleStatus == enumBleStatus.Ready)
                    {
                        setSerialBleStatus(enumBleStatus.Find);
                        listBleCmd.Add("AT+DISC?");
                    }
                    else
                    {
                        EventBleLog("搜索失败请重试");
                        return GetBleCmd(enumBleCmd.Init);
                    }
                    break;
                case enumBleCmd.Link:
                    if (SerialBleStatus == enumBleStatus.Ready)
                    {
                        setSerialBleStatus(enumBleStatus.Link);
                        if (ComboBle.Items.Count > 0 && ComboBle.SelectedIndex >= 0)
                        {
                            setSerialBleStatus(enumBleStatus.Link);
                            //listBleCmd.Add("AT+CONN" + ComboBle.SelectedIndex);
                            listBleCmd.Add("AT+CON" + DicListBle[ComboBle.SelectedItem.ToString()]);
                            _bakBleLinkData = ComboBle.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        Console.WriteLine("请先搜索蓝牙设备。");
                        EventBleLog("请先搜索蓝牙设备");
                    }
                    break;
                case enumBleCmd.Reset:
                    setSerialBleStatus(enumBleStatus.Stop);
                    listBleCmd.Add("AT");
                    listBleCmd.Add("AT+RESET");
                    break;
                case enumBleCmd.ReLink:
                    if (ComboBle.Items.Count > 0 && DicListBle.ContainsKey(_bakBleLinkData))
                    {
                        ComboBle.SelectedIndex = ComboBle.Items.IndexOf(_bakBleLinkData);
                        return GetBleCmd(enumBleCmd.Link);
                    }
                    break;
                default:
                    break;
            }
            return listBleCmd.ToArray();
        }

        /// <summary>
        /// 发送蓝牙命令
        /// </summary>
        /// <param name="cmd">蓝牙命令</param>
        public void WriteBleCmd(enumBleCmd cmd)
        {
            //安全性检验
            //if (SerialBleStatus == enumBleStatus.Stop)
            //{
            //    //Console.WriteLine("串口未开启，无法发生命令。");
            //    return;
            //}

            //发送蓝牙命令
            string[] arrCmdData = this.GetBleCmd(cmd);
            if (EventBleSerialWrite != null)
            {
                EventBleSerialWrite(arrCmdData);
            }
        }

        /// <summary>
        /// 接收蓝牙串口数据
        /// </summary>
        /// <param name="strBleData"></param>
        public void ReceiveSerialBle(string strBleData)
        {
            //过滤
            strBleData = Regex.Replace(strBleData, @"\s", "");
            if (strBleData == "OK")
            {
                setSerialBleStatus(enumBleStatus.Ready);
                WriteBleCmd(enumBleCmd.Find);
            }
            else if (strBleData.IndexOf("OK+DISCS") >= 0)
            {
                //开启搜索蓝牙
                setSerialBleStatus(enumBleStatus.Find);
                DicListBle.Clear();
                DicListBleRssi.Clear();
                ComboBle.Items.Clear();
                ComboBle.Enabled = false;
                EventBleLog("蓝牙搜索中");
                Console.WriteLine("搜索中。。。");
                //测试
                //string str = "OK+DIS0:04AC448009BDOK+NAME:Tomozaki02\r\nOK + DIS0:04AC448001F6OK + NAME:Tomozaki01";
                //Console.WriteLine("测试：" + str);
                //ReceiveSerialBle(str);
            }
            else if (strBleData.IndexOf("OK+DISCE") >= 0)
            {
                //搜索蓝牙结束
                if (DicListBle.Count > 0)
                {
                    setSerialBleStatus(enumBleStatus.Ready);
                    ComboBle.Enabled = true;
                    ComboBle.Items.AddRange(LinqDictionary(DicListBleRssi, DicListBle));
                    ComboBle.SelectedIndex = 0;
                    EventBleLog("蓝牙搜索完成");
                    if (IsAutoReLink && (_bakBleLinkData != ""))
                    {
                        if (DicListBle.ContainsKey(_bakBleLinkData))
                        {
                            WriteBleCmd(enumBleCmd.ReLink);
                        }
                        else
                        {
                            WriteBleCmd(enumBleCmd.Find);
                        }
                    }
                }
                else
                {
                    setSerialBleStatus(enumBleStatus.Stop);
                    ComboBle.Enabled = false;
                    EventBleLog("未搜索到蓝牙");
                    Console.WriteLine("未搜索到蓝牙");
                }

            }
            else if (strBleData.IndexOf("OK+DIS0") >= 0)
            {
                string[] arrBleData = Regex.Split(strBleData, @"OK\+DIS0\:", RegexOptions.IgnoreCase);
                for (int i = 0; i < arrBleData.Length; i++)
                {
                    Int32 cnt = arrBleData[i].Length;
                    string strMac = "";
                    Int32 numRSSI = 0;
                    if (cnt >= 12)
                    {
                        if (arrBleData[i].IndexOf("OK+DIS") == 0)
                        {
                            strMac = arrBleData[i].Substring(8, 12);
                        }
                        else
                        {
                            strMac = arrBleData[i].Substring(0, 12);
                        }
                        cnt = arrBleData[i].IndexOf("OK+RSSI:");
                        if (cnt > 0)
                        {
                            try
                            {
                                numRSSI = Convert.ToInt32(arrBleData[i].Substring(cnt + 8, 4));
                                DicListBleRssi.Add(strMac, Convert.ToInt32(numRSSI));
                            }
                            catch (Exception err)
                            {
                                Console.WriteLine("RSSI:" + err.Message);
                            }
                        }
                        cnt = arrBleData[i].IndexOf("OK+NAME:");
                        if (cnt >= 0)
                        {
                            string strName = arrBleData[i].Substring(cnt + 8);
                            addListBle(strMac, strName, numRSSI);
                            Console.WriteLine("搜索蓝牙:" + strName + ":" + strMac + ":" + numRSSI.ToString());
                        }
                    }
                }
            }
            else if (strBleData == "OK+CONN" + ComboBle.SelectedIndex || strBleData == "OK+CONNA")
            {
                //正在连接蓝牙
                setSerialBleStatus(enumBleStatus.Link);
                EventBleLog("正在连接蓝牙");
                Console.WriteLine("正在连接蓝牙:" + ComboBle.SelectedText);
            }
            else if (strBleData == "OK+CONNF")
            {
                //连接失败
                setSerialBleStatus(enumBleStatus.Stop);
                ComboBle.Enabled = false;
                EventBleLog("连接蓝牙失败");
                Console.WriteLine("连接蓝牙失败" + ComboBle.SelectedText);
            }
            else if (strBleData == "OK+CONN")
            {
                //连接成功
                setSerialBleStatus(enumBleStatus.Run);
                ComboBle.Enabled = false;
                EventBleLog("连接蓝牙成功");
                Console.WriteLine("连接蓝牙成功" + ComboBle.SelectedText);
            }
            else if (strBleData.IndexOf("OK+LOST") >= 0)
            {
                setSerialBleStatus(enumBleStatus.Stop);
                WriteBleCmd(enumBleCmd.Init);
                EventBleLog("蓝牙连接断开");
            }
        }
        #endregion

        #region 私有函数
        /// <summary>
        /// 初始化定时器
        /// </summary>
        private void initTimBleWrite()
        {
            _timBleWrite = new System.Timers.Timer(1000);
            _timBleWrite.Elapsed += new System.Timers.ElapsedEventHandler(TimerBleWrite);
            _timBleWrite.AutoReset = true;
            _timBleWrite.Enabled = true;
        }

        /// <summary>
        /// 设置蓝牙状态
        /// </summary>
        /// <param name="status">蓝牙状态枚举</param>
        private void setSerialBleStatus(enumBleStatus status)
        {
            this.SerialBleStatus = status;
        }

        /// <summary>
        /// 设置蓝牙命令
        /// </summary>
        /// <param name="cmd">蓝牙命令枚举</param>
        private void setSerialBleCmd(enumBleCmd cmd)
        {
            this._serialBleCmd = cmd;
        }

        /// <summary>
        /// 添加蓝牙列表
        /// </summary>
        /// <param name="mac">Mac地址</param>
        /// <param name="name">蓝牙名称</param>
        private void addListBle(string mac, string name, Int32 rssi = 0)
        {
            AppConfig appConfig = new AppConfig();
            if (appConfig.GetConfig("BleNameFilter") == "True" && DicBleNameFilterConfig.Count > 0)
            {
                try
                {
                    if (DicBleNameFilterConfig[name] == "False")
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            if (DicBleNameReplaceConfig.Count > 0)
            {
                foreach (KeyValuePair<string,string> item in DicBleNameReplaceConfig)
                {
                    name = name.Replace(item.Key, item.Value);
                }
            }
            if (DicBleBlackListConfig.Count > 0)
            {
                foreach (KeyValuePair<string, string> item in DicBleBlackListConfig)
                {
                    if (mac == item.Key)
                    {
                        return;
                    }
                }
            }
            string strBleData;
            if (rssi < 0)
            {
                strBleData = name + ":" + mac + " (" + rssi + ")";
            }
            else
            {
                strBleData = name + ":" + mac;
            }
            DicListBle.Add(strBleData, mac);
        }

        private string[] LinqDictionary(Dictionary<string, int> dic, Dictionary<string, string> dicListBle)
        {
            string[] arrayName = new string[dic.Count];
            int[] arrayValue = new int[dic.Count];
            dic.Keys.CopyTo(arrayName, 0);
            dic.Values.CopyTo(arrayValue, 0);
            Array.Sort(arrayValue, arrayName);//会根据arrayValue的值进行升序排序，arrayName对应的会进行位置调整
            Array.Reverse(arrayValue);//这是为了降序
            Array.Reverse(arrayName);
            IDictionary<string, string> dicSorted = new Dictionary<string, string>();
            for (int i = 0; i < arrayName.Length; i++)
            {
                foreach (KeyValuePair<string, string> kvp in dicListBle)
                {
                    if (kvp.Value == arrayName[i])
                    {
                        dicSorted.Add(kvp.Key, kvp.Value);
                        break;
                    }
                }
            }
            return dicSorted.Keys.ToArray();
        }
        #endregion

        #region 定时器函数
        /// <summary>
        /// 定时器处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBleWrite(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (SerialBleStatus == enumBleStatus.Stop)
            {
                WriteBleCmd(enumBleCmd.Init);
            }
        }
        #endregion
    }

    #region 枚举
    /// <summary>
    /// 蓝牙命令枚举
    /// </summary>
    public enum enumBleCmd
    {
        Init = 0,   //初始化
        Find = 1,   //搜索蓝牙
        Link = 2,   //连接蓝牙
        Reset = 3,   //重启蓝牙
        ReLink = 12,   //重新连接蓝牙
    }

    /// <summary>
    /// 蓝牙状态枚举
    /// </summary>
    public enum enumBleStatus
    {
        Stop,   //停止状态（上电或重启中）
        Ready,  //就绪状态（发送AT并返回OK）
        Find,   //搜索蓝牙中
        Link,   //连接蓝牙中
        Run,    //蓝牙通信中
        Error   //发生错误
    }
    #endregion
}
