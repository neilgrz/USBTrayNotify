namespace USBTrayNotify
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelTitleAbout = new System.Windows.Forms.Label();
            this.pictureBoxCloseAbout = new System.Windows.Forms.PictureBox();
            this.labelAboutInfo = new System.Windows.Forms.Label();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.toolTipAbout = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripAbout = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAboutMain = new System.Windows.Forms.PictureBox();
            this.labelAboutBarTop = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAboutBarLeft = new System.Windows.Forms.Label();
            this.labelAboutBarBottom = new System.Windows.Forms.Label();
            this.labelAboutBarRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseAbout)).BeginInit();
            this.contextMenuStripAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleAbout
            // 
            this.labelTitleAbout.AutoSize = true;
            this.labelTitleAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAbout.Location = new System.Drawing.Point(189, 4);
            this.labelTitleAbout.Name = "labelTitleAbout";
            this.labelTitleAbout.Size = new System.Drawing.Size(75, 30);
            this.labelTitleAbout.TabIndex = 0;
            this.labelTitleAbout.Text = "About";
            this.labelTitleAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // pictureBoxCloseAbout
            // 
            this.pictureBoxCloseAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseAbout.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.pictureBoxCloseAbout.Location = new System.Drawing.Point(372, 8);
            this.pictureBoxCloseAbout.Name = "pictureBoxCloseAbout";
            this.pictureBoxCloseAbout.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCloseAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloseAbout.TabIndex = 1;
            this.pictureBoxCloseAbout.TabStop = false;
            this.pictureBoxCloseAbout.Click += new System.EventHandler(this.pictureBoxCloseAbout_Click);
            this.pictureBoxCloseAbout.MouseEnter += new System.EventHandler(this.pictureBoxCloseAbout_MouseEnter);
            this.pictureBoxCloseAbout.MouseLeave += new System.EventHandler(this.pictureBoxCloseAbout_MouseLeave);
            // 
            // labelAboutInfo
            // 
            this.labelAboutInfo.AutoSize = true;
            this.labelAboutInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelAboutInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAboutInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutInfo.Location = new System.Drawing.Point(134, 49);
            this.labelAboutInfo.Name = "labelAboutInfo";
            this.labelAboutInfo.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.labelAboutInfo.Size = new System.Drawing.Size(232, 114);
            this.labelAboutInfo.TabIndex = 2;
            this.labelAboutInfo.Text = "USB Tray Notify\r\n Version: 1.0.0";
            this.labelAboutInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAbout.Location = new System.Drawing.Point(92, 262);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(437, 31);
            this.linkLabelAbout.TabIndex = 0;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "https://github.com/neilgrz/USBTrayNotify";
            this.toolTipAbout.SetToolTip(this.linkLabelAbout, "GitHub Repository");
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // toolTipAbout
            // 
            this.toolTipAbout.AutomaticDelay = 600;
            this.toolTipAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTipAbout.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolTipAbout.IsBalloon = true;
            // 
            // contextMenuStripAbout
            // 
            this.contextMenuStripAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.contextMenuStripAbout.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStripAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripAbout.Name = "contextMenuStrip1";
            this.contextMenuStripAbout.Size = new System.Drawing.Size(164, 40);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoSize = false;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyCloseFormBg;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.pictureBoxCloseAbout_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.pictureBoxCloseAbout_MouseLeave);
            // 
            // pictureBoxAboutMain
            // 
            this.pictureBoxAboutMain.Image = global::USBTrayNotify.Properties.Resources.USBdisconnected;
            this.pictureBoxAboutMain.Location = new System.Drawing.Point(7, 8);
            this.pictureBoxAboutMain.Name = "pictureBoxAboutMain";
            this.pictureBoxAboutMain.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAboutMain.TabIndex = 3;
            this.pictureBoxAboutMain.TabStop = false;
            this.pictureBoxAboutMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDragButton);
            // 
            // labelAboutBarTop
            // 
            this.labelAboutBarTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAboutBarTop.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelAboutBarTop.Location = new System.Drawing.Point(13, 21);
            this.labelAboutBarTop.Name = "labelAboutBarTop";
            this.labelAboutBarTop.Size = new System.Drawing.Size(403, 2);
            this.labelAboutBarTop.TabIndex = 4;
            this.labelAboutBarTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::USBTrayNotify.Properties.Resources.USBconnectedSM;
            this.pictureBox2.Location = new System.Drawing.Point(94, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::USBTrayNotify.Properties.Resources.USBdisconnectedSM;
            this.pictureBox3.Location = new System.Drawing.Point(187, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::USBTrayNotify.Properties.Resources.USBunkownSM;
            this.pictureBox4.Location = new System.Drawing.Point(281, 167);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Connected";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Disconnected";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unknown";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelAboutBarLeft
            // 
            this.labelAboutBarLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAboutBarLeft.Location = new System.Drawing.Point(13, 22);
            this.labelAboutBarLeft.Name = "labelAboutBarLeft";
            this.labelAboutBarLeft.Size = new System.Drawing.Size(2, 276);
            this.labelAboutBarLeft.TabIndex = 11;
            this.labelAboutBarLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelAboutBarBottom
            // 
            this.labelAboutBarBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAboutBarBottom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelAboutBarBottom.Location = new System.Drawing.Point(13, 297);
            this.labelAboutBarBottom.Name = "labelAboutBarBottom";
            this.labelAboutBarBottom.Size = new System.Drawing.Size(403, 2);
            this.labelAboutBarBottom.TabIndex = 12;
            this.labelAboutBarBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // labelAboutBarRight
            // 
            this.labelAboutBarRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAboutBarRight.Location = new System.Drawing.Point(415, 23);
            this.labelAboutBarRight.Name = "labelAboutBarRight";
            this.labelAboutBarRight.Size = new System.Drawing.Size(2, 276);
            this.labelAboutBarRight.TabIndex = 13;
            this.labelAboutBarRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDrag);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(429, 310);
            this.ContextMenuStrip = this.contextMenuStripAbout;
            this.Controls.Add(this.pictureBoxCloseAbout);
            this.Controls.Add(this.labelAboutBarRight);
            this.Controls.Add(this.labelAboutBarBottom);
            this.Controls.Add(this.pictureBoxAboutMain);
            this.Controls.Add(this.labelAboutBarLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.labelAboutInfo);
            this.Controls.Add(this.labelTitleAbout);
            this.Controls.Add(this.labelAboutBarTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About - USB Tray Notify";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseAbout)).EndInit();
            this.contextMenuStripAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleAbout;
        private System.Windows.Forms.PictureBox pictureBoxCloseAbout;
        private System.Windows.Forms.Label labelAboutInfo;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.ToolTip toolTipAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAbout;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxAboutMain;
        private System.Windows.Forms.Label labelAboutBarTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAboutBarLeft;
        private System.Windows.Forms.Label labelAboutBarBottom;
        private System.Windows.Forms.Label labelAboutBarRight;
    }
}