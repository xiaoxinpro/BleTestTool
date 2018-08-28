using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialPortHelperLib;

namespace BleTestTool
{
    public class SerialBleLinkTest
    {
        #region 字段
        private SerialBle serialBle;
        private Timer BleLinkTimer;
        private Label LabelBleLinkTestCount;
        private string BleLinkLogPath = "";
        private int BleLinkCount = 0;
        private int BleLinkPassCnt = 0;
        private int BleLinkFailCnt = 0;
        private List<string> BleLinkFailData = new List<string>();
        #endregion

        #region 属性
        public bool IsOpenTest { get { return BleLinkTimer.Enabled; } }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="sb">串口蓝牙类</param>
        /// <param name="l">测试次数显示Label</param>
        public SerialBleLinkTest(SerialBle sb, Label l)
        {
            serialBle = sb;
            LabelBleLinkTestCount = l;
            BleLinkTimer = new System.Windows.Forms.Timer();
            BleLinkTimer.Tick += BleLinkTimer_Tick;
            BleLinkTimer.Enabled = false;
        }

        #endregion

        #region 公共函数
        public void StartTest(string path, int interval = 60, int count = 10)
        {
            BleLinkLogPath = path;
            BleLinkCount = count;
            LabelBleLinkTestCount.Text = "0";
            BleLinkPassCnt = 0;
            BleLinkFailCnt = 0;
            BleLinkFailData.Clear();

            BleLinkTimer.Interval = interval * 1000;
            BleLinkTimer.Enabled = true;

            WriteFile(DateTime.Now.ToString() + "\t开启测试" + "\t间隔：" + interval + "秒" + "\t有效次数：" + count);
        }

        public void StopTest()
        {
            BleLinkTimer.Enabled = false;
            WriteFile(DateTime.Now.ToString() + "\t停止测试");
        }

        public void SerialData(byte[] arrData, bool isSend = false)
        {
            if (IsOpenTest)
            {
                if (isSend)
                {
                    //发送数据

                }
                else
                {
                    //接收数据
                    if (ByteCheakSum(arrData, 0, arrData.Length - 1) == arrData[arrData.Length - 1])
                    {
                        BleLinkPassCnt++;
                    }
                    else if (BleLinkPassCnt > 0)
                    {
                        BleLinkFailData.Add(SerialPortHelperLib.SerialData.ToHexString(arrData));
                        BleLinkFailCnt++;
                    }
                }
            }
        }
        #endregion

        #region 定时器
        /// <summary>
        /// 测试专用定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BleLinkTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LabelBleLinkTestCount.Text) > 0)
            {
                Console.WriteLine("成功通信：" + BleLinkPassCnt + ",失败通信：" + BleLinkFailCnt);
                WriteLog();
            }
            LabelBleLinkTestCount.Text = (Convert.ToInt32(LabelBleLinkTestCount.Text) + 1).ToString();
            serialBle.WriteBleCmd(enumBleCmd.Find);
            BleLinkFailData.Clear();
            BleLinkPassCnt = 0;
            BleLinkFailCnt = 0;
        }
        #endregion

        #region 私有函数
        /// <summary>
        /// 计算校验和
        /// </summary>
        /// <param name="bytes">检验数组</param>
        /// <param name="start">校验起始位置</param>
        /// <param name="length">校验长度</param>
        /// <returns>校验和</returns>
        private byte ByteCheakSum(byte[] bytes, int start = 0, int length = 0)
        {
            UInt32 sum = 1;
            if (length == 0)
            {
                length = bytes.Length - start;
            }
            for (int i = start; i < length + start; i++)
            {
                sum += Convert.ToUInt32(bytes[i]);
            }
            return Convert.ToByte(sum & 0xFF);
        }

        private void WriteFile(string data, params string[] arrData)
        {
            using (FileStream fs = new FileStream(BleLinkLogPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.WriteLine(data);
                    foreach (string item in arrData)
                    {
                        sw.WriteLine("\t" + item);
                    }
                    sw.Flush();
                }
            }
        }

        private void WriteLog()
        {
            string strNow = DateTime.Now.ToString();
            string strStatus = "无效";
            if (BleLinkPassCnt > BleLinkCount)
            {
                strStatus = "有效";
            }
            WriteFile(strNow + "\t" + strStatus + "\t通信成功：" + BleLinkPassCnt + "\t通信失败：" + BleLinkFailCnt, BleLinkFailData.ToArray<string>());        }
        #endregion

        #region 私有函数

        #endregion
    }
}
