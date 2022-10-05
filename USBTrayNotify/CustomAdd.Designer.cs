namespace USBTrayNotify
{
    partial class CustomAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAdd));
            this.CustomAddBox1 = new System.Windows.Forms.TextBox();
            this.buttonCustomSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAddCutomTitle = new System.Windows.Forms.Label();
            this.closeBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomAddBox1
            // 
            this.CustomAddBox1.BackColor = System.Drawing.Color.Gray;
            this.CustomAddBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomAddBox1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomAddBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CustomAddBox1.Location = new System.Drawing.Point(42, 140);
            this.CustomAddBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomAddBox1.Name = "CustomAddBox1";
            this.CustomAddBox1.Size = new System.Drawing.Size(522, 44);
            this.CustomAddBox1.TabIndex = 0;
            // 
            // buttonCustomSave
            // 
            this.buttonCustomSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCustomSave.FlatAppearance.BorderSize = 2;
            this.buttonCustomSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.buttonCustomSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomSave.ForeColor = System.Drawing.Color.DimGray;
            this.buttonCustomSave.Location = new System.Drawing.Point(254, 213);
            this.buttonCustomSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCustomSave.Name = "buttonCustomSave";
            this.buttonCustomSave.Size = new System.Drawing.Size(86, 60);
            this.buttonCustomSave.TabIndex = 1;
            this.buttonCustomSave.Text = "Save";
            this.buttonCustomSave.UseVisualStyleBackColor = true;
            this.buttonCustomSave.Click += new System.EventHandler(this.buttonCustomSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(174, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "This allows for manual entry.\r\nYou can use USBLogView to find a name.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddCutomTitle
            // 
            this.labelAddCutomTitle.AutoSize = true;
            this.labelAddCutomTitle.Location = new System.Drawing.Point(12, 9);
            this.labelAddCutomTitle.Name = "labelAddCutomTitle";
            this.labelAddCutomTitle.Size = new System.Drawing.Size(190, 30);
            this.labelAddCutomTitle.TabIndex = 3;
            this.labelAddCutomTitle.Text = "Custom add device";
            this.labelAddCutomTitle.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
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
            this.exitToolStripMenuItem.Image = global::USBTrayNotify.Properties.Resources.USBTrayNotifyClose;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.closeBox2_Click);
            // 
            // CustomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 342);
            this.Controls.Add(this.closeBox2);
            this.Controls.Add(this.labelAddCutomTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCustomSave);
            this.Controls.Add(this.CustomAddBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Tray Notify - Custom Add";
            ((System.ComponentModel.ISupportInitialize)(this.closeBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomAddBox1;
        private System.Windows.Forms.Button buttonCustomSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAddCutomTitle;
        private System.Windows.Forms.PictureBox closeBox2;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}