namespace USBTrayNotify
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.contextMenuStripOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipOptions = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxStartWithWin = new System.Windows.Forms.CheckBox();
            this.checkBoxStartMenuShorts = new System.Windows.Forms.CheckBox();
            this.checkBoxShowOnNew = new System.Windows.Forms.CheckBox();
            this.labelTitleOptions = new System.Windows.Forms.Label();
            this.pictureBoxCloseOptions = new System.Windows.Forms.PictureBox();
            this.pictureBoxOptionsMain = new System.Windows.Forms.PictureBox();
            this.labelOptionsBarTop = new System.Windows.Forms.Label();
            this.labelOptionsBarLeft = new System.Windows.Forms.Label();
            this.labelOptionsBarRight = new System.Windows.Forms.Label();
            this.labelAboutBarBottom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptionsMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripOptions
            // 
            this.contextMenuStripOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.contextMenuStripOptions.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripOptions.Name = "contextMenuStrip1";
            this.contextMenuStripOptions.Size = new System.Drawing.Size(124, 40);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoSize = false;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxCloseOptions_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.pictureBoxCloseOptions_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.pictureBoxCloseOptions_MouseLeave);
            // 
            // toolTipOptions
            // 
            this.toolTipOptions.AutomaticDelay = 600;
            this.toolTipOptions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTipOptions.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolTipOptions.IsBalloon = true;
            // 
            // checkBoxStartWithWin
            // 
            this.checkBoxStartWithWin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxStartWithWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStartWithWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartWithWin.Image = global::USBTrayNotify.Properties.Resources.options_startwithw;
            this.checkBoxStartWithWin.Location = new System.Drawing.Point(102, 23);
            this.checkBoxStartWithWin.Name = "checkBoxStartWithWin";
            this.checkBoxStartWithWin.Size = new System.Drawing.Size(210, 42);
            this.checkBoxStartWithWin.TabIndex = 0;
            this.checkBoxStartWithWin.Text = "Start with Windows";
            this.checkBoxStartWithWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxStartWithWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipOptions.SetToolTip(this.checkBoxStartWithWin, "Start USBTrayNotify when logging into Windows");
            this.checkBoxStartWithWin.UseVisualStyleBackColor = false;
            this.checkBoxStartWithWin.CheckedChanged += new System.EventHandler(this.checkBoxStartWithWin_CheckedChanged);
            // 
            // checkBoxStartMenuShorts
            // 
            this.checkBoxStartMenuShorts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxStartMenuShorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStartMenuShorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartMenuShorts.Image = global::USBTrayNotify.Properties.Resources.options_addshortc;
            this.checkBoxStartMenuShorts.Location = new System.Drawing.Point(102, 63);
            this.checkBoxStartMenuShorts.Name = "checkBoxStartMenuShorts";
            this.checkBoxStartMenuShorts.Size = new System.Drawing.Size(210, 42);
            this.checkBoxStartMenuShorts.TabIndex = 1;
            this.checkBoxStartMenuShorts.Text = "Start Menu shortcut";
            this.checkBoxStartMenuShorts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipOptions.SetToolTip(this.checkBoxStartMenuShorts, "Add or remove Start Menu shortcut for USBTrayNotify");
            this.checkBoxStartMenuShorts.UseVisualStyleBackColor = false;
            this.checkBoxStartMenuShorts.CheckedChanged += new System.EventHandler(this.checkBoxStartMenuShorts_CheckedChanged);
            // 
            // checkBoxShowOnNew
            // 
            this.checkBoxShowOnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxShowOnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowOnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowOnNew.Image = global::USBTrayNotify.Properties.Resources.options_show;
            this.checkBoxShowOnNew.Location = new System.Drawing.Point(102, 102);
            this.checkBoxShowOnNew.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxShowOnNew.Name = "checkBoxShowOnNew";
            this.checkBoxShowOnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxShowOnNew.Size = new System.Drawing.Size(210, 42);
            this.checkBoxShowOnNew.TabIndex = 2;
            this.checkBoxShowOnNew.Text = "Show on new devices";
            this.checkBoxShowOnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipOptions.SetToolTip(this.checkBoxShowOnNew, "Show USB Tray Notify window when new unknown devices are connected");
            this.checkBoxShowOnNew.UseVisualStyleBackColor = false;
            this.checkBoxShowOnNew.CheckedChanged += new System.EventHandler(this.checkBoxShowOnNew_CheckedChanged);
            // 
            // labelTitleOptions
            // 
            this.labelTitleOptions.AutoSize = true;
            this.labelTitleOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOptions.Location = new System.Drawing.Point(140, 4);
            this.labelTitleOptions.Name = "labelTitleOptions";
            this.labelTitleOptions.Size = new System.Drawing.Size(149, 15);
            this.labelTitleOptions.TabIndex = 1;
            this.labelTitleOptions.Text = "Options - USB Tray Notify";
            this.labelTitleOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // pictureBoxCloseOptions
            // 
            this.pictureBoxCloseOptions.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCloseOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseOptions.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.pictureBoxCloseOptions.Location = new System.Drawing.Point(372, 8);
            this.pictureBoxCloseOptions.Name = "pictureBoxCloseOptions";
            this.pictureBoxCloseOptions.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxCloseOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloseOptions.TabIndex = 2;
            this.pictureBoxCloseOptions.TabStop = false;
            this.pictureBoxCloseOptions.Click += new System.EventHandler(this.pictureBoxCloseOptions_Click);
            this.pictureBoxCloseOptions.MouseEnter += new System.EventHandler(this.pictureBoxCloseOptions_MouseEnter);
            this.pictureBoxCloseOptions.MouseLeave += new System.EventHandler(this.pictureBoxCloseOptions_MouseLeave);
            // 
            // pictureBoxOptionsMain
            // 
            this.pictureBoxOptionsMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOptionsMain.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyOptionsHov;
            this.pictureBoxOptionsMain.Location = new System.Drawing.Point(7, 8);
            this.pictureBoxOptionsMain.Name = "pictureBoxOptionsMain";
            this.pictureBoxOptionsMain.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxOptionsMain.TabIndex = 4;
            this.pictureBoxOptionsMain.TabStop = false;
            this.pictureBoxOptionsMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDragButton);
            // 
            // labelOptionsBarTop
            // 
            this.labelOptionsBarTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOptionsBarTop.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelOptionsBarTop.Location = new System.Drawing.Point(13, 21);
            this.labelOptionsBarTop.Name = "labelOptionsBarTop";
            this.labelOptionsBarTop.Size = new System.Drawing.Size(403, 2);
            this.labelOptionsBarTop.TabIndex = 5;
            this.labelOptionsBarTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelOptionsBarLeft
            // 
            this.labelOptionsBarLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOptionsBarLeft.Location = new System.Drawing.Point(13, 22);
            this.labelOptionsBarLeft.Name = "labelOptionsBarLeft";
            this.labelOptionsBarLeft.Size = new System.Drawing.Size(2, 175);
            this.labelOptionsBarLeft.TabIndex = 12;
            this.labelOptionsBarLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelOptionsBarRight
            // 
            this.labelOptionsBarRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOptionsBarRight.Location = new System.Drawing.Point(415, 23);
            this.labelOptionsBarRight.Name = "labelOptionsBarRight";
            this.labelOptionsBarRight.Size = new System.Drawing.Size(2, 175);
            this.labelOptionsBarRight.TabIndex = 16;
            // 
            // labelAboutBarBottom
            // 
            this.labelAboutBarBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAboutBarBottom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelAboutBarBottom.Location = new System.Drawing.Point(13, 196);
            this.labelAboutBarBottom.Name = "labelAboutBarBottom";
            this.labelAboutBarBottom.Size = new System.Drawing.Size(404, 2);
            this.labelAboutBarBottom.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxStartWithWin);
            this.panel1.Controls.Add(this.checkBoxShowOnNew);
            this.panel1.Controls.Add(this.checkBoxStartMenuShorts);
            this.panel1.Location = new System.Drawing.Point(13, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 176);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(429, 211);
            this.ContextMenuStrip = this.contextMenuStripOptions;
            this.Controls.Add(this.pictureBoxCloseOptions);
            this.Controls.Add(this.pictureBoxOptionsMain);
            this.Controls.Add(this.labelAboutBarBottom);
            this.Controls.Add(this.labelOptionsBarRight);
            this.Controls.Add(this.labelOptionsBarLeft);
            this.Controls.Add(this.labelOptionsBarTop);
            this.Controls.Add(this.labelTitleOptions);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Options - USB Tray Notify";
            this.Load += new System.EventHandler(this.Options_Load);
            this.contextMenuStripOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptionsMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipOptions;
        private System.Windows.Forms.Label labelTitleOptions;
        private System.Windows.Forms.PictureBox pictureBoxCloseOptions;
        private System.Windows.Forms.PictureBox pictureBoxOptionsMain;
        private System.Windows.Forms.Label labelOptionsBarTop;
        private System.Windows.Forms.Label labelOptionsBarLeft;
        private System.Windows.Forms.CheckBox checkBoxStartWithWin;
        private System.Windows.Forms.CheckBox checkBoxStartMenuShorts;
        private System.Windows.Forms.CheckBox checkBoxShowOnNew;
        private System.Windows.Forms.Label labelOptionsBarRight;
        private System.Windows.Forms.Label labelAboutBarBottom;
        private System.Windows.Forms.Panel panel1;
    }
}