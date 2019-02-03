namespace ITVDN_HW_AppDomain_and_Services
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RTBFilePath = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtRun = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.LBOption = new System.Windows.Forms.ListBox();
            this.LBArg = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtSetOpt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBAddFlg = new System.Windows.Forms.ListBox();
            this.TBRefInfo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the assembly path: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RTBFilePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // RTBFilePath
            // 
            this.RTBFilePath.Location = new System.Drawing.Point(47, 40);
            this.RTBFilePath.Name = "RTBFilePath";
            this.RTBFilePath.ReadOnly = true;
            this.RTBFilePath.Size = new System.Drawing.Size(177, 54);
            this.RTBFilePath.TabIndex = 3;
            this.RTBFilePath.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lock options: ";
            // 
            // BtRun
            // 
            this.BtRun.Enabled = false;
            this.BtRun.Location = new System.Drawing.Point(557, 233);
            this.BtRun.Name = "BtRun";
            this.BtRun.Size = new System.Drawing.Size(75, 23);
            this.BtRun.TabIndex = 5;
            this.BtRun.Text = "Run";
            this.BtRun.UseVisualStyleBackColor = true;
            this.BtRun.Click += new System.EventHandler(this.BtRun_Click);
            // 
            // BtStop
            // 
            this.BtStop.Enabled = false;
            this.BtStop.Location = new System.Drawing.Point(638, 233);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(75, 23);
            this.BtStop.TabIndex = 6;
            this.BtStop.Text = "Stop";
            this.BtStop.UseVisualStyleBackColor = true;
            // 
            // LBOption
            // 
            this.LBOption.FormattingEnabled = true;
            this.LBOption.Items.AddRange(new object[] {
            "SecurityPermission ->",
            "FileIOPermission ->",
            "ReflectionPermission ->"});
            this.LBOption.Location = new System.Drawing.Point(11, 132);
            this.LBOption.Name = "LBOption";
            this.LBOption.Size = new System.Drawing.Size(232, 95);
            this.LBOption.TabIndex = 7;
            this.LBOption.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // LBArg
            // 
            this.LBArg.FormattingEnabled = true;
            this.LBArg.Location = new System.Drawing.Point(252, 135);
            this.LBArg.Name = "LBArg";
            this.LBArg.Size = new System.Drawing.Size(240, 95);
            this.LBArg.TabIndex = 8;
            this.LBArg.SelectedIndexChanged += new System.EventHandler(this.LBArg_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Argument to option: ";
            // 
            // BtSetOpt
            // 
            this.BtSetOpt.Enabled = false;
            this.BtSetOpt.Location = new System.Drawing.Point(11, 233);
            this.BtSetOpt.Name = "BtSetOpt";
            this.BtSetOpt.Size = new System.Drawing.Size(75, 23);
            this.BtSetOpt.TabIndex = 10;
            this.BtSetOpt.Text = "Set option";
            this.BtSetOpt.UseVisualStyleBackColor = true;
            this.BtSetOpt.Click += new System.EventHandler(this.BtSetOpt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Added Options";
            // 
            // LBAddFlg
            // 
            this.LBAddFlg.FormattingEnabled = true;
            this.LBAddFlg.Location = new System.Drawing.Point(249, 17);
            this.LBAddFlg.Name = "LBAddFlg";
            this.LBAddFlg.Size = new System.Drawing.Size(240, 95);
            this.LBAddFlg.TabIndex = 13;
            // 
            // TBRefInfo
            // 
            this.TBRefInfo.Location = new System.Drawing.Point(496, 17);
            this.TBRefInfo.Multiline = true;
            this.TBRefInfo.Name = "TBRefInfo";
            this.TBRefInfo.Size = new System.Drawing.Size(217, 210);
            this.TBRefInfo.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBRefInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBAddFlg);
            this.Controls.Add(this.BtSetOpt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBArg);
            this.Controls.Add(this.LBOption);
            this.Controls.Add(this.BtStop);
            this.Controls.Add(this.BtRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Safe executer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTBFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtRun;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.ListBox LBOption;
        private System.Windows.Forms.ListBox LBArg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtSetOpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LBAddFlg;
        private System.Windows.Forms.TextBox TBRefInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

