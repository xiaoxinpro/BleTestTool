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
        private frmBeautyTest FrmBeautyTest;
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
            FrmBeautyTest = new frmBeautyTest();
            InitToolCmdWrite();
            InitListViewSerialReceived(ListViewSerialReceived);
            initListViewBleTest(ListViewBleTest);
        }

        public void BytesReceviedDataProcess(byte[] arrData)
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
                EventAddCmdWrite(new byte[] { 0x52, 0x02, 0x02, 0x03, 0x00, 0x5A });

                //TestDataProcess(dicTestData);
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
            foreach (ToolStripItem item in FrmBeautyTest.toolCmdWrite.Items)
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
            string[] arrListName = { "加热", "震动", "制冷", "正脉冲", "负脉冲", "皮肤接触" };

            //基本属性设置
            listView.Clear();
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;
            //listView.SmallImageList = this.imageListStatus;

            //创建列表头
            listView.Columns.Add("状态", 60, HorizontalAlignment.Center);
            listView.Columns.Add("名称", 400, HorizontalAlignment.Left);

            //添加数据
            listView.BeginUpdate();
            for (int i = 0; i < arrListName.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                //listViewItem.ImageIndex = 0;
                listViewItem.Text = " 待测";
                listViewItem.SubItems.Add(arrListName[i]);
                listViewItem.SubItems.Add("");
                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();
            //SetLabelTestStatus(enumLabelStatus.None);
        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        private void InitListViewSerialReceived(ListView listView)
        {
            string[] arrListName = { "状态", "模式", "皮肤接触", "时长", "加热温度", "皮肤检测参数", "环境温度", "电池状态" };
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
        #endregion

        #region 事件函数
        /// <summary>
        /// 快捷发送命令工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolCmdWrite_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine("选择快捷命令：" + e.ClickedItem.Name + " - " + e.ClickedItem.Text);
            if (e.ClickedItem.Name == "toolBtnRh")
            {
                byte[] buffer = { 0x52, 0x02, 0x01, 0x02, 0x01, 0x59 };
                EventAddCmdWrite(buffer);
            }
            else
            {
                byte[] buffer = { 0x52, 0x02, 0x01, 0x10, 0x00, 0x00 };
                buffer[4] = Convert.ToByte(Convert.ToInt32(e.ClickedItem.Tag));
                buffer[buffer.Length - 1] = CheckDataSum(buffer);
                EventAddCmdWrite(buffer);
                if (e.ClickedItem.Name == "toolBtnAuto")
                {
                    initListViewBleTest(FrmBeautyTest.listViewBleTest);
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