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
        private enumBleStatus _serialBleStatus = enumBleStatus.Stop;
        private ToolStripComboBox _comboBle;
        private List<string> _listBle;
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialBle(ToolStripComboBox comboBox)
        {
            ComboBle = comboBox;
            ListBle = new List<string> { };
        }
        #endregion

        #region 属性
        public enumBleStatus SerialBleStatus { get => _serialBleStatus;}
        public ToolStripComboBox ComboBle { get => _comboBle; set => _comboBle = value; }
        public List<string> ListBle { get => _listBle; set => _listBle = value; }
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
            _serialBleCmd = cmd;
            switch (cmd)
            {
                case enumBleCmd.Init:
                    setSerialBleStatus(enumBleStatus.Stop);
                    listBleCmd.Add("AT");
                    listBleCmd.Add("AT");
                    break;
                case enumBleCmd.Find:
                    if (SerialBleStatus == enumBleStatus.Ready)
                    {
                        setSerialBleStatus(enumBleStatus.Find);
                        listBleCmd.Add("AT");
                        listBleCmd.Add("AT+DISC?");
                    }
                    break;
                case enumBleCmd.Link:
                    if (SerialBleStatus == enumBleStatus.Ready)
                    {
                        setSerialBleStatus(enumBleStatus.Link);
                        if (ComboBle.Items.Count > 0 && ComboBle.SelectedIndex >= 0)
                        {
                            setSerialBleStatus(enumBleStatus.Link);
                            listBleCmd.Add("AT+CONN" + ComboBle.SelectedIndex);
                        }
                    }
                    break;
                case enumBleCmd.Reset:
                    setSerialBleStatus(enumBleStatus.Stop);
                    listBleCmd.Add("AT");
                    listBleCmd.Add("AT+RESET");
                    break;
                default:
                    break;
            }
            return listBleCmd.ToArray();
        }

        public void ReceiveSerialBle(string strBleData)
        {
            //过滤
            strBleData = Regex.Replace(strBleData, @"\s", "");
            switch (_serialBleCmd)
            {
                case enumBleCmd.Init:
                    if (strBleData == "OK")
                    {
                        setSerialBleStatus(enumBleStatus.Ready);
                    }
                    break;
                case enumBleCmd.Find:
                    if (strBleData.IndexOf("OK+DISCS") >= 0)
                    {
                        //开启搜索蓝牙
                        setSerialBleStatus(enumBleStatus.Find);
                        ListBle.Clear();
                        ComboBle.Items.Clear();
                        ComboBle.Enabled = false;
                        ComboBle.Text = "搜索中。。。";
                        Console.WriteLine("搜索中。。。");
                    }
                    else if (strBleData.IndexOf("OK+DISCE") >= 0)
                    {
                        //搜索蓝牙结束
                        setSerialBleStatus(enumBleStatus.Ready);
                        ComboBle.Enabled = true;
                        if (ListBle.Count > 0)
                        {
                            ComboBle.Enabled = true;
                            ComboBle.Items.AddRange(ListBle.ToArray());
                            ComboBle.SelectedIndex = 0;
                        }
                        else
                        {
                            ComboBle.Enabled = false;
                            ComboBle.Text = "未搜索到蓝牙";
                            Console.WriteLine("未搜索到蓝牙");
                        }

                    }
                    else if (SerialBleStatus == enumBleStatus.Find)
                    {
                        Int32 len = ComboBle.Items.Count;
                        Int32 cnt = strBleData.IndexOf("OK+DIS" + len + ":");
                        string strMac = "";
                        if (cnt >= 0)
                        {
                            strMac = strBleData.Substring(cnt + 8, 12);
                            cnt = strBleData.IndexOf("OK+NAME:");
                            if (cnt >= 0)
                            {
                                strMac = strBleData.Substring(cnt + 8) + ":" + strMac;
                                Console.WriteLine("搜索蓝牙:" + strMac);
                                ListBle.Add(strMac);
                            }
                        }

                    }
                    break;
                case enumBleCmd.Link:
                    if (strBleData == "OK+CONN" + ComboBle.SelectedIndex)
                    {
                        //正在连接蓝牙
                        setSerialBleStatus(enumBleStatus.Link);
                        Console.WriteLine("正在连接蓝牙:" + ComboBle.SelectedText);
                    }
                    else if (strBleData == "OK+CONN")
                    {
                        //连接成功
                        setSerialBleStatus(enumBleStatus.Run);
                        Console.WriteLine("连接蓝牙成功" + ComboBle.SelectedText);
                    }
                    break;
                case enumBleCmd.Reset:
                    break;
                default:
                    break;
            }

        }
        #endregion

        #region 私有函数
        private void setSerialBleStatus(enumBleStatus status)
        {
            this._serialBleStatus = status;
        }
        #endregion
    }

    /// <summary>
    /// 蓝牙命令枚举
    /// </summary>
    public enum enumBleCmd
    {
        Init = 0,   //初始化
        Find = 1,   //搜索蓝牙
        Link = 2,   //连接蓝牙
        Reset = 3   //重启蓝牙
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
}
