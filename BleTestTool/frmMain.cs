using DeviceTestLib;
using SerialPortHelperLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BleTestTool
{
    public partial class frmMain : Form
    {
        private string STR_TITLE = "串口蓝牙测试工具";

        //定义AppConfig类
        private AppConfig appConfig;

        //定义BleConfig类
        private BleConfig bleConfig;

        //定义ConfigCom类
        private ConfigCom configCom;

        //定义SerialPortHelper类
        private SerialPortHelper serialPortHelper;

        //定义DeviceTest类
        private DeviceTestLib.IDeviceTest deviceTest;

        //定义串口蓝牙类
        private SerialBle serialBle;

        //定义蓝牙配置窗体
        private Form _frmBleConfig;

        //定义蓝牙连接测试类
        private SerialBleLinkTest bleLinkTest;

        #region 初始化页面
        private string strBleConfigName = "Main";

        /// <summary>
        /// 主页入口
        /// </summary>
        /// <param name="args"></param>
        public frmMain(string[] args)
        {
            InitializeComponent();

            //版本号显示
            STR_TITLE += @" V" + Application.ProductVersion.ToString();

            //读取命令行参数
            if (args.Length == 1 && LoadDeviceLib(args[0]))
            {
                btnLoadDeviceLib.Hide();
                gbBleLinkTest.Hide();
                gbBleFuction.Hide();
            }
            else
            {
                this.Text = STR_TITLE;
                toolStripStatusLabelDriverVersion.Text = @"V" + Application.ProductVersion.ToString();
            }

            //开启窗体快捷键
            this.KeyPreview = true;
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
            serialBle = new SerialBle(toolComboBle, new SerialBle.DelegateBleSerialWrite(AddSerialWrite));
            serialBle.EventBleLog += OutputBleLog;

            //初始化配置
            appConfig = new AppConfig();

            //初始化蓝牙配置
            initBleConfig(strBleConfigName);

            //初始化串口配置控件
            initSerialConfig();
            GetSerialLogConfig(gbSerialLog);

            //初始化串口助手
            initSerialPortHelper();

            //初始化蓝牙连接测试
            initBleLinkTest();
        }

        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Shown(object sender, EventArgs e)
        {
            //加载Dll文件
            if (btnLoadDeviceLib.Visible)
            {
                CallOnClick(btnLoadDeviceLib);
            }
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭串口
            serialPortHelper.CloseCom(out string strError);
        }

        /// <summary>
        /// 初始化串口配置控件
        /// </summary>
        private void initSerialConfig()
        {
            //实例化串口配置
            configCom = new ConfigCom(cbSerial);
            configCom.BindBaudRateObj(cbBaudRate);
            configCom.BindDataBitsObj(cbDataBits);
            configCom.BindStopBitsObj(cbStop);
            configCom.BindParityObj(cbParity);
            configCom.BaudRate = 115200;

            //初始化串口配置
            ConfigComType defConfig = GetSerialConfig();
            configCom.BaudRate = defConfig.BaudRate;
            configCom.DataBits = defConfig.DataBits;
            configCom.StopBits = defConfig.StopBits;
            configCom.Parity = defConfig.Parity;

            //设置串口搜索默认值
            configCom.SetSerialPortDefaultInfo("USB 串行设备"); //TI CC2540 USB CDC Serial Port
            configCom.AddSerialPortDefaultInfo("TI CC2540 USB CDC Serial Port");
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
            serialPortHelper.SerialWriteTimeInterval = 200;
            serialPortHelper.SerialReceviedLengthMax = 1024;
        }

        /// <summary>
        /// 初始化Ble配置
        /// </summary>
        /// <param name="configName">配置名称</param>
        private void initBleConfig(string configName = "Main")
        {
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"BleConfig\" + configName + @"\";

            //初始化配置
            bleConfig = new BleConfig(path);

            //配置绑定
            serialBle.DicBleBlackListConfig = bleConfig.DicBleBlackListConfig;
            serialBle.DicBleNameReplaceConfig = bleConfig.DicBleNameReplaceConfig;
            serialBle.DicBleNameFilterConfig = bleConfig.DicBleNameFilterConfig;
        }

        /// <summary>
        /// 初始化蓝牙连接测试
        /// </summary>
        private void initBleLinkTest()
        {
            bleLinkTest = new SerialBleLinkTest(serialBle, labelBleLinkTestCount);
        }
        #endregion

        #region 串口事件

        /// <summary>
        /// 串口接收数据处理
        /// </summary>
        /// <param name="arrData">接收数据数组</param>
        private void SerialPortDataReceivedProcess(byte[] arrData)
        {
            this.Invoke(new Action(() =>
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
                    try
                    {
                        deviceTest.BytesReceviedDataProcess(arrData);
                        bleLinkTest.SerialData(arrData);
                        OutputBleLog("连接蓝牙成功");
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    string strData = SerialData.ToString(arrData);
                    if (chkLogHex.Checked)
                    {
                        txtDataReceived.AppendText(SerialData.ToHexString(arrData) + "\r\n");
                    }
                    else
                    {
                        txtDataReceived.AppendText(strData + "\r\n");
                    }
                    Console.WriteLine("接收数据：" + strData);
                    if (strData.IndexOf("OK") >= 0)
                    {
                        serialBle.ReceiveSerialBle(strData);
                    }
                }
            }));

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
            try
            {
                if (arrData.Length < 1 || !serialPortHelper.IsOpen)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            serialPortHelper.Write(arrData);

            if (chkShowWrite.Checked)
            {
                this.Invoke(new Action(() =>
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
                }));
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

        /// <summary>
        /// 添加发送数据
        /// </summary>
        /// <param name="arrData">数组数据</param>
        private void AddSerialWrite(string[] arrData)
        {
            foreach (string item in arrData)
            {
                AddSerialWrite(item);
            }
        }
        #endregion

        #region 蓝牙事件
        private void OutputBleLog(string strLog)
        {
            if (labBleStatus.Text != strLog)
            {
                Console.WriteLine("蓝牙日志" + strLog);
                labBleStatus.Text = (strLog);
                ClearListViewSerialReceviedValue(); //蓝牙状态改变，清空驱动界面
            }
        }
        #endregion

        #region 控件
        /// <summary>
        /// 窗体快捷键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("触发按钮：" + e.KeyCode.ToString());
            if (e.KeyCode == Keys.F1)
            {
                CallOnClick(btnBleConfig);
            }
            else if (e.KeyCode == Keys.F2)
            {
                serialBle.WriteBleCmd((enumBleCmd)Convert.ToInt32(toolBtnBleInit.Tag));
                ClearListViewSerialReceviedValue();
            }
            else if (e.KeyCode == Keys.F3)
            {
                serialBle.WriteBleCmd((enumBleCmd)Convert.ToInt32(toolBtnBleFind.Tag));
                ClearListViewSerialReceviedValue();
            }
            else if (e.KeyCode == Keys.F4)
            {
                serialBle.WriteBleCmd((enumBleCmd)Convert.ToInt32(toolBtnBleLink.Tag));
                ClearListViewSerialReceviedValue();
            }
        }
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
                    AddSerialWrite("AT");
                    SaveSerialConfig(configCom.GetConfigComData());
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
        /// 蓝牙高级配置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBleConfig_Click(object sender, EventArgs e)
        {
            if (_frmBleConfig != null)
            {
                _frmBleConfig.Close();
            }
            _frmBleConfig = new frmBleConfig(appConfig, bleConfig, serialBle);
            _frmBleConfig.Show();
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
            Console.WriteLine("选择蓝牙命令：" + e.ClickedItem.Text);
            serialBle.WriteBleCmd((enumBleCmd)Convert.ToInt32(e.ClickedItem.Tag));
            ClearListViewSerialReceviedValue();
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
        /// <summary>
        /// 接收数据处理
        /// </summary>
        /// <param name="arrData">Byte数据</param>
        private void BytesReceviedDataProcess(byte[] arrData)
        {
            int data = 0;
            string str = "";
            Dictionary<string, string> dicTestData = new Dictionary<string, string>();

            if (arrData.Length == 13)
            {
                //状态与模式处理
                data = arrData[4];
                dicTestData.Add("Status", "");
                dicTestData.Add("Mode", "");
                dicTestData.Add("Time", arrData[6].ToString());
                if (data == 0x00)
                {
                    EditListViewSerialReceviedValue(0, "关机");
                    EditListViewSerialReceviedValue(1, "关机");
                }
                else
                {
                    //状态处理
                    if ((data & 0x10) == 0x10)
                    {
                        EditListViewSerialReceviedValue(0, "自动测试");
                        dicTestData["Status"] = "自动测试";
                    }
                    else if ((data & 0x20) == 0x20)
                    {
                        EditListViewSerialReceviedValue(0, "手动测试");
                        dicTestData["Status"] = "手动测试";
                    }
                    else
                    {
                        EditListViewSerialReceviedValue(0, "非测试模式");
                    }

                    //模式处理
                    int modeData = data & 0x0F;
                    string[] arrModeData = { "自动", "加热测试", "电机测试", "制冷测试", "正脉冲测试", "负脉冲测试", "皮肤接触检测", "皮肤水份检测", "关机" };
                    if (modeData <= 0x07)
                    {
                        dicTestData["Mode"] = arrModeData[modeData];
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
                    dicTestData.Add("L", "False");
                    EditListViewSerialReceviedValue(2, "False");
                }
                else if (data == 0x01)
                {
                    dicTestData.Add("L", "True");
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
                dicTestData.Add("HotTemp", data.ToString());
                EditListViewSerialReceviedValue(4, data.ToString());

                //皮肤检测参数
                data = (arrData[8] << 8) | arrData[9];
                dicTestData.Add("RH", "0x" + data.ToString("X4"));
                EditListViewSerialReceviedValue(5, "0x" + data.ToString("X4"));

                //环温
                data = arrData[10];
                dicTestData.Add("RhTemp", data.ToString());
                EditListViewSerialReceviedValue(6, data.ToString());

                //电池状态
                data = arrData[11];
                dicTestData.Add("Battery", Convert.ToInt32(data).ToString());
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

                //发送应答位
                AddSerialWrite(new byte[] { 0x52, 0x02, 0x02, 0x03, 0x00, 0x5A });

                TestDataProcess(dicTestData);
            }
            else
            {
                Console.WriteLine("无法解析数据：" + SerialData.ToHexString(arrData));
                return;
            }

            

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

        #region 测试结果列表方法
        private bool bakIsL = false;
        private bool isTestDone = true;
        private void TestDataProcess(Dictionary<string, string> dic)
        {
            int RunTime = Convert.ToInt32(dic["Time"]);
            if (dic["Mode"] != "")
            {
                isTestDone = false;
                SetLabelTestStatus(enumLabelStatus.None);
            }
            switch (dic["Mode"])
            {
                case "加热测试":
                    int HotTemp = Convert.ToInt32(dic["HotTemp"]);
                    int RhTemp = Convert.ToInt32(dic["RhTemp"]);
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(0, enumLabelStatus.None);
                    }
                    else if (HotTemp - RhTemp > 4 || HotTemp > 37)
                    {
                        SetListTestStatus(0, enumLabelStatus.Pass);
                    }
                    else if (RunTime >= 10 && GetListTestStatus(0) == enumLabelStatus.None)
                    {
                        SetListTestStatus(0, enumLabelStatus.Fail);
                    }
                    break;
                case "电机测试":
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(1, enumLabelStatus.None);
                    }
                    else if (RunTime >= 2)
                    {
                        SetListTestStatus(1, enumLabelStatus.Pass);
                    }
                    break;
                case "制冷测试":
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(2, enumLabelStatus.None);
                    }
                    else if (RunTime >= 2)
                    {
                        SetListTestStatus(2, enumLabelStatus.Pass);
                    }
                    break;
                case "正脉冲测试":
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(3, enumLabelStatus.None);
                    }
                    else if (RunTime >= 2)
                    {
                        SetListTestStatus(3, enumLabelStatus.Pass);
                    }
                    break;
                case "负脉冲测试":
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(4, enumLabelStatus.None);
                    }
                    else if (RunTime >= 2)
                    {
                        SetListTestStatus(4, enumLabelStatus.Pass);
                    }
                    break;
                case "皮肤接触检测":
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(5, enumLabelStatus.None);
                        bakIsL = (dic["L"] == "True");
                    }
                    else if ((dic["L"] == "True") != bakIsL)
                    {
                        SetListTestStatus(5, enumLabelStatus.Pass);
                    }
                    else if (RunTime >= 3 && GetListTestStatus(5) == enumLabelStatus.None)
                    {
                        SetListTestStatus(5, enumLabelStatus.Fail);
                    }
                    break;
                case "皮肤水份检测":
                    if (RunTime <= 1)
                    {
                        SetListTestStatus(6, enumLabelStatus.None);
                        bakIsL = (dic["L"] == "True");
                    }
                    else if (int.Parse(dic["RH"], System.Globalization.NumberStyles.AllowHexSpecifier) > 0)
                    {
                        SetListTestStatus(6, enumLabelStatus.Pass);
                    }
                    else if (RunTime >= 10)
                    {
                        SetListTestStatus(6, enumLabelStatus.Fail);
                    }
                    break;
                default:
                    if (isTestDone == false)
                    {
                        isTestDone = true;
                        foreach (ListViewItem item in listViewBleTest.Items)
                        {
                            if (item.ImageIndex == Convert.ToInt32(enumLabelStatus.Fail))
                            {
                                SetLabelTestStatus(enumLabelStatus.Fail);
                                return;
                            }
                        }
                        foreach (ListViewItem item in listViewBleTest.Items)
                        {
                            if (item.ImageIndex == Convert.ToInt32(enumLabelStatus.None))
                            {
                                SetLabelTestStatus(enumLabelStatus.None);
                                return;
                            }
                        }
                        SetLabelTestStatus(enumLabelStatus.Pass);
                    }
                    break;
            }
        }

        /// <summary>
        /// 设置测试列表状态
        /// </summary>
        /// <param name="index">序号</param>
        /// <param name="status">状态</param>
        private void SetListTestStatus(int index, enumLabelStatus status)
        {
            listViewBleTest.Items[index].ImageIndex = Convert.ToInt32(status);
            switch (status)
            {
                case enumLabelStatus.None:
                    listViewBleTest.Items[index].Text = "待测";
                    break;
                case enumLabelStatus.Pass:
                    listViewBleTest.Items[index].Text = "通过";
                    break;
                case enumLabelStatus.Fail:
                    listViewBleTest.Items[index].Text = "失败";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取测试列表状态
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private enumLabelStatus GetListTestStatus(int index)
        {
            return (enumLabelStatus)listViewBleTest.Items[index].ImageIndex;
        }

        /// <summary>
        /// 设置测试状态样式
        /// </summary>
        /// <param name="status"></param>
        private void SetLabelTestStatus(enumLabelStatus status)
        {
            labTestStatus.TextAlign = ContentAlignment.MiddleCenter;
            labTestStatus.ForeColor = Color.White;
            labTestStatus.Font = new Font("微软雅黑", 21, FontStyle.Regular);
            switch (status)
            {
                case enumLabelStatus.None:
                    labTestStatus.BackColor = Color.White;
                    labTestStatus.Text = "";
                    break;
                case enumLabelStatus.Pass:
                    labTestStatus.BackColor = Color.Green;
                    labTestStatus.Text = "PASS";
                    break;
                case enumLabelStatus.Fail:
                    labTestStatus.BackColor = Color.Red;
                    labTestStatus.Text = "FAIL";
                    break;
                default:
                    break;
            }
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

        /// <summary>
        /// GroupBox开关
        /// </summary>
        /// <param name="groupBox">GroupBox名称</param>
        /// <param name="isEnable">开/关</param>
        private void GroupEnable(GroupBox groupBox, bool isEnable)
        {
            foreach (Control obj in groupBox.Controls)
            {
                obj.Enabled = isEnable;
            }
        }

        /// <summary>
        /// 调用按钮事件
        /// </summary>
        /// <param name="btn">按钮名称</param>
        private void CallOnClick(Button btn)
        {
            //建立一个类型  
            Type t = typeof(Button);
            //参数对象  
            object[] p = new object[1];
            //产生方法  
            MethodInfo m = t.GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
            //参数赋值。传入函数  
            p[0] = EventArgs.Empty;
            //调用  
            m.Invoke(btn, p);
            return;
        }
        #endregion

        #region 配置方法
        /// <summary>
        /// 保存串口配置
        /// </summary>
        /// <param name="c">串口配置</param>
        private void SaveSerialConfig(ConfigComType c)
        {
            Dictionary<string, string> dicConfig = new Dictionary<string, string>();
            dicConfig.Add("PortName", c.PortName);
            dicConfig.Add("BaudRate", c.BaudRate.ToString());
            dicConfig.Add("DataBits", c.DataBits.ToString());
            dicConfig.Add("StopBits", c.StopBits.ToString());
            dicConfig.Add("Parity", c.Parity.ToString());
            appConfig.SetConfig(dicConfig);
        }

        /// <summary>
        /// 保存串口日志配置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSerialLogConfing(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            appConfig.SetConfig(checkBox.Name, checkBox.Checked.ToString());
        }

        /// <summary>
        /// 获取串口配置
        /// </summary>
        /// <returns>串口配置</returns>
        private ConfigComType GetSerialConfig()
        {
            ConfigComType retConfig;
            try
            {
                retConfig.PortName = appConfig.GetConfig("PortName");
                retConfig.BaudRate = Convert.ToInt32(appConfig.GetConfig("BaudRate"));
                retConfig.DataBits = Convert.ToInt32(appConfig.GetConfig("DataBits"));
                retConfig.StopBits = (StopBits)Enum.Parse(typeof(StopBits), appConfig.GetConfig("StopBits"));
                retConfig.Parity = (Parity)Enum.Parse(typeof(Parity), appConfig.GetConfig("Parity"));
                return retConfig;
            }
            catch (Exception)
            {
                return configCom.GetConfigComData();
            }

        }

        /// <summary>
        /// 获取串口日志配置
        /// </summary>
        /// <param name="groupBox">串口日志的GroupBox</param>
        private void GetSerialLogConfig(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = item as CheckBox;
                    try
                    {
                        checkBox.Checked = Convert.ToBoolean(appConfig.GetConfig(checkBox.Name));
                    }
                    catch (Exception)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        #endregion

        #region 外部驱动
        /// <summary>
        /// 加载驱动库错误
        /// </summary>
        private Exception errorLoadDeviceLib;

        /// <summary>
        /// 加载驱动库按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadDeviceLib_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "驱动文件|*.dll|所有文件|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strPath = openFileDialog.FileName;
                if (LoadDeviceLib(strPath))
                {
                    ((Button)sender).Hide();
                    initBleConfig(strBleConfigName);
                }
                else
                {
                    MessageBox.Show(errorLoadDeviceLib.Message, "加载失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 加载驱动库方法
        /// </summary>
        /// <param name="strPath">驱动库路径</param>
        /// <returns>返回是否加载成功</returns>
        private bool LoadDeviceLib(string strPath)
        {
            try
            {
                Assembly assembly = Assembly.LoadFile(strPath);
                Type type = assembly.GetType("DeviceTestLib.DeviceTestClass");
                deviceTest = System.Activator.CreateInstance(type) as DeviceTestLib.IDeviceTest;

                //绑定控件并初始化
                deviceTest.ToolCmdWrite = this.toolCmdWrite;
                deviceTest.ListViewSerialReceived = this.listViewSerialReceived;
                deviceTest.ListViewBleTest = this.listViewBleTest;
                deviceTest.LabelBleTestStatus = this.labTestStatus;
                deviceTest.EventAddCmdWrite += new DelegateAddCmdWrite(AddSerialWrite);
                deviceTest.InitDeviceTest();

                //获取驱动名称
                string strName = System.IO.Path.GetFileName(strPath.Replace(".dll", ""));

                //修改窗体UI
                this.Text = STR_TITLE + " - " + strName;
                toolStripStatusLabelDriverName.Text = strName;
                toolStripStatusLabelDriverVersion.Text = "V" + assembly.GetName().Version.ToString();

                //初始化蓝牙配置
                strBleConfigName = strName;

                return true;
            }
            catch (Exception error)
            {
                errorLoadDeviceLib = error;
                return false;
            }
        }
        #endregion

        #region 状态栏
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelBleStatus.Text = labBleStatus.Text;
            toolStripStatusLabelTime.Text = DateTime.Now.ToString();
        }
        #endregion

        #region 蓝牙功能
        /// <summary>
        /// 蓝牙自动重连开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBleAutoReLink_CheckedChanged(object sender, EventArgs e)
        {
            numBleAutoReLink.Enabled = !chkBleAutoReLink.Checked;
            serialBle.IsAutoReLink = chkBleAutoReLink.Checked;
            serialBle.TimeAutoReLink = Convert.ToInt32(numBleAutoReLink.Value);
        }

        #endregion

        #region 蓝牙连接测试
        /// <summary>
        /// 测试开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBleLinkTest_CheckedChanged(object sender, EventArgs e)
        {
            numBleLinkInterval.Enabled = !chkBleLinkTest.Checked;
            numBleLinkCount.Enabled = !chkBleLinkTest.Checked;
            btnBleLinkLog.Enabled = !chkBleLinkTest.Checked;

            if (chkBleLinkTest.Checked)
            {
                //开启测试
                chkBleAutoReLink.Checked = true;
                bleLinkTest.StartTest(txtBlelinkLogPath.Text, Convert.ToInt32(numBleLinkInterval.Value),Convert.ToInt32(numBleLinkCount.Value));
            }
            else
            {
                //关闭测试
                chkBleAutoReLink.Checked = false;
                bleLinkTest.StopTest();
            }

            chkBleAutoReLink.Enabled = !chkBleLinkTest.Checked;
        }

        /// <summary>
        /// 选择输出日志目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBleLinkLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            //设置文件类型 
            sfd.Filter = "日志文件（*.log）|*.log|文本文件（*.txt）|*.txt";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
                Console.WriteLine("localFilePath = " + localFilePath + "\r\n fileNameExt = " + fileNameExt);
                
                if (File.Exists(localFilePath))
                {
                    try
                    {
                        File.Delete(localFilePath);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "文件被替换", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    StreamWriter sw = File.CreateText(localFilePath);
                    sw.WriteLine("创建日志文件【" + this.Text + "】 - " + DateTime.Now.ToLongDateString() + " " +  DateTime.Now.ToLongTimeString()); // 写入Hello World
                    sw.Close(); //关闭文件
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "文件被写入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtBlelinkLogPath.Text = localFilePath;
            }
        }

        #endregion

    }

    #region 枚举
    public enum enumLabelStatus
    {
        None,
        Pass,
        Fail
    }
    #endregion
}
