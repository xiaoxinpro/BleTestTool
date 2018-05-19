using DeviceTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceTestLib
{
    public class DeviceTestClass : IDeviceTest
    {
        #region 字段
        private frmHumidTest FrmHumidTest;
        private ToolStrip _toolCmdWrite;
        private ListView _listViewSerialReceived;
        private ListView _listViewBleTest;

        public event DelegateAddCmdWrite EventAddCmdWrite;

        #endregion

        #region 属性
        public ToolStrip ToolCmdWrite { get => _toolCmdWrite; set => _toolCmdWrite = value; }
        public ListView ListViewSerialReceived { get => _listViewSerialReceived; set => _listViewSerialReceived = value; }
        public ListView ListViewBleTest { get => _listViewBleTest; set => _listViewBleTest = value; }

        #endregion

        #region 接口函数

        public void InitDeviceTest()
        {
            FrmHumidTest = new frmHumidTest();
            InitToolCmdWrite();
            InitListViewSerialReceived(ListViewSerialReceived);
            initListViewBleTest(ListViewBleTest);
        }

        public void BytesReceviedDataProcess(byte[] arrData)
        {
            if (arrData.Length == 16 && arrData[0] == 0x52 && arrData[1] == 0x01 && CheckReceiveData(arrData))
            {
                //上报数据
                if (arrData[2] == 0x00 && arrData[3] == 0x05)
                {
                    //湿度
                    EditListViewSerialReceviedValue(0, Convert.ToInt32(arrData[4]).ToString());

                    //温度，Bit7为温度正负位，Bit6-Bit0表示温度值；
                    int temp = Convert.ToInt32(arrData[5]);
                    if ((temp & 0x80) == 0x80)
                    {
                        temp = -1 * temp;
                    }
                    EditListViewSerialReceviedValue(1, temp.ToString());

                    //加湿：0x00雾量控制(手动)，0x01湿度控制(自动)
                    bool isAuto = Convert.ToBoolean(arrData[6] == 0x01);
                    EditListViewSerialReceviedValue(2, isAuto ? "湿度控制" : "雾量控制");

                    //雾量/湿度调节：百分比，000-100
                    EditListViewSerialReceviedValue(3, Convert.ToInt32(arrData[7]).ToString());

                    //亮度：百分比，000-100
                    EditListViewSerialReceviedValue(4, Convert.ToInt32(arrData[8]).ToString(), Convert.ToInt32(arrData[8]) > 50);

                    //冷/暖光：0x00关闭，0x01开灯a（冷），0x02开灯b（暖），0x03开灯ab（冷暖）
                    string light;
                    switch (arrData[9])
                    {
                        case 0x01:
                            light = "白光";
                            break;
                        case 0x02:
                            light = "黄光";
                            break;
                        case 0x03:
                            light = "白黄光";
                            break;
                        default:
                            light = "关闭";
                            break;
                    }
                    EditListViewSerialReceviedValue(5, light);

                    //报警音开关：0x00 断水报警音关，0x01 断水报警音开
                    bool isBeep = Convert.ToBoolean(arrData[10] == 0x01);
                    EditListViewSerialReceviedValue(6, isBeep ? "开" : "关");

                    //报警状态：0x00 正常状态  0x01 断水报警  0x02 风机故障报警
                    bool isError = Convert.ToBoolean(arrData[11] == 0x01);
                    EditListViewSerialReceviedValue(7, isError ? "断水报警" : "正常状态");

                    //加湿定时：0/1/2/3/4 分别为 关闭/30min/60min/120min/180min
                    string[] strTime = { "关闭", "30min", "60min", "120min", "180min" };
                    EditListViewSerialReceviedValue(8, strTime[Convert.ToInt32(arrData[12])]);

                    //灯光定时：0/1/2/3/4分别为 关闭/30min/60min/120min/180min
                    EditListViewSerialReceviedValue(9, strTime[Convert.ToInt32(arrData[13])]);

                    //小夜灯： 0x00：小夜灯关    0x01:小夜灯开
                    bool isNightLight = Convert.ToBoolean(arrData[14] == 0x01);
                    EditListViewSerialReceviedValue(10, isNightLight ? "开" : "关");

                    //发送应答位
                    byte[] buffer = { 0x52, 0x01, 0x02, 0x05, 0x00, 0x5B };
                    EventAddCmdWrite(CheckWriteData(buffer));
                }
            }
        }

        #endregion

        #region 初始化函数
        /// <summary>
        /// 初始化发送命令工具栏
        /// </summary>
        private void InitToolCmdWrite()
        {
            ToolCmdWrite.Items.Clear();
            ToolCmdWrite.Dock = DockStyle.Bottom;
            ToolCmdWrite.GripStyle = ToolStripGripStyle.Hidden;
            List<ToolStripItem> listToolStripItem = new List<ToolStripItem>();
            foreach (ToolStripItem item in FrmHumidTest.toolCmdWrite.Items)
            {
                listToolStripItem.Add(item);

                if (item is ToolStripComboBox)
                {
                    ToolStripComboBox toolStripComboBox = item as ToolStripComboBox;
                    toolStripComboBox.SelectedIndex = 0;
                }
            }
            ToolCmdWrite.Items.AddRange(listToolStripItem.ToArray<ToolStripItem>());
            ToolCmdWrite.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(toolCmdWrite_ItemClicked);
        }

        /// <summary>
        /// 初始化测试结果列表
        /// </summary>
        /// <param name="listView"></param>
        private void initListViewBleTest(ListView listView)
        {
            //string[] arrListName = { "加热", "震动", "制冷", "正脉冲", "负脉冲", "皮肤接触" };

            ////基本属性设置
            //listView.Clear();
            //listView.FullRowSelect = true;
            //listView.GridLines = true;
            //listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            //listView.View = View.Details;
            //listView.SmallImageList = this.imageListStatus;

            ////创建列表头
            //listView.Columns.Add("状态", 60, HorizontalAlignment.Center);
            //listView.Columns.Add("名称", 400, HorizontalAlignment.Left);

            ////添加数据
            //listView.BeginUpdate();
            //for (int i = 0; i < arrListName.Length; i++)
            //{
            //    ListViewItem listViewItem = new ListViewItem();
            //    listViewItem.ImageIndex = 0;
            //    listViewItem.Text = " 待测";
            //    listViewItem.SubItems.Add(arrListName[i]);
            //    listViewItem.SubItems.Add("");
            //    listView.Items.Add(listViewItem);
            //}
            //listView.EndUpdate();
            //SetLabelTestStatus(enumLabelStatus.None);
        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        private void InitListViewSerialReceived(ListView listView)
        {
            string[] arrListName = { "温度", "湿度", "加湿方式", "雾量/湿度", "亮度", "色温", "报警音开关", "加湿定时", "灯光定时", "小夜灯" };
            string[] arrListMark = { "℃", "%", "雾量控制/湿度控制", "%", "%", "白光、黄光、白黄光", "报警音开关", "分钟", "分钟", "小夜灯开关" };
            //基本属性设置
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;

            //创建列表头
            listView.Columns.Add("序号", 40, HorizontalAlignment.Center);
            listView.Columns.Add("名称", 90, HorizontalAlignment.Center);
            listView.Columns.Add("值", 90, HorizontalAlignment.Center);
            listView.Columns.Add("备注", 190, HorizontalAlignment.Left);

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
        #endregion

        #region 事件函数
        /// <summary>
        /// 快捷发送命令工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolCmdWrite_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStrip toolStrip = (ToolStrip)sender;
            if (e.ClickedItem is ToolStripButton)
            {
                Console.WriteLine("选择工具命令：" + e.ClickedItem.Name + " - " + e.ClickedItem.Text);
                byte[] buffer = { 0x52, 0x01, 0x01, 0x01, 0x00, 0x56 };
                int valLight = (FrmHumidTest.toolStripComboLight.SelectedIndex + 1) * 10;
                int valHumid = (FrmHumidTest.toolStripComboHumid.SelectedIndex + 1) * 10;
                switch (e.ClickedItem.Name)
                {
                    case "toolStripBtnChangeLight":
                        //发送亮度命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x02;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = Convert.ToByte(valLight);
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnOpenWhiteLight":
                        //发送色温命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x01;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = 0x01;
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnOpenYellowLight":
                        //发送色温命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x01;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = 0x02;
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnOpenAllLight":
                        //发送色温命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x01;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = 0x03;
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnCloseLight":
                        //发送色温命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x01;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = 0x00;
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnOpenHumid":
                        //发送雾量命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x05;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = Convert.ToByte(valHumid);
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnCloseHumid":
                        //发送关闭雾量命令
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x05;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = 0x00;
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    case "toolStripBtnOpenErrorBeep":
                        //发送开启报警音
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Cmd)] = 0x07;
                        buffer[Convert.ToInt32(enumSerialWriteFormat.Data)] = 0x01;
                        EventAddCmdWrite(CheckWriteData(buffer));
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region 串口列表函数
        /// <summary>
        /// 编辑串口接收数据值
        /// </summary>
        /// <param name="line">行号</param>
        /// <param name="value">值</param>
        private void EditListViewSerialReceviedValue(int line, string value, bool flag = false)
        {
            if (line >= 0 && line < ListViewSerialReceived.Items.Count)
            {
                if (ListViewSerialReceived.Items[line].SubItems[2].Text != value)
                {
                    ListViewSerialReceived.Items[line].SubItems[2].Text = value;
                    ListViewSerialReceived.Items[line].BackColor = flag ? System.Drawing.Color.Red : System.Drawing.Color.White;
                }
            }
        }

        /// <summary>
        /// 清空串口解析列表
        /// </summary>
        private void ClearListViewSerialReceviedValue()
        {
            ListViewSerialReceived.BeginUpdate();
            for (int i = 0; i < ListViewSerialReceived.Items.Count; i++)
            {
                ListViewSerialReceived.Items[i].SubItems[2].Text = "";
            }
            ListViewSerialReceived.EndUpdate();
        }
        #endregion

        #region 公共函数

        #endregion

        #region 私有函数
        /// <summary>
        /// 计算数据校验和
        /// </summary>
        /// <param name="arrData">Byte数据数组</param>
        /// <returns>检验和</returns>
        private byte CheckDataSum(byte[] arrData)
        {
            int sum = 1;
            for (int i = 0; i < arrData.Length - 1; i++)
            {
                sum += arrData[i];
            }
            return Convert.ToByte(sum % 0xFF);
        }

        /// <summary>
        /// 获取发送数据校验
        /// </summary>
        /// <param name="arrData">发送有效数据</param>
        /// <returns></returns>
        private byte[] CheckWriteData(byte[] arrData)
        {
            arrData[arrData.Length - 1] = CheckDataSum(arrData);
            return arrData;
        }

        /// <summary>
        /// 检验接收数据校验位
        /// </summary>
        /// <param name="arrData">接收数据</param>
        /// <returns>校验结果</returns>
        private bool CheckReceiveData(byte[] arrData)
        {
            return CheckDataSum(arrData) == arrData[arrData.Length - 1];
        }
        #endregion

    }

    #region 枚举
    public enum enumSerialWriteFormat
    {
        Start = 0,  //起始字节
        Flag = 1,   //标记字节
        Type = 2,   //类型字节
        Cmd = 3,    //命令字节
        Data = 4,   //数据字节
        Check = 5   //校验字节
    }
    #endregion
}