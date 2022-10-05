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

        private void About_Load(object sender, EventArgs e)
        {
            ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Show();
        }

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
    }
}
