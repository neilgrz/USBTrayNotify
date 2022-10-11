using IWshRuntimeLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using File = System.IO.File;

namespace USBTrayNotify
{
    public partial class Options : Form
    {
        private bool StartWithWindows;
        private bool StartMenuShorts;
        private bool ShowOnNew;

        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load(object sender, EventArgs e)
        {
            contextMenuStripOptions.Renderer = contextMenuStripOptions.Renderer = new NewRenderer();
            CheckBoxStartOnWindows(); CheckBoxStartMenuShorts(); CheckBoxOnNew();
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
                contextMenuStripOptions.Show(PointToScreen(e.Location));
            }
        }

        //Close
        private void pictureBoxCloseOptions_Click(object sender, EventArgs e)
        {
            Hide();
        }


        //Mouse hover
        private void pictureBoxCloseOptions_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseOptions.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
            exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
        }

        private void pictureBoxCloseOptions_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloseOptions.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
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


        //Checkbox Start with Windows
        private void checkBoxStartWithWin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartWithWin.Checked)
            {
                StartWithWindows = true;
                Properties.USBTrayNotify.Default.StartWithWindows = true;
                Properties.USBTrayNotify.Default.Save();
                Console.WriteLine(StartWithWindows);
                StartupShortcut();
            }
            else
            {
                StartWithWindows = false;
                Properties.USBTrayNotify.Default.StartWithWindows = false;
                Properties.USBTrayNotify.Default.Save();
                string link = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
                File.Delete(link);
            }
        }
        private void CheckBoxStartOnWindows()
        {
            if (Properties.USBTrayNotify.Default.StartWithWindows == true)
            {
                StartWithWindows = true;
                checkBoxStartWithWin.Checked = true;
                StartupShortcut();
            }
        }
        private static void StartupShortcut()
        {
            string link = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
            var shell = new WshShell();
            var startshortcut = shell.CreateShortcut(link) as IWshShortcut;
            startshortcut.TargetPath = Application.ExecutablePath;
            startshortcut.WorkingDirectory = Application.StartupPath;
            startshortcut.Save();
        }

        //Checkbox Start Menu Shortcuts
        private void checkBoxStartMenuShorts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartMenuShorts.Checked)
            {
                StartMenuShorts = true;
                Properties.USBTrayNotify.Default.StartMenuShorts = true;
                Properties.USBTrayNotify.Default.Save();
                Console.WriteLine(StartMenuShorts);

                StartMenuShortsAdd();
            }
            else
            {
                StartMenuShorts = false;
                Properties.USBTrayNotify.Default.StartMenuShorts = false;
                Properties.USBTrayNotify.Default.Save();

                string link = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
                File.Delete(link);
            }
        }
        private void CheckBoxStartMenuShorts()
        {
            if (Properties.USBTrayNotify.Default.StartMenuShorts == true)
            {
                StartMenuShorts = true;
                checkBoxStartMenuShorts.Checked = true;

                StartMenuShortsAdd();
            }
        }
        private static void StartMenuShortsAdd()
        {
            string link = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
            var shell = new WshShell();
            var startshortcut = shell.CreateShortcut(link) as IWshShortcut;
            startshortcut.Description = "USB Tray Notify";
            startshortcut.TargetPath = Application.ExecutablePath;
            startshortcut.WorkingDirectory = Application.StartupPath;
            startshortcut.Save();
        }

        //Checkbox ShowOnNew
        private void checkBoxShowOnNew_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowOnNew.Checked)
            {
                ShowOnNew = true;
                Properties.USBTrayNotify.Default.ShowOnNew = true;
                Properties.USBTrayNotify.Default.Save();
            }
            else
            {
                ShowOnNew = false;
                Properties.USBTrayNotify.Default.ShowOnNew = false;
                Properties.USBTrayNotify.Default.Save();
            }
        }
        private void CheckBoxOnNew()
        {
            if (Properties.USBTrayNotify.Default.ShowOnNew == true)
            {
                ShowOnNew = true;
                checkBoxShowOnNew.Checked = true;
            }
        }
    }
}
