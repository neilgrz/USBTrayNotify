using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace USBTrayNotify
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            contextMenuStripAbout.Renderer = contextMenuStripAbout.Renderer = new NewRenderer();
        }

        //Context menu colors
        private class NewRenderer : ToolStripProfessionalRenderer
        {
            public NewRenderer() : base(new NewColors()) { }
        }
        private class NewColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Gainsboro; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Gray; }
            }
        }

        //Border
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
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
        private void MouseDownDrag(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }
        private void MouseDownDragButton(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
                contextMenuStripAbout.Show(PointToScreen(e.Location));
            }
        }

        //Close
        private void pictureBoxCloseAbout_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/neilgrz/USBTrayNotify");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Mouse hover
        private void pictureBoxCloseAbout_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseAbout.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
            exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
        }

        private void pictureBoxCloseAbout_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloseAbout.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
        }

        //Minimize on taskbar icon click when active
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
