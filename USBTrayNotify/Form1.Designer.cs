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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIconDisconnected = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconConnected = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconUnknown = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelDeviceSelected = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxShowOnNew = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCloseFormBg = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxStartWithWin = new System.Windows.Forms.CheckBox();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.checkBoxStartMenuShorts = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSelectedPrefix = new System.Windows.Forms.Label();
            this.contextMenuStripForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcherAlreadyRunning = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFormBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.contextMenuStripForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherAlreadyRunning)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "USBLogView.log";
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.Path = "C:";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // notifyIconDisconnected
            // 
            this.notifyIconDisconnected.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconDisconnected.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDisconnected.Icon")));
            this.notifyIconDisconnected.Text = "USB Tray Notify";
            this.notifyIconDisconnected.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIconConnected_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 44);
            this.contextMenuStrip1.Text = "USBTrayNotify";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // notifyIconConnected
            // 
            this.notifyIconConnected.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconConnected.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconConnected.Icon")));
            this.notifyIconConnected.Text = "USB Tray Notify";
            this.notifyIconConnected.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIconConnected_MouseUp);
            // 
            // notifyIconUnknown
            // 
            this.notifyIconUnknown.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconUnknown.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconUnknown.Icon")));
            this.notifyIconUnknown.Text = "USB Tray Notify";
            this.notifyIconUnknown.Visible = true;
            this.notifyIconUnknown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIconConnected_MouseUp);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // buttonClearList
            // 
            this.buttonClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.buttonClearList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(240)))), ((int)(((byte)(145)))));
            this.buttonClearList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(197)))), ((int)(((byte)(117)))));
            this.buttonClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearList.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearList.ForeColor = System.Drawing.Color.DimGray;
            this.buttonClearList.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyClear;
            this.buttonClearList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClearList.Location = new System.Drawing.Point(181, 356);
            this.buttonClearList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(98, 54);
            this.buttonClearList.TabIndex = 1;
            this.buttonClearList.Text = "Clear";
            this.buttonClearList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonClearList, "Clear known list and set device to none");
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
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
            // checkBoxShowOnNew
            // 
            this.checkBoxShowOnNew.AutoSize = true;
            this.checkBoxShowOnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowOnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowOnNew.Location = new System.Drawing.Point(526, 373);
            this.checkBoxShowOnNew.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxShowOnNew.Name = "checkBoxShowOnNew";
            this.checkBoxShowOnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxShowOnNew.Size = new System.Drawing.Size(273, 33);
            this.checkBoxShowOnNew.TabIndex = 3;
            this.checkBoxShowOnNew.Text = "Show on new devices";
            this.toolTip1.SetToolTip(this.checkBoxShowOnNew, "Show this window when new unknown devices are connected");
            this.checkBoxShowOnNew.UseVisualStyleBackColor = true;
            this.checkBoxShowOnNew.CheckedChanged += new System.EventHandler(this.checkBoxShowOnNew_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exit";
            // 
            // pictureBoxCloseFormBg
            // 
            this.pictureBoxCloseFormBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseFormBg.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.pictureBoxCloseFormBg.Location = new System.Drawing.Point(787, 8);
            this.pictureBoxCloseFormBg.Name = "pictureBoxCloseFormBg";
            this.pictureBoxCloseFormBg.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCloseFormBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloseFormBg.TabIndex = 7;
            this.pictureBoxCloseFormBg.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCloseFormBg, "Exit App");
            this.pictureBoxCloseFormBg.Click += new System.EventHandler(this.MenuExit_Click);
            this.pictureBoxCloseFormBg.MouseEnter += new System.EventHandler(this.pictureBoxCloseFormBg_MouseEnter);
            this.pictureBoxCloseFormBg.MouseLeave += new System.EventHandler(this.pictureBoxCloseFormBg_MouseLeave);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMin.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
            this.pictureBoxMin.Location = new System.Drawing.Point(731, 8);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMin.TabIndex = 6;
            this.pictureBoxMin.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxMin, "Minimize To Tray");
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMin.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            this.pictureBoxMin.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Image = global::USBTrayNotify.Properties.Resources.USBunknown;
            this.pictureBoxStatus.Location = new System.Drawing.Point(2, 4);
            this.pictureBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStatus.TabIndex = 5;
            this.pictureBoxStatus.TabStop = false;
            this.pictureBoxStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 350;
            this.toolTip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolTip1.IsBalloon = true;
            // 
            // checkBoxStartWithWin
            // 
            this.checkBoxStartWithWin.AutoSize = true;
            this.checkBoxStartWithWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStartWithWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartWithWin.Location = new System.Drawing.Point(526, 347);
            this.checkBoxStartWithWin.Name = "checkBoxStartWithWin";
            this.checkBoxStartWithWin.Size = new System.Drawing.Size(242, 33);
            this.checkBoxStartWithWin.TabIndex = 2;
            this.checkBoxStartWithWin.Text = "Start with Windows";
            this.toolTip1.SetToolTip(this.checkBoxStartWithWin, "Start USB Tray Notify when Windows starts");
            this.checkBoxStartWithWin.UseVisualStyleBackColor = true;
            this.checkBoxStartWithWin.CheckedChanged += new System.EventHandler(this.checkBoxStartWithWin_CheckedChanged);
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.Image")));
            this.pictureBoxAbout.Location = new System.Drawing.Point(808, 416);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(34, 36);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAbout.TabIndex = 8;
            this.pictureBoxAbout.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxAbout, "Help and About");
            this.pictureBoxAbout.Click += new System.EventHandler(this.pictureBoxAbout_Click);
            this.pictureBoxAbout.MouseEnter += new System.EventHandler(this.pictureBoxAbout_MouseEnter);
            this.pictureBoxAbout.MouseLeave += new System.EventHandler(this.pictureBoxAbout_MouseLeave);
            // 
            // checkBoxStartMenuShorts
            // 
            this.checkBoxStartMenuShorts.AutoSize = true;
            this.checkBoxStartMenuShorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStartMenuShorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartMenuShorts.Location = new System.Drawing.Point(526, 399);
            this.checkBoxStartMenuShorts.Name = "checkBoxStartMenuShorts";
            this.checkBoxStartMenuShorts.Size = new System.Drawing.Size(256, 33);
            this.checkBoxStartMenuShorts.TabIndex = 4;
            this.checkBoxStartMenuShorts.Text = "Start Menu shortcuts";
            this.toolTip1.SetToolTip(this.checkBoxStartMenuShorts, "Add or remove USBTrayNotify Start Menu shortcuts");
            this.checkBoxStartMenuShorts.UseVisualStyleBackColor = true;
            this.checkBoxStartMenuShorts.CheckedChanged += new System.EventHandler(this.checkBoxStartMenuShorts_CheckedChanged);
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
            // contextMenuStripForm
            // 
            this.contextMenuStripForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.contextMenuStripForm.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTrayToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStripForm.Name = "contextMenuStripForm";
            this.contextMenuStripForm.Size = new System.Drawing.Size(303, 154);
            // 
            // toTrayToolStripMenuItem
            // 
            this.toTrayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTrayToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyMinForm;
            this.toTrayToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toTrayToolStripMenuItem.Name = "toTrayToolStripMenuItem";
            this.toTrayToolStripMenuItem.Size = new System.Drawing.Size(302, 56);
            this.toTrayToolStripMenuItem.Text = "Tray";
            this.toTrayToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.toTrayToolStripMenuItem.MouseEnter += new System.EventHandler(this.pictureBoxMin_MouseEnter);
            this.toTrayToolStripMenuItem.MouseLeave += new System.EventHandler(this.pictureBoxMin_MouseLeave);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.exitToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(302, 56);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.MenuExit_Click);
            this.exitToolStripMenuItem1.MouseEnter += new System.EventHandler(this.pictureBoxCloseFormBg_MouseEnter);
            this.exitToolStripMenuItem1.MouseLeave += new System.EventHandler(this.pictureBoxCloseFormBg_MouseLeave);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(81, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(633, 2);
            this.label5.TabIndex = 12;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(845, 454);
            this.ContextMenuStrip = this.contextMenuStripForm;
            this.Controls.Add(this.pictureBoxStatus);
            this.Controls.Add(this.checkBoxStartMenuShorts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxCloseFormBg);
            this.Controls.Add(this.pictureBoxMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSelectedPrefix);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.checkBoxStartWithWin);
            this.Controls.Add(this.checkBoxShowOnNew);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.labelDeviceSelected);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFormBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.contextMenuStripForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherAlreadyRunning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonClearList;
        public System.Windows.Forms.NotifyIcon notifyIconConnected;
        public System.Windows.Forms.NotifyIcon notifyIconDisconnected;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.NotifyIcon notifyIconUnknown;
        public System.Windows.Forms.Label labelDeviceSelected;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxShowOnNew;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxCloseFormBg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxStartWithWin;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSelectedPrefix;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForm;
        private System.Windows.Forms.ToolStripMenuItem toTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxStartMenuShorts;
        private System.IO.FileSystemWatcher fileSystemWatcherAlreadyRunning;
    }
}

