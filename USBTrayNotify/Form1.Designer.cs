namespace USBTrayNotify
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcherUSBLog = new System.IO.FileSystemWatcher();
            this.notifyIconDisconnected = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconConnected = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconUnknown = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDeviceSelected = new System.Windows.Forms.Label();
            this.backgroundWorkerUSBLog = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCloseFormBg = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.toolTipForm1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxOptions = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSelectedPrefix = new System.Windows.Forms.Label();
            this.fileSystemWatcherAlreadyRunning = new System.IO.FileSystemWatcher();
            this.labelBarRight = new System.Windows.Forms.Label();
            this.labelBarBottom = new System.Windows.Forms.Label();
            this.labelBarLeft = new System.Windows.Forms.Label();
            this.labelBarTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherUSBLog)).BeginInit();
            this.contextMenuStripTray.SuspendLayout();
            this.contextMenuStripForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFormBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherAlreadyRunning)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcherUSBLog
            // 
            this.fileSystemWatcherUSBLog.EnableRaisingEvents = true;
            this.fileSystemWatcherUSBLog.Filter = "USBLogView.log";
            this.fileSystemWatcherUSBLog.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcherUSBLog.Path = "C:";
            this.fileSystemWatcherUSBLog.SynchronizingObject = this;
            this.fileSystemWatcherUSBLog.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // notifyIconDisconnected
            // 
            this.notifyIconDisconnected.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconDisconnected.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDisconnected.Icon")));
            this.notifyIconDisconnected.Text = "USB Tray Notify";
            this.notifyIconDisconnected.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIconConnected_MouseUp);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.contextMenuStripTray.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.contextMenuStripTray.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStrip1";
            this.contextMenuStripTray.Size = new System.Drawing.Size(221, 76);
            this.contextMenuStripTray.Text = "USBTrayNotify";
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.AutoSize = false;
            this.showHideToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.showHideToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.showHideToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.ShowHide;
            this.showHideToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            this.showHideToolStripMenuItem.MouseEnter += new System.EventHandler(this.showHideToolStripMenuItem_MouseEnter);
            this.showHideToolStripMenuItem.MouseLeave += new System.EventHandler(this.showHideToolStripMenuItem_MouseLeave);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoSize = false;
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExit_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.pictureBoxCloseFormBg_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.pictureBoxCloseFormBg_MouseLeave);
            // 
            // notifyIconConnected
            // 
            this.notifyIconConnected.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconConnected.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconConnected.Icon")));
            this.notifyIconConnected.Text = "USB Tray Notify";
            this.notifyIconConnected.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIconConnected_MouseUp);
            // 
            // notifyIconUnknown
            // 
            this.notifyIconUnknown.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconUnknown.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconUnknown.Icon")));
            this.notifyIconUnknown.Text = "USB Tray Notify";
            this.notifyIconUnknown.Visible = true;
            this.notifyIconUnknown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIconConnected_MouseUp);
            // 
            // contextMenuStripForm
            // 
            this.contextMenuStripForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.contextMenuStripForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripForm.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTrayToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStripForm.Name = "contextMenuStripForm";
            this.contextMenuStripForm.Size = new System.Drawing.Size(150, 76);
            // 
            // toTrayToolStripMenuItem
            // 
            this.toTrayToolStripMenuItem.AutoSize = false;
            this.toTrayToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toTrayToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTrayToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
            this.toTrayToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.toTrayToolStripMenuItem.Name = "toTrayToolStripMenuItem";
            this.toTrayToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.toTrayToolStripMenuItem.Text = "Tray";
            this.toTrayToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.toTrayToolStripMenuItem.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            this.toTrayToolStripMenuItem.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.AutoSize = false;
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.exitToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.MenuExit_Click);
            this.exitToolStripMenuItem1.MouseEnter += new System.EventHandler(this.pictureBoxCloseFormBg_MouseEnter);
            this.exitToolStripMenuItem1.MouseLeave += new System.EventHandler(this.pictureBoxCloseFormBg_MouseLeave);
            // 
            // labelDeviceSelected
            // 
            this.labelDeviceSelected.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDeviceSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDeviceSelected.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceSelected.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelDeviceSelected.Location = new System.Drawing.Point(41, 93);
            this.labelDeviceSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeviceSelected.Name = "labelDeviceSelected";
            this.labelDeviceSelected.Size = new System.Drawing.Size(760, 32);
            this.labelDeviceSelected.TabIndex = 3;
            this.labelDeviceSelected.Text = "DeviceSelected";
            this.labelDeviceSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDeviceSelected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // backgroundWorkerUSBLog
            // 
            this.backgroundWorkerUSBLog.WorkerSupportsCancellation = true;
            this.backgroundWorkerUSBLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerUSBLog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(41, 140);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(760, 180);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.buttonSaveDevice_Click);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(732, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tray";
            this.label2.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.label2.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.MenuExit_Click);
            this.label3.MouseEnter += new System.EventHandler(this.pictureBoxCloseFormBg_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.pictureBoxCloseFormBg_MouseLeave);
            // 
            // pictureBoxCloseFormBg
            // 
            this.pictureBoxCloseFormBg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCloseFormBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseFormBg.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.pictureBoxCloseFormBg.Location = new System.Drawing.Point(777, 8);
            this.pictureBoxCloseFormBg.Name = "pictureBoxCloseFormBg";
            this.pictureBoxCloseFormBg.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCloseFormBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloseFormBg.TabIndex = 7;
            this.pictureBoxCloseFormBg.TabStop = false;
            this.toolTipForm1.SetToolTip(this.pictureBoxCloseFormBg, "Exit App");
            this.pictureBoxCloseFormBg.Click += new System.EventHandler(this.MenuExit_Click);
            this.pictureBoxCloseFormBg.MouseEnter += new System.EventHandler(this.pictureBoxCloseFormBg_MouseEnter);
            this.pictureBoxCloseFormBg.MouseLeave += new System.EventHandler(this.pictureBoxCloseFormBg_MouseLeave);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMin.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
            this.pictureBoxMin.Location = new System.Drawing.Point(721, 8);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMin.TabIndex = 6;
            this.pictureBoxMin.TabStop = false;
            this.toolTipForm1.SetToolTip(this.pictureBoxMin, "Minimize To Tray");
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMin.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            this.pictureBoxMin.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStatus.Image = global::USBTrayNotify.Properties.Resources.USBunknown;
            this.pictureBoxStatus.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStatus.TabIndex = 5;
            this.pictureBoxStatus.TabStop = false;
            this.pictureBoxStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDragButton);
            // 
            // toolTipForm1
            // 
            this.toolTipForm1.AutomaticDelay = 600;
            this.toolTipForm1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTipForm1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolTipForm1.IsBalloon = true;
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyAbout;
            this.pictureBoxAbout.Location = new System.Drawing.Point(799, 410);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAbout.TabIndex = 8;
            this.pictureBoxAbout.TabStop = false;
            this.toolTipForm1.SetToolTip(this.pictureBoxAbout, "Help and About");
            this.pictureBoxAbout.Click += new System.EventHandler(this.pictureBoxAbout_Click);
            this.pictureBoxAbout.MouseEnter += new System.EventHandler(this.pictureBoxAbout_MouseEnter);
            this.pictureBoxAbout.MouseLeave += new System.EventHandler(this.pictureBoxAbout_MouseLeave);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(350, 344);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxClear.TabIndex = 17;
            this.pictureBoxClear.TabStop = false;
            this.toolTipForm1.SetToolTip(this.pictureBoxClear, "Clear known list and set device to none");
            this.pictureBoxClear.Click += new System.EventHandler(this.buttonClearList_Click);
            this.pictureBoxClear.MouseEnter += new System.EventHandler(this.pictureBoxClear_MouseEnter);
            this.pictureBoxClear.MouseLeave += new System.EventHandler(this.pictureBoxClear_MouseLeave);
            // 
            // pictureBoxOptions
            // 
            this.pictureBoxOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOptions.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyOptionsHov;
            this.pictureBoxOptions.Location = new System.Drawing.Point(437, 345);
            this.pictureBoxOptions.Name = "pictureBoxOptions";
            this.pictureBoxOptions.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOptions.TabIndex = 19;
            this.pictureBoxOptions.TabStop = false;
            this.toolTipForm1.SetToolTip(this.pictureBoxOptions, "App Options");
            this.pictureBoxOptions.Click += new System.EventHandler(this.pictureBoxOptions_Click);
            this.pictureBoxOptions.MouseEnter += new System.EventHandler(this.pictureBoxOptions_MouseEnter);
            this.pictureBoxOptions.MouseLeave += new System.EventHandler(this.pictureBoxOptions_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(369, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 30);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "USB Tray Notify";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelSelectedPrefix
            // 
            this.labelSelectedPrefix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSelectedPrefix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPrefix.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSelectedPrefix.Location = new System.Drawing.Point(338, 46);
            this.labelSelectedPrefix.Name = "labelSelectedPrefix";
            this.labelSelectedPrefix.Size = new System.Drawing.Size(158, 23);
            this.labelSelectedPrefix.TabIndex = 10;
            this.labelSelectedPrefix.Text = "Status: Unknown";
            this.labelSelectedPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedPrefix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // fileSystemWatcherAlreadyRunning
            // 
            this.fileSystemWatcherAlreadyRunning.EnableRaisingEvents = true;
            this.fileSystemWatcherAlreadyRunning.Filter = "AlreadyRunning.log";
            this.fileSystemWatcherAlreadyRunning.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileSystemWatcherAlreadyRunning.Path = "C:";
            this.fileSystemWatcherAlreadyRunning.SynchronizingObject = this;
            this.fileSystemWatcherAlreadyRunning.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcherAlreadyRunning_Created);
            // 
            // labelBarRight
            // 
            this.labelBarRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarRight.Location = new System.Drawing.Point(831, 25);
            this.labelBarRight.Name = "labelBarRight";
            this.labelBarRight.Size = new System.Drawing.Size(2, 417);
            this.labelBarRight.TabIndex = 13;
            this.labelBarRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelBarBottom
            // 
            this.labelBarBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarBottom.Location = new System.Drawing.Point(14, 441);
            this.labelBarBottom.Name = "labelBarBottom";
            this.labelBarBottom.Size = new System.Drawing.Size(819, 2);
            this.labelBarBottom.TabIndex = 14;
            this.labelBarBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelBarLeft
            // 
            this.labelBarLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarLeft.Location = new System.Drawing.Point(14, 25);
            this.labelBarLeft.Name = "labelBarLeft";
            this.labelBarLeft.Size = new System.Drawing.Size(2, 417);
            this.labelBarLeft.TabIndex = 15;
            this.labelBarLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelBarTop
            // 
            this.labelBarTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBarTop.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelBarTop.Location = new System.Drawing.Point(14, 25);
            this.labelBarTop.Name = "labelBarTop";
            this.labelBarTop.Size = new System.Drawing.Size(818, 1);
            this.labelBarTop.TabIndex = 16;
            this.labelBarTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(355, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clear";
            this.label1.Click += new System.EventHandler(this.buttonClearList_Click);
            this.label1.MouseEnter += new System.EventHandler(this.pictureBoxClear_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.pictureBoxClear_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(434, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Options";
            this.label4.Click += new System.EventHandler(this.pictureBoxOptions_Click);
            this.label4.MouseEnter += new System.EventHandler(this.pictureBoxOptions_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.pictureBoxOptions_MouseLeave);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 175);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(150, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(150, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(150, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 150);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 150);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 417);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(845, 454);
            this.ContextMenuStrip = this.contextMenuStripForm;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.pictureBoxStatus);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxCloseFormBg);
            this.Controls.Add(this.labelBarTop);
            this.Controls.Add(this.labelBarBottom);
            this.Controls.Add(this.labelBarLeft);
            this.Controls.Add(this.labelBarRight);
            this.Controls.Add(this.labelSelectedPrefix);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDeviceSelected);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Tray Notify";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1Load);
            this.Shown += new System.EventHandler(this.Form1HideOnStart);
            this.Resize += new System.EventHandler(this.Form1HideOnStart);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherUSBLog)).EndInit();
            this.contextMenuStripTray.ResumeLayout(false);
            this.contextMenuStripForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFormBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherAlreadyRunning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcherUSBLog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUSBLog;
        public System.Windows.Forms.NotifyIcon notifyIconConnected;
        public System.Windows.Forms.NotifyIcon notifyIconDisconnected;
        public System.Windows.Forms.NotifyIcon notifyIconUnknown;
        public System.Windows.Forms.Label labelDeviceSelected;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxCloseFormBg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipForm1;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSelectedPrefix;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForm;
        private System.Windows.Forms.ToolStripMenuItem toTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.IO.FileSystemWatcher fileSystemWatcherAlreadyRunning;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.Label labelBarRight;
        private System.Windows.Forms.Label labelBarBottom;
        private System.Windows.Forms.Label labelBarLeft;
        private System.Windows.Forms.Label labelBarTop;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

