using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BleTestTool
{
    public partial class frmBleConfig : Form
    {
        /// <summary>
        /// 定义BleConfig类
        /// </summary>
        private BleConfig bleConfig;

        /// <summary>
        /// 定义SerialBle类
        /// </summary>
        private SerialBle serialBle;

        /// <summary>
        /// 定义AppConfig类
        /// </summary>
        private AppConfig appConfig;

        #region 加载页面

        public frmBleConfig(AppConfig ac, BleConfig bc, SerialBle sb)
        {
            InitializeComponent();
            appConfig = ac;
            bleConfig = bc;
            serialBle = sb;
        }

        private void frmBleConfig_Load(object sender, EventArgs e)
        {
            Console.WriteLine("\r\nDicBleBlackListConfig");
            foreach (KeyValuePair<string,string> item in bleConfig.DicBleBlackListConfig)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("\r\nDicBleNameReplaceConfig");
            foreach (KeyValuePair<string, string> item in bleConfig.DicBleNameReplaceConfig)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            //初始化列表
            InitBleNameReplaceList(listViewBleNameReplace);
            InitBleBlackList(listViewBleBlackList);

            //初始配置
            this.checkBleNameFilter.Checked = Convert.ToBoolean(appConfig.GetConfig("BleNameFilter"));
        }

        private void frmBleConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = false;
        }

        private void InitBleNameReplaceList(ListView listView)
        {
            //基本属性设置
            listView.CheckBoxes = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;

            //绑定菜单
            listView.ContextMenuStrip = contextMenuListView;

            //创建列表头
            listView.Columns.Add("蓝牙名称", 165, HorizontalAlignment.Left);
            listView.Columns.Add("替换内容", 170, HorizontalAlignment.Left);

            //添加数据
            listView.BeginUpdate();
            foreach (KeyValuePair<string,string> item in bleConfig.DicBleNameReplaceConfig)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Key;
                listViewItem.SubItems.Add(item.Value);
                try
                {
                    listViewItem.Checked = Convert.ToBoolean(bleConfig.DicBleNameFilterConfig[item.Key]);
                }
                catch (Exception)
                {
                    listViewItem.Checked = false;
                }
                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();
        }

        private void InitBleBlackList(ListView listView)
        {
            //基本属性设置
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;

            //绑定菜单
            listView.ContextMenuStrip = contextMenuListView;

            //创建列表头
            listView.Columns.Add("蓝牙地址", 130, HorizontalAlignment.Left);
            listView.Columns.Add("蓝牙备注", 205, HorizontalAlignment.Left);

            //添加数据
            listView.BeginUpdate();
            foreach (KeyValuePair<string, string> item in bleConfig.DicBleBlackListConfig)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Key;
                listViewItem.SubItems.Add(item.Value);
                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();

            //添加下拉列表数据
            comboBleBlackList.Items.Clear();
            comboBleBlackList.Items.AddRange(serialBle.DicListBle.Keys.ToArray<string>());
        }

        #endregion

        #region 表格操作
        /// <summary>
        /// 添加List数据
        /// </summary>
        /// <param name="listView">表格</param>
        /// <param name="key">数据</param>
        /// <param name="value">数据</param>
        private void AddListData(ListView listView, string key, string value)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = key;
            listViewItem.SubItems.Add(value);
            listView.Items.Add(listViewItem);
        }

        /// <summary>
        /// 编辑List数据
        /// </summary>
        /// <param name="listView">表格</param>
        /// <param name="key">数据(唯一标识)</param>
        /// <param name="value">数据</param>
        private void EditListData(ListView listView, string key, string value)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Text == key)
                {
                    item.SubItems[1].Text = value;
                    return;
                }
            }
        }

        /// <summary>
        /// 编辑列表Checked
        /// </summary>
        /// <param name="listView">表格</param>
        /// <param name="key">数据（唯一标识）</param>
        /// <param name="isChecked">是否选中</param>
        private void CheckedListData(ListView listView,string key, bool isChecked)
        {
            if (listView.CheckBoxes)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.Text == key)
                    {
                        item.Checked = isChecked;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 删除List数据
        /// </summary>
        /// <param name="listView">表格</param>
        /// <param name="index">标号</param>
        private void DeleteListData(ListView listView, int index)
        {
            if (listView.Items.Count > index)
            {
                listView.Items[index].Remove();
            }
        }

        /// <summary>
        /// 删除指定范围的List数据
        /// </summary>
        /// <param name="listView">表格</param>
        /// <param name="startIndex">起始标号</param>
        /// <param name="endIndex">结束标号</param>
        private void DeleteListData(ListView listView, int startIndex, int endIndex)
        {
            if (listView.Items.Count > startIndex && listView.Items.Count > endIndex)
            {
                if (startIndex < endIndex)
                {
                    for (int index = endIndex; index >= startIndex; index--)
                    {
                        listView.Items[index].Remove();
                    }
                }
                else if (startIndex > endIndex) 
                {
                    for (int index = listView.Items.Count-1; index >= startIndex; index--)
                    {
                        listView.Items[index].Remove();
                    }
                    for (int index = endIndex; index >= 0; index++)
                    {
                        listView.Items[index].Remove();
                    }
                }
                else
                {
                    listView.Items[startIndex].Remove();
                }
            }
        }

        /// <summary>
        /// 清空List数据
        /// </summary>
        /// <param name="listView">表格</param>
        private void ClearListData(ListView listView)
        {
            if (listView != null)
            {
                listView.Items.Clear();
            }
        }
        #endregion

        #region 列表右键菜单
        /// <summary>
        /// 列表右键菜单列表备份
        /// </summary>
        private ListView listViewMenu;

        /// <summary>
        /// 右键菜单显示前处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuListView_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ContextMenuStrip menuStrip = (ContextMenuStrip)sender;
            ListView listView = (ListView)menuStrip.SourceControl;
            listViewMenu = listView;
            if (listView.SelectedItems.Count != 1)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 输出ListView数据
        /// </summary>
        /// <param name="listView">表格</param>
        /// <param name="startIndex">起始行</param>
        /// <param name="endIndex">结束行</param>
        /// <returns>返回输出字符串</returns>
        private string OutputListViewData(ListView listView, int startIndex = 0, int endIndex = 10)
        {
            StringBuilder strData = new StringBuilder();
            int length = 0;
            if (listView.Items.Count > startIndex && listView.Items.Count > endIndex)
            {
                if (startIndex < endIndex)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (length++ > 10)
                        {
                            strData.AppendLine("\t......");
                            break;
                        }
                        strData.AppendLine("    " + listView.Items[i].SubItems[0].Text + "：" + listView.Items[i].SubItems[1].Text);
                    }
                }
                else if (startIndex > endIndex)
                {
                    for (int i = startIndex; i < listView.Items.Count; i++)
                    {
                        if (length++ > 10)
                        {
                            strData.AppendLine("\t......");
                            break;
                        }
                        strData.AppendLine("    " + listView.Items[i].SubItems[0].Text + "：" + listView.Items[i].SubItems[1].Text);
                    }
                    for (int i = 0; i <= endIndex; i++)
                    {
                        if (length++ > 10)
                        {
                            strData.AppendLine("\t......");
                            break;
                        }
                        strData.AppendLine("    " + listView.Items[i].SubItems[0].Text + "：" + listView.Items[i].SubItems[1].Text);
                    }
                }
                else
                {
                    strData.AppendLine("    " + listView.Items[startIndex].SubItems[0].Text + "：" + listView.Items[startIndex].SubItems[1].Text);
                }

            }
            return strData.ToString();
        }

        /// <summary>
        /// 删除选中ListView项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            if (listViewMenu != null && listViewMenu.SelectedItems.Count == 1)
            {
                DeleteListData(listViewMenu, listViewMenu.SelectedItems[0].Index);
            }
        }

        /// <summary>
        /// 删除所有ListView项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuDeleteAll_Click(object sender, EventArgs e)
        {
            if (listViewMenu != null)
            {
                string strMessage = "请确认是否要删除下列所有内容？\r\n" + OutputListViewData(listViewMenu, 0, listViewMenu.Items.Count - 1) + "请谨慎选择，删除后不可恢复！！！";
                if (MessageBox.Show(strMessage, "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClearListData(listViewMenu);
                }
            }
        }

        /// <summary>
        /// 删除以上所有内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuDeleteUpAll_Click(object sender, EventArgs e)
        {
            if (listViewMenu != null && listViewMenu.SelectedItems.Count == 1)
            {
                int index = listViewMenu.SelectedItems[0].Index;
                string strMessage = "请确认是否要删除下列所有内容？\r\n" + OutputListViewData(listViewMenu, 0, index) + "请谨慎选择，删除后不可恢复！！！";
                if (MessageBox.Show(strMessage, "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteListData(listViewMenu, 0, index);
                }
            }
        }

        /// <summary>
        /// 删除以下所有内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuDeleteDownAll_Click(object sender, EventArgs e)
        {
            int startIndex = listViewMenu.SelectedItems[0].Index;
            int endIndex = listViewMenu.Items.Count - 1;
            string strMessage = "请确认是否要删除下列所有内容？\r\n" + OutputListViewData(listViewMenu, startIndex, endIndex) + "请谨慎选择，删除后不可恢复！！！";
            if (MessageBox.Show(strMessage, "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DeleteListData(listViewMenu, startIndex, endIndex);
            }
        }
        #endregion

        #region 蓝牙名称替换控件
        private void btnBleNameReplace_Click(object sender, EventArgs e)
        {
            string key = txtBleName.Text.Trim();
            string value = txtBleReplace.Text.Trim();
            if (key != "" && value != "")
            {
                if (!bleConfig.DicBleNameReplaceConfig.ContainsKey(key))
                {
                    //添加数据
                    AddListData(listViewBleNameReplace, key, value);
                    bleConfig.DicBleNameReplaceConfig.Add(key, value);
                    bleConfig.SaveBleNameReplaceConfig();
                }
                else
                {
                    //编辑数据
                    EditListData(listViewBleNameReplace, key, value);
                    bleConfig.DicBleNameReplaceConfig[key] = value;
                    bleConfig.SaveBleNameReplaceConfig();
                }
            }
            else
            {
                MessageBox.Show("内容不可为空！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewBleNameReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                txtBleName.Text = ((ListView)sender).SelectedItems[0].Text;
                txtBleReplace.Text = ((ListView)sender).SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                txtBleName.Text = "";
                txtBleReplace.Text = "";
            }
        }

        private void listViewBleNameReplace_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                bleConfig.DicBleNameReplaceConfig.Remove(listView.SelectedItems[0].Text);
                bleConfig.SaveBleNameReplaceConfig();
                DeleteListData(listView, listView.SelectedItems[0].Index);
            }
        }

        private void listViewBleNameReplace_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string key = e.Item.Text;
            bool isChecked = e.Item.Checked;
            try
            {
                bleConfig.DicBleNameFilterConfig[key] = isChecked.ToString();
            }
            catch (Exception)
            {
                bleConfig.DicBleNameFilterConfig.Add(key, isChecked.ToString());
            }
            bleConfig.SaveBleNameFilterConfig();
        }

        private void checkBleNameFilter_CheckedChanged(object sender, EventArgs e)
        {
            appConfig.SetConfig("BleNameFilter", checkBleNameFilter.Checked.ToString());
        }
        #endregion

        #region 蓝牙黑名单控件

        /// <summary>
        /// 添加蓝牙黑名单
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void addBleBlackList(string key, string value)
        {
            if (key != "" && value != "")
            {
                if (!bleConfig.DicBleBlackListConfig.ContainsKey(key))
                {
                    //添加数据
                    AddListData(listViewBleBlackList, key, value);
                    bleConfig.DicBleBlackListConfig.Add(key, value);
                    bleConfig.SaveBleBlackListConfig();
                }
                else
                {
                    //编辑数据
                    EditListData(listViewBleBlackList, key, value);
                    bleConfig.DicBleBlackListConfig[key] = value;
                    bleConfig.SaveBleBlackListConfig();
                }
            }
            else
            {
                MessageBox.Show("内容不可为空！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 下拉列表选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBleBlackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex >= 0)
            {
                try
                {
                    txtBleBlackList.Text = serialBle.DicListBle[comboBox.SelectedItem.ToString()];
                }
                catch (Exception)
                {
                    txtBleBlackList.Clear();
                }
                
            }
        }

        /// <summary>
        /// 添加全部按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBleBlackListAll_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string,string> item in serialBle.DicListBle)
            {
                addBleBlackList(item.Value, item.Key);
            }
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBleBlackList_Click(object sender, EventArgs e)
        {
            string key = txtBleBlackList.Text.Trim();
            string value = comboBleBlackList.Text.Trim();
            addBleBlackList(key, value);
        }

        private void listViewBleBlackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                txtBleBlackList.Text = ((ListView)sender).SelectedItems[0].Text;
                comboBleBlackList.Text = ((ListView)sender).SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                txtBleBlackList.Text = "";
                comboBleBlackList.Text = "";
            }
        }

        private void listViewBleBlackList_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                bleConfig.DicBleBlackListConfig.Remove(listView.SelectedItems[0].Text);
                bleConfig.SaveBleBlackListConfig();
                DeleteListData(listView, listView.SelectedItems[0].Index);
            }
        }



        #endregion

        
    }
}
