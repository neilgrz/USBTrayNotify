using IWshRuntimeLibrary;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using File = System.IO.File;

namespace USBTrayNotify
{
    public partial class Form1 : Form
    {
        public string USBLogViewLog;
        public string DeviceSelectFile;
        //public string CustomDevicesFile;
        public string USBFriendlyName;
        private string USBPlug;
        private string ToggleTray;
        private bool NewDevice;
        private bool ShowOnNew;
        private bool StartWithWindows;
        private bool StartMenuShorts;


        //Border
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DarkGray, 1, ButtonBorderStyle.Solid, Color.DarkGray, 1, ButtonBorderStyle.Solid, Color.DarkGray, 1, ButtonBorderStyle.Solid, Color.DarkGray, 1, ButtonBorderStyle.Solid);
        }

        public Form1()
        {
            InitializeComponent();
        }


        //Form Load
        private void Form1Load(object sender, EventArgs e)
        {
            USBLogViewLog = "USBLogView.log";
            DeviceSelectFile = "USBTrayNotifySelect.dat";
            //CustomDevicesFile = "USBTrayNotifyCustomDevices.dat";
            USBFriendlyName = Properties.USBTrayNotify.Default.USBFriendlyName;
            ShowOnNew = Properties.USBTrayNotify.Default.ShowOnNew;

            ListboxLoad(); CheckBoxOnNew(); CheckBoxStartOnWindows(); CheckBoxStartMenuShorts(); SetStatus();

            if (USBFriendlyName == "No Device")
            {
                ToggleForm();
            }
            FormLocation();
        }


        //Form hiding, showing, exiting, moving, location
        private void Form1HideOnStart(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Show();
            }
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }
        public void ToggleForm()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void notifyIconConnected_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    Hide();
                    WindowState = FormWindowState.Minimized;
                    return;
                }
                if (WindowState == FormWindowState.Minimized)
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                    return;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
        }
        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
                return;
            }
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
                return;
            }
        }
        
        //Exit and kill USBLogView and refresh system tray
        private void Exit()
        {
            foreach (var process in Process.GetProcessesByName("USBLogView"))
            {
                process.Kill();
                RefreshTray.RefreshTraybar();
            }
            Application.Exit();
        }
        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }
        void MenuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        //Save window location
        private void FormLocation()
        {
            if (Properties.USBTrayNotify.Default.FirstRun == true && Properties.USBTrayNotify.Default.Form1Location.X == 0 && Properties.USBTrayNotify.Default.Form1Location.Y == 0)
            {
                Properties.USBTrayNotify.Default.FirstRun = false;
                Properties.USBTrayNotify.Default.Save();
                StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                Location = Properties.USBTrayNotify.Default.Form1Location;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.USBTrayNotify.Default.Form1Location = Location;
            Properties.USBTrayNotify.Default.Save();

            Exit();
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

        // ListboxLoad
        public void ListboxLoad()
        {
            listBox1.Items.AddRange(new object[] { "No Device" });
            if (File.Exists(DeviceSelectFile))
            {
                string[] readDevices = File.ReadAllLines(DeviceSelectFile);
                if (!listBox1.Items.Contains(readDevices))
                {
                    listBox1.Items.AddRange(readDevices);
                }
            }
            //if (File.Exists(CustomDevicesFile))
            //{
            //    string[] readCustomDevices = File.ReadAllLines(CustomDevicesFile);
            //    foreach (var lines in readCustomDevices)
            //    {
            //        string CustomDevices = lines;
            //        listBox1.Items.Add(CustomDevices);
            //    }
            //}
            listBox1.Text = USBFriendlyName;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SaveDevice();
        }

        private void buttonSaveDevice_Click(object sender, EventArgs e)
        {
            SaveDevice();
        }


        //Watch log for connect and disconnect
        public void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            if (backgroundWorkerUSBLog.IsBusy != true)
            {
                backgroundWorkerUSBLog.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Thread.Sleep(1000);

            if (!File.Exists(USBLogViewLog))
            {
                File.Create(USBLogViewLog).Dispose();
            }
            if (!File.Exists(DeviceSelectFile))
            {
                File.Create(DeviceSelectFile).Dispose();
            }

            string USBFriendlyName = Properties.USBTrayNotify.Default.USBFriendlyName;
            string USBLogViewAll = File.ReadAllText(USBLogViewLog);
            //string CustomDevicesAll = File.ReadAllText(CustomDevicesFile);

            string[] USBLogViewLines = File.ReadAllLines(USBLogViewLog);
            foreach (var lines in USBLogViewLines)
            {
                string[] USBLogViewDeviceStrip = lines.Split(',');
                string vendorNoQuotes = USBLogViewDeviceStrip[9];
                string[] charsToRemove = new string[] { "\"" };
                foreach (var c in charsToRemove)
                {
                    vendorNoQuotes = vendorNoQuotes.Replace(c, string.Empty);
                }
                string USBLogViewDevicePlugOrUnPlug = USBLogViewDeviceStrip[0];
                string USBLogViewDevice = USBLogViewDeviceStrip[3] + " " + USBLogViewDeviceStrip[4] + " " + vendorNoQuotes;
                string DeviceSelectFileDevices = File.ReadAllText(DeviceSelectFile);

                File.Delete(USBLogViewLog);

                if (DeviceSelectFileDevices.Contains(USBFriendlyName) && USBLogViewDevicePlugOrUnPlug.Contains("Plug") && USBLogViewDevice == USBFriendlyName)
                {
                    USBPlug = "connected";
                    ToggleTray = "connected";
                    NewDevice = false;
                    return;
                }
                else
                if (DeviceSelectFileDevices.Contains(USBFriendlyName) && USBLogViewDevicePlugOrUnPlug == "Unplug" && USBLogViewDevice == USBFriendlyName)
                {
                    USBPlug = "disconnected";
                    ToggleTray = "disconnected";
                    NewDevice = false;
                    return;
                }
                else
                if (!USBLogViewDevice.Contains(USBFriendlyName) && USBLogViewDevicePlugOrUnPlug == "Plug")
                {
                    if (USBPlug == "connected" && USBFriendlyName != "No Device")
                    {
                        ToggleTray = "connected";
                        NewDevice = false;
                    }
                    if (USBPlug == "disconnected")
                    {
                        ToggleTray = "disconnected";
                        NewDevice = false;
                    }

                    if (!DeviceSelectFileDevices.Contains(USBLogViewDevice))
                    {
                        NewDevice = true;
                        //ToggleTray = "unknown";

                        if (!DeviceSelectFileDevices.Contains(USBLogViewDevice))
                        {
                            File.AppendAllText(DeviceSelectFile, USBLogViewDevice + Environment.NewLine);
                        }
                    }
                }
                else
                if (!USBLogViewDevice.Contains(USBFriendlyName) && USBLogViewDevicePlugOrUnPlug == "Unplug")
                {
                    if (USBPlug == "connected" && USBFriendlyName != "No Device")
                    {
                        ToggleTray = "connected";
                    }
                    if (USBPlug == "disconnected")
                    {
                        ToggleTray = "disconnected";
                    }
                    if (USBPlug == "unknown")
                    {
                        ToggleTray = "unknown";
                    }
                }
                //else
                //if (USBLogViewAll.Contains(CustomDevicesAll) && USBLogViewDevicePlugOrUnPlug == "Plug")
                //{
                //    foreach (string line in File.ReadLines(CustomDevicesFile))
                //    {
                //        if (USBFriendlyName == line)
                //        {
                //            USBPlug = "connected";
                //            ToggleTray = "connected";
                //        }
                //    }
                //    return;
                //}
                //else
                //if (USBLogViewAll.Contains(CustomDevicesAll) && USBLogViewDevicePlugOrUnPlug == "Unplug")
                //{
                //    foreach (string line in File.ReadLines(CustomDevicesFile))
                //    {
                //        if (USBFriendlyName == line)
                //        {
                //            USBPlug = "disconnected";
                //            ToggleTray = "disconnected";
                //        }
                //    }
                //    return;
                //}
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Add devices to listbox
            if (File.Exists(DeviceSelectFile))
            {
                foreach (string line in File.ReadLines(DeviceSelectFile))
                {
                    if (!listBox1.Items.Contains(line))
                    {
                        listBox1.Items.Add(line);
                    }
                }

                //if (File.Exists(CustomDevicesFile))
                //{
                //    foreach (string line in File.ReadLines(CustomDevicesFile))
                //    {
                //        if (!listBox1.Items.Contains(line))
                //        {
                //            listBox1.Items.Add(line);
                //        }
                //    }
                //}
                //Console.WriteLine("USBFriendlyName: " + USBFriendlyName);

                if (NewDevice == true && ShowOnNew == true)
                {
                    ToggleForm();
                    NewDevice = false;
                }

                //if (AlreadyRunning == true)
                //{
                //    ToggleForm();
                //    AlreadyRunning = false;
                //}
            }
            ToggleIcons();
            SetStatus();
        }


        //Toggle Tray Icons
        public void ToggleIcons()
        {
            if (ToggleTray == "connected")
            {
                notifyIconDisconnected.Visible = notifyIconUnknown.Visible = false;
                notifyIconConnected.Visible = true;
            }
            if (ToggleTray == "disconnected")
            {
                notifyIconUnknown.Visible = notifyIconConnected.Visible = false;
                notifyIconDisconnected.Visible = true;
            }
        }

        //Set status UI on form
        private void SetStatus()
        {
            string USBFriendlyName = Properties.USBTrayNotify.Default.USBFriendlyName;
            labelDeviceSelected.Text = (USBFriendlyName);
            if (USBFriendlyName != "No Device" && USBPlug == "connected")
            {
                labelDeviceSelected.ForeColor = System.Drawing.Color.MediumSeaGreen;
                labelSelectedPrefix.Text = ("Connected");
                pictureBoxStatus.Image = Properties.Resources.USBconnected;
                this.Icon = Properties.Resources.USBconnectedNC;
            }
            if (USBFriendlyName != "No Device" && USBPlug == "disconnected")
            {
                labelDeviceSelected.ForeColor = System.Drawing.Color.Crimson;
                labelSelectedPrefix.Text = ("Disconnected");
                pictureBoxStatus.Image = Properties.Resources.USBdisconnected;
                this.Icon = Properties.Resources.USBdisconnectedNC;
            }
            if (USBFriendlyName == "No Device")
            {
                labelDeviceSelected.ForeColor = System.Drawing.Color.DarkSlateGray;
                labelSelectedPrefix.Text = ("Status: Unknown");
                pictureBoxStatus.Image = Properties.Resources.USBunknown;
                this.Icon = Properties.Resources.USBunknownNC;
                labelDeviceSelected.Text = "Plug in or select device";
            }
        }

        //Save device
        private void SaveDevice()
        {
            string USBFriendlyName = listBox1.Text.ToString();
            USBPlug = "unknown";
            Properties.USBTrayNotify.Default.USBFriendlyName = USBFriendlyName;
            Properties.USBTrayNotify.Default.Save();
            if (USBFriendlyName != "No Device")
            {
                labelDeviceSelected.Text = (USBFriendlyName);
            }
            if (USBFriendlyName == "No Device")
            {
                labelDeviceSelected.Text = "Plug in or select device";
            }
            listBox1.Text = USBFriendlyName;
            notifyIconDisconnected.Visible = notifyIconConnected.Visible = false;
            notifyIconUnknown.Visible = true;
            labelDeviceSelected.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelSelectedPrefix.Text = ("Status: Unknown");
            pictureBoxStatus.Image = Properties.Resources.USBunknown;
            this.Icon = Properties.Resources.USBunknownNC;
        }

        //Custom Add and Clear list
        //private void buttonCustomAdd_Click(object sender, EventArgs e)
        //{
        //    new CustomAdd(this).Show();
        //}

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            File.WriteAllText(DeviceSelectFile, String.Empty);
            //File.WriteAllText(CustomDevicesFile, String.Empty);
            listBox1.Items.AddRange(new object[] { "No Device" });
            listBox1.Text = "No Device";
        }

        //About
        About _form = new About();
        private void pictureBoxAbout_Click(object sender, EventArgs e)
        {
            _form.Show();
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

        //Checkbox Start with Windows
        private void checkBoxStartWithWin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartWithWin.Checked)
            {
                StartWithWindows = true;
                Properties.USBTrayNotify.Default.StartWithWindows = true;
                Properties.USBTrayNotify.Default.Save();
                Console.WriteLine(StartWithWindows);

                //RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                //key.SetValue("USBTrayNotify", Application.ExecutablePath);

                StartupShortcut();
            }
            else
            {
                StartWithWindows = false;
                Properties.USBTrayNotify.Default.StartWithWindows = false;
                Properties.USBTrayNotify.Default.Save();

                //RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                //key.DeleteValue("USBTrayNotify", false);

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

                //RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                //key.SetValue("USBTrayNotify", Application.ExecutablePath);

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

        //If already running, show
        private void fileSystemWatcherAlreadyRunning_Created(object sender, FileSystemEventArgs e)
        {
            if (File.Exists("AlreadyRunning.log"))
            {
                Show();
                WindowState = FormWindowState.Normal;
                File.Delete("AlreadyRunning.log");
            }
        }

        //Mouse hover
        private void pictureBoxMin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMin.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinFormHov;
            toTrayToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinFormHov;
        }
        private void pictureBoxMin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMin.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
            toTrayToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
        }
        private void pictureBoxCloseFormBg_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseFormBg.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
            exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
            exitToolStripMenuItem1.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBgHov;
        }
        private void pictureBoxCloseFormBg_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloseFormBg.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            exitToolStripMenuItem1.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
        }
        private void pictureBoxAbout_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAbout.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyAboutHov;
        }
        private void pictureBoxAbout_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAbout.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyAbout;
        }
        private void showHideToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            showHideToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.ShowHideHov;
            pictureBoxMin.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinFormHov;
        }
        private void showHideToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            showHideToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.ShowHide;
            pictureBoxMin.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
        }
    }
}