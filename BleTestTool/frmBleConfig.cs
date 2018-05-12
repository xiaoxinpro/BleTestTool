using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public frmBleConfig(BleConfig bc)
        {
            InitializeComponent();
            bleConfig = bc;
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
        }

        private void frmBleConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = false;
        }
    }
}
