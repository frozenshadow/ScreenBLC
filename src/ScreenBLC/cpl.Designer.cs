namespace ScreenBLC
{
    partial class cpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cpl));
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.currentValue = new System.Windows.Forms.Label();
            this.brightnessOffset = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.srtStp_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.screenRefresh_btn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.refreshInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.environmentValue = new System.Windows.Forms.Label();
            this.envRefresh_btn = new System.Windows.Forms.Button();
            this.possibleValues = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessOffset)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.Black;
            this.previewBox.Location = new System.Drawing.Point(6, 19);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(212, 119);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // currentValue
            // 
            this.currentValue.AutoSize = true;
            this.currentValue.Location = new System.Drawing.Point(203, 238);
            this.currentValue.Margin = new System.Windows.Forms.Padding(12);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(33, 13);
            this.currentValue.TabIndex = 1;
            this.currentValue.Text = "100%";
            // 
            // brightnessOffset
            // 
            this.brightnessOffset.Location = new System.Drawing.Point(12, 401);
            this.brightnessOffset.Margin = new System.Windows.Forms.Padding(12, 12, 12, 3);
            this.brightnessOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.brightnessOffset.Name = "brightnessOffset";
            this.brightnessOffset.Size = new System.Drawing.Size(107, 20);
            this.brightnessOffset.TabIndex = 2;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(12, 175);
            this.comboBoxDevices.Margin = new System.Windows.Forms.Padding(12);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(224, 21);
            this.comboBoxDevices.TabIndex = 3;
            // 
            // srtStp_btn
            // 
            this.srtStp_btn.Location = new System.Drawing.Point(12, 202);
            this.srtStp_btn.Margin = new System.Windows.Forms.Padding(12);
            this.srtStp_btn.Name = "srtStp_btn";
            this.srtStp_btn.Size = new System.Drawing.Size(224, 23);
            this.srtStp_btn.TabIndex = 4;
            this.srtStp_btn.Text = "Start / Stop";
            this.srtStp_btn.UseVisualStyleBackColor = true;
            this.srtStp_btn.Click += new System.EventHandler(this.srtStp_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current screen brightness:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.previewBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Offset (%):";
            // 
            // screenRefresh_btn
            // 
            this.screenRefresh_btn.AutoSize = true;
            this.screenRefresh_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenRefresh_btn.Location = new System.Drawing.Point(12, 233);
            this.screenRefresh_btn.Margin = new System.Windows.Forms.Padding(12);
            this.screenRefresh_btn.Name = "screenRefresh_btn";
            this.screenRefresh_btn.Size = new System.Drawing.Size(49, 23);
            this.screenRefresh_btn.TabIndex = 8;
            this.screenRefresh_btn.Text = "refresh";
            this.screenRefresh_btn.UseVisualStyleBackColor = true;
            this.screenRefresh_btn.Click += new System.EventHandler(this.screenRefresh_btn_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 5000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // refreshInterval
            // 
            this.refreshInterval.Location = new System.Drawing.Point(129, 401);
            this.refreshInterval.Margin = new System.Windows.Forms.Padding(12);
            this.refreshInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.refreshInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshInterval.Name = "refreshInterval";
            this.refreshInterval.Size = new System.Drawing.Size(107, 20);
            this.refreshInterval.TabIndex = 9;
            this.refreshInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.refreshInterval.ValueChanged += new System.EventHandler(this.refreshInterval_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Refresh interval (sec):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Environment brightness:";
            // 
            // environmentValue
            // 
            this.environmentValue.AutoSize = true;
            this.environmentValue.Location = new System.Drawing.Point(203, 267);
            this.environmentValue.Margin = new System.Windows.Forms.Padding(12);
            this.environmentValue.Name = "environmentValue";
            this.environmentValue.Size = new System.Drawing.Size(33, 13);
            this.environmentValue.TabIndex = 11;
            this.environmentValue.Text = "100%";
            // 
            // envRefresh_btn
            // 
            this.envRefresh_btn.AutoSize = true;
            this.envRefresh_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.envRefresh_btn.Location = new System.Drawing.Point(12, 262);
            this.envRefresh_btn.Margin = new System.Windows.Forms.Padding(12);
            this.envRefresh_btn.Name = "envRefresh_btn";
            this.envRefresh_btn.Size = new System.Drawing.Size(49, 23);
            this.envRefresh_btn.TabIndex = 8;
            this.envRefresh_btn.Text = "refresh";
            this.envRefresh_btn.UseVisualStyleBackColor = true;
            this.envRefresh_btn.Click += new System.EventHandler(this.envRefresh_btn_Click);
            // 
            // possibleValues
            // 
            this.possibleValues.Location = new System.Drawing.Point(12, 312);
            this.possibleValues.Multiline = true;
            this.possibleValues.Name = "possibleValues";
            this.possibleValues.ReadOnly = true;
            this.possibleValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.possibleValues.Size = new System.Drawing.Size(224, 58);
            this.possibleValues.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Backlight steps for your display:";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(12, 427);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(12, 3, 3, 12);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(224, 23);
            this.reset_btn.TabIndex = 15;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "123";
            this.notifyIcon1.BalloonTipTitle = "HOI!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // cpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 471);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.possibleValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.environmentValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refreshInterval);
            this.Controls.Add(this.envRefresh_btn);
            this.Controls.Add(this.screenRefresh_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.srtStp_btn);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.brightnessOffset);
            this.Controls.Add(this.currentValue);
            this.MaximizeBox = false;
            this.Name = "cpl";
            this.Text = "ScreenBLC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cpl_FormClosing);
            this.Load += new System.EventHandler(this.cpl_Load);
            this.Resize += new System.EventHandler(this.cpl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessOffset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label currentValue;
        private System.Windows.Forms.NumericUpDown brightnessOffset;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button srtStp_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button screenRefresh_btn;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.NumericUpDown refreshInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label environmentValue;
        private System.Windows.Forms.Button envRefresh_btn;
        private System.Windows.Forms.TextBox possibleValues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

