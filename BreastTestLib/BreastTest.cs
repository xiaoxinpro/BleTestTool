using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceTestLib
{
    public class DeviceTestClass : IDeviceTest
    {
        public ToolStrip ToolCmdWrite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ListView ListViewSerialReceived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ListView ListViewBleTest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Label LabelBleTestStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event DelegateAddCmdWrite EventAddCmdWrite;

        public void BytesReceviedDataProcess(byte[] arrData)
        {
            throw new NotImplementedException();
        }

        public void InitDeviceTest()
        {
            throw new NotImplementedException();
        }
    }
}
