using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace USBTrayNotify
{
    public partial class CustomAdd : Form
    {
        public string CustomDevicesFile;

        public CustomAdd()
        {
            InitializeComponent();
        }

        //Mouse drag
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        private Form1 form1Form = null;
        public CustomAdd(Form callingForm)
        {
            form1Form = callingForm as Form1;
            InitializeComponent();
            ContextMenuStrip = contextMenuStrip1;
        }

        private void buttonCustomSave_Click(object sender, EventArgs e)
        {
            
            string usbCustomName = CustomAddBox1.Text;
            form1Form.listBox1.Items.Add(usbCustomName);
            form1Form.listBox1.Text = usbCustomName;

            string[] usbCustomNameText = { usbCustomName };
            CustomDevicesFile = "USBTrayNotifyCustomDevices.dat";
            File.AppendAllLines(CustomDevicesFile, usbCustomNameText);
            Hide();
        }

        private void closeBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
