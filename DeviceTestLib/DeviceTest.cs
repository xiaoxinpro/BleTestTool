using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceTestLib
{
    public interface IDeviceTest
    {
        #region 接口属性
        /// <summary>
        /// 发送命令工具栏
        /// </summary>
        ToolStrip ToolCmdWrite
        {
            get;
            set;
        }

        /// <summary>
        /// 串口接收数据分析列表
        /// </summary>
        ListView ListViewSerialReceived
        {
            get;
            set;
        }

        /// <summary>
        /// 蓝牙测试分析列表
        /// </summary>
        ListView ListViewBleTest
        {
            get;
            set;
        }
        #endregion

        #region 接口方法
        /// <summary>
        /// 设备测试初始化
        /// </summary>
        void InitDeviceTest();

        /// <summary>
        /// 串口接收数据处理函数
        /// </summary>
        /// <param name="arrData">接收数据</param>
        void BytesReceviedDataProcess(byte[] arrData);
        #endregion

        #region 接口事件
        /// <summary>
        /// 发送命令数据事件
        /// </summary>
        event DelegateAddCmdWrite EventAddCmdWrite;
        #endregion

    }

    /// <summary>
    /// 定义发送数据委托
    /// </summary>
    /// <param name="arrData"></param>
    public delegate void DelegateAddCmdWrite(byte[] arrData);

}
