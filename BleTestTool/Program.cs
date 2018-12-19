using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BleTestTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string strError;
            if (CheckInit(out strError))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain(args));
            }
            else
            {
                if (MessageBox.Show(strError, "无法启动程序", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://github.com/xiaoxinpro/BleTestTool/releases");
                }
                Application.Exit();
            }
        }

        static bool CheckInit(out string message)
        {
            message = "";

            //获取运行目录
            string strPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            //判断SerialPortHelperLib.dll是否有效
            string strPathSerialPortHelperLib = strPath + @"SerialPortHelperLib.dll";
            if (!File.Exists(strPathSerialPortHelperLib))
            {
                message = "缺少SerialPortHelperLib.dll文件，请安装最新版本。";
                return false;
            }

            //判断SerialPortHelperLib.dll版本号
            Version verSerialPortHelperLib = new Version(FileVersionInfo.GetVersionInfo(strPathSerialPortHelperLib).FileVersion);
            if (verSerialPortHelperLib < new Version("18.12.14.0"))
            {
                message = "类库文件SerialPortHelperLib.dll版本过低，请安装最新版本。";
                return false;
            }

            //判断DeviceTestLib.dll是否有效
            string strPathDeviceTestLib = strPath + @"DeviceTestLib.dll";
            if (!File.Exists(strPathDeviceTestLib))
            {
                message = "缺少DeviceTestLib.dll文件，请安装最新版本。";
                return false;
            }

            //判断DeviceTestLib.dll版本号
            Version verDeviceTestLib = new Version(FileVersionInfo.GetVersionInfo(strPathDeviceTestLib).FileVersion);
            if (verDeviceTestLib < new Version("1.1.0.0"))
            {
                message = "类库文件DeviceTestLib.dll版本过低，请安装最新版本。";
                return false;
            }

            return true;
        }
    }
}
