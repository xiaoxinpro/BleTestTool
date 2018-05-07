using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialPortHelperLib;

namespace BleTestTool
{
    public partial class frmMain : Form
    {
        //定义ConfigCom类
        private ConfigCom configCom;

        //定义SerialPortHelper类
        private SerialPortHelper serialPortHelper;

        //定义串口蓝牙类
        private SerialBle serialBle;

        #region 初始化页面
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //初始化界面
            GroupEnable(gbSerialWrite, false);
            serialBle = new SerialBle(toolComboBle);
            initListView(listViewSerialReceived);

            //初始化串口配置控件
            initSerialConfig();

            //初始化串口助手
            initSerialPortHelper();
        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        private void initListView(ListView listView)
        {
            string[] arrListName = { "状态", "模式", "皮肤接触", "时长", "加热温度", "皮肤检测参数", "环境温度", "电池状态"};
            string[] arrListMark = { "设备工作状态", "设备当前运行的测试项目", "检测皮肤是否接触电极片", "当前模式运行的时长（秒）", "当前加热片的温度（℃）", "皮肤检测参数", "当前环境温度（℃）", "当前电池电量状态" };
            //基本属性设置
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;

            //创建列表头
            listView.Columns.Add("序号", 50, HorizontalAlignment.Center);
            listView.Columns.Add("名称", 100, HorizontalAlignment.Center);
            listView.Columns.Add("值", 100, HorizontalAlignment.Center);
            listView.Columns.Add("备注", 200, HorizontalAlignment.Left);

            //添加数据
            listView.BeginUpdate();
            for (int i = 0; i < arrListName.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = i.ToString();
                listViewItem.SubItems.Add(arrListName[i]);
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(arrListMark[i]);
                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();
        }

        /// <summary>
        /// 初始化串口配置控件
        /// </summary>
        private void initSerialConfig()
        {
            configCom = new ConfigCom(cbSerial);
            configCom.BindBaudRateObj(cbBaudRate);
            configCom.BindDataBitsObj(cbDataBits);
            configCom.BindStopBitsObj(cbStop);
            configCom.BindParityObj(cbParity);
        }

        /// <summary>
        /// 初始化串口助手
        /// </summary>
        private void initSerialPortHelper()
        {
            serialPortHelper = new SerialPortHelper();
            serialPortHelper.ConfigSerialPort = configCom.GetConfigComData();
            serialPortHelper.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));
            serialPortHelper.BindSerialPortErrorEvent(new SerialPortHelper.DelegateSerialPortErrorEvent(SerialPortErrorProcess));
            serialPortHelper.SerialReceviedTimeInterval = 40;
            serialPortHelper.SerialWriteTimeInterval = 100;
            serialPortHelper.SerialReceviedLengthMax = 1024;
        }
        #endregion

        #region 串口事件

        /// <summary>
        /// 串口接收数据处理
        /// </summary>
        /// <param name="arrData">接收数据数组</param>
        private void SerialPortDataReceivedProcess(byte[] arrData)
        {
            if (chkShowWrite.Checked)
            {
                txtDataReceived.AppendText("[接收]");
            }
            if (chkShowTime.Checked)
            {
                txtDataReceived.AppendText("[" + DateTime.Now.ToString() + "] ");
            }
            if (!SerialData.IsBytesToString(arrData))
            {
                Console.WriteLine("接收数据：" + SerialData.ToHexString(arrData));
                txtDataReceived.AppendText(SerialData.ToHexString(arrData) + "\r\n");
                if (arrData[0] == 0x52)
                {
                    BytesReceviedDataProcess(arrData);
                }
            }
            else
            {
                string strData = SerialData.ToString(arrData);
                Console.WriteLine("接收数据：" + SerialData.ToString(arrData));
                txtDataReceived.AppendText(strData + "\r\n");
                if (strData.IndexOf("OK") >= 0)
                {
                    serialBle.ReceiveSerialBle(strData);
                }
            }

        }

        /// <summary>
        /// 串口错误事件
        /// </summary>
        /// <param name="enumError">错误枚举</param>
        /// <param name="strError">错误内容</param>
        private void SerialPortErrorProcess(enumSerialError enumError, string strError)
        {
            switch (enumError)
            {
                case enumSerialError.LinkError:
                    serialPortHelper.CloseCom(out string str);
                    Console.WriteLine("串口错误：" + strError);
                    //MessageBox.Show(strError, "串口错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case enumSerialError.WriteError:
                    Console.WriteLine("发送错误：" + strError);
                    break;
                case enumSerialError.ReceivedError:
                    Console.WriteLine("接收错误：" + strError);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 串口方法

        /// <summary>
        /// 添加发送数据
        /// </summary>
        /// <param name="arrData">byte数组数据</param>
        private void AddSerialWrite(byte[] arrData)
        {
            if (arrData.Length < 1 || !serialPortHelper.IsOpen)
            {
                return;
            }
            serialPortHelper.Write(arrData);

            if (chkShowWrite.Checked)
            {
                txtDataReceived.AppendText("[发送]");
                if (chkShowTime.Checked)
                {
                    txtDataReceived.AppendText("[" + DateTime.Now.ToString() + "] ");
                }
                if (chkLogHex.Checked || !SerialData.IsBytesToString(arrData))
                {
                    txtDataReceived.AppendText(SerialData.ToHexString(arrData) + "\r\n");
                }
                else
                {
                    txtDataReceived.AppendText(SerialData.ToString(arrData) + "\r\n");
                }
            }

        }

        /// <summary>
        /// 添加发送数据
        /// </summary>
        /// <param name="strData">字符串数据</param>
        private void AddSerialWrite(string strData)
        {
            if (strData.Length > 0)
            {
                AddSerialWrite(SerialData.ToByteArray(strData));
            }
        }
        #endregion

        #region 控件
        /// <summary>
        /// 打开/关闭串口按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialPortSwitch_Click(object sender, EventArgs e)
        {
            if (btnSerialPortSwitch.Text == "打开串口")
            {
                serialPortHelper.OpenCom(configCom.GetConfigComData(), out string strError);
                if (strError != "null")
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    Console.WriteLine("开启{0}端口成功。", configCom.PortName);
                    GroupEnable(gbSerialWrite, true);
                    btnSerialPortSwitch.Text = "关闭串口";
                    ClearListViewSerialReceviedValue();
                }
            }
            else
            {
                serialPortHelper.CloseCom(out string strError);
                if (strError != "null")
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    Console.WriteLine("关闭端口成功。");
                    GroupEnable(gbSerialWrite, false);
                    btnSerialPortSwitch.Text = "打开串口";
                }
            }
        }

        /// <summary>
        /// 清空日志按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogClear_Click(object sender, EventArgs e)
        {
            txtDataReceived.Clear();
        }

        /// <summary>
        /// 蓝牙命令发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBleWrite_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string[] arrBleCmd = serialBle.GetBleCmd((enumBleCmd)Convert.ToInt32(e.ClickedItem.Tag));
            Console.WriteLine("选择蓝牙命令：" + e.ClickedItem.Text);
            foreach (string item in arrBleCmd)
            {
                AddSerialWrite(item);
            }
            ClearListViewSerialReceviedValue();
        }

        /// <summary>
        /// 快捷发送命令工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolCmdWrite_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine("选择快捷命令：" + e.ClickedItem.Name + " - " + e.ClickedItem.Text);
            byte[] buffer = { 0x52, 0x02, 0x01, 0x10, 0x00, 0x00 };
            buffer[4] = Convert.ToByte(Convert.ToInt32(e.ClickedItem.Tag));
            buffer[buffer.Length - 1] = ByteCheakSum(buffer);
            Console.WriteLine(SerialData.ToHexString(buffer));
            AddSerialWrite(buffer);
        }

        /// <summary>
        /// 发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialWrite_Click(object sender, EventArgs e)
        {
            if(txtSerialWrite.Text.Length > 0)
            {
                if (rioHex.Checked)
                {
                    AddSerialWrite(SerialData.ToHexByteArray(txtSerialWrite.Text));
                }
                else if (rioString.Checked)
                {
                    AddSerialWrite(txtSerialWrite.Text);
                }
                else
                {
                    MessageBox.Show("未知错误，无法选择发送格式！");
                }
            }
        }
        #endregion

        #region 数据列表方法

        private void BytesReceviedDataProcess(byte[] arrData)
        {
            int data = 0;
            string str = "";

            if (arrData.Length < 13)
            {
                Console.WriteLine("无法解析数据：" + SerialData.ToHexString(arrData));
                return;
            }

            //状态与模式处理
            data = arrData[4];
            if (data == 0x00)
            {
                EditListViewSerialReceviedValue(0, "关机");
                EditListViewSerialReceviedValue(1, "关机");
            }
            else
            {
                //状态处理
                if ((data & 0x10) == 0x00)
                {
                    EditListViewSerialReceviedValue(0, "自动");
                }
                else
                {
                    EditListViewSerialReceviedValue(0, "手动");
                }

                //模式处理
                int modeData = data & 0x0F;
                string[] arrModeData = { "自动", "加热测试", "电机测试", "制冷测试", "正脉冲测试", "负脉冲测试", "皮肤接触检测", "皮肤水份检测", "关机" };
                if (modeData <= 0x07)
                {
                    EditListViewSerialReceviedValue(1, arrModeData[modeData]);
                }
                else
                {
                    EditListViewSerialReceviedValue(1, "关机");
                }
            }

            //皮肤接触处理
            data = arrData[5];
            if (data == 0x00) 
            {
                EditListViewSerialReceviedValue(2, "False");
            }
            else if (data == 0x01)
            {
                EditListViewSerialReceviedValue(2, "True");
            }
            else
            {
                EditListViewSerialReceviedValue(2, "未知:0x" + data.ToString("X2"));
            }

            //时长处理
            data = arrData[6];
            EditListViewSerialReceviedValue(3, data.ToString());

            //加热温度
            data = arrData[7];
            EditListViewSerialReceviedValue(4, data.ToString());

            //皮肤检测参数
            data = (arrData[8] << 8) | arrData[9];
            EditListViewSerialReceviedValue(5, "0x" + data.ToString("X4"));

            //环温
            data = arrData[10];
            EditListViewSerialReceviedValue(6, data.ToString());

            //电池状态
            data = arrData[11];
            switch (data)
            {
                case 0x00:
                    str = "无电量";
                    break;
                case 0x01:
                    str = "20%电量";
                    break;
                case 0x02:
                    str = "40%电量";
                    break;
                case 0x03:
                    str = "60%电量";
                    break;
                case 0x04:
                    str = "80%电量";
                    break;
                case 0x05:
                    str = "100%电量";
                    break;
                case 0x06:
                    str = "充电中";
                    break;
                case 0x07:
                    str = "充电完成";
                    break;
                default:
                    str = "未知:0x" + data.ToString("X2");
                    break;
            }
            EditListViewSerialReceviedValue(7, str);

        }

        /// <summary>
        /// 编辑串口接收数据值
        /// </summary>
        /// <param name="line">行号</param>
        /// <param name="value">值</param>
        private void EditListViewSerialReceviedValue(int line, string value)
        {
            if (line >= 0 && line < listViewSerialReceived.Items.Count)
            {
                if (listViewSerialReceived.Items[line].SubItems[2].Text != value)
                {
                    listViewSerialReceived.Items[line].SubItems[2].Text = value;
                }
            }
        }

        /// <summary>
        /// 清空串口解析列表
        /// </summary>
        private void ClearListViewSerialReceviedValue()
        {
            listViewSerialReceived.BeginUpdate();
            for (int i = 0; i < listViewSerialReceived.Items.Count; i++)
            {
                listViewSerialReceived.Items[i].SubItems[2].Text = "";
            }
            listViewSerialReceived.EndUpdate();
        }
        #endregion

        #region 基础方法
        /// <summary>
        /// 获取发送数据格式
        /// </summary>
        /// <returns></returns>
        private SerialFormat GetWriteFormat()
        {
            if (rioHex.Checked)
            {
                return SerialFormat.Hex;
            }
            else if (rioString.Checked)
            {
                return SerialFormat.String;
            }
            else
            {
                return SerialFormat.None;
            }
        }

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

        /// <summary>
        /// 检测二进制某一位
        /// </summary>
        /// <param name="Num">二进制数</param>
        /// <param name="Bin">需要检查的位置</param>
        /// <returns></returns>
        private bool IsBinTest(byte Num, int Bin)
        {
            if (((Num >> Bin) & 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GroupEnable(GroupBox groupBox, bool isEnable)
        {
            foreach (Control obj in groupBox.Controls)
            {
                obj.Enabled = isEnable;
            }
        }


        #endregion

    }
}
