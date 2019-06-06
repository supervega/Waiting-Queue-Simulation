namespace WindowsFormsApplication1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.NUDSimulateSpeed = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblServerUtilization = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblWaitAvg = new System.Windows.Forms.Label();
            this.LblDelayAvg = new System.Windows.Forms.Label();
            this.LblServiceRate = new System.Windows.Forms.Label();
            this.LblServiceAvg = new System.Windows.Forms.Label();
            this.LblArrival = new System.Windows.Forms.Label();
            this.LblInterarriavalavg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSimulate = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TXTDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.DrawPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSimulateSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DrawPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.40785F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.59214F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.DrawPanel, 2);
            this.DrawPanel.Controls.Add(this.LblTime);
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(3, 3);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(944, 451);
            this.DrawPanel.TabIndex = 0;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(8, 399);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(62, 20);
            this.LblTime.TabIndex = 9;
            this.LblTime.Text = "Time : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.NUDSimulateSpeed);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.BtnSimulate);
            this.panel2.Controls.Add(this.BtnBrowse);
            this.panel2.Controls.Add(this.TXTDirectory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 237);
            this.panel2.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(24, 105);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(65, 32);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(298, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "ms";
            // 
            // NUDSimulateSpeed
            // 
            this.NUDSimulateSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSimulateSpeed.Location = new System.Drawing.Point(172, 178);
            this.NUDSimulateSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDSimulateSpeed.Name = "NUDSimulateSpeed";
            this.NUDSimulateSpeed.Size = new System.Drawing.Size(120, 29);
            this.NUDSimulateSpeed.TabIndex = 6;
            this.NUDSimulateSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDSimulateSpeed.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDSimulateSpeed.ValueChanged += new System.EventHandler(this.NUDSimulateSpeed_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Simulate Speed :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblServerUtilization);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LblWaitAvg);
            this.groupBox1.Controls.Add(this.LblDelayAvg);
            this.groupBox1.Controls.Add(this.LblServiceRate);
            this.groupBox1.Controls.Add(this.LblServiceAvg);
            this.groupBox1.Controls.Add(this.LblArrival);
            this.groupBox1.Controls.Add(this.LblInterarriavalavg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(439, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // LblServerUtilization
            // 
            this.LblServerUtilization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblServerUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServerUtilization.Location = new System.Drawing.Point(190, 203);
            this.LblServerUtilization.Name = "LblServerUtilization";
            this.LblServerUtilization.Size = new System.Drawing.Size(188, 30);
            this.LblServerUtilization.TabIndex = 18;
            this.LblServerUtilization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Server Utilization :";
            // 
            // LblWaitAvg
            // 
            this.LblWaitAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblWaitAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWaitAvg.Location = new System.Drawing.Point(190, 173);
            this.LblWaitAvg.Name = "LblWaitAvg";
            this.LblWaitAvg.Size = new System.Drawing.Size(188, 30);
            this.LblWaitAvg.TabIndex = 16;
            this.LblWaitAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDelayAvg
            // 
            this.LblDelayAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDelayAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDelayAvg.Location = new System.Drawing.Point(190, 143);
            this.LblDelayAvg.Name = "LblDelayAvg";
            this.LblDelayAvg.Size = new System.Drawing.Size(188, 30);
            this.LblDelayAvg.TabIndex = 15;
            this.LblDelayAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblServiceRate
            // 
            this.LblServiceRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblServiceRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceRate.Location = new System.Drawing.Point(190, 113);
            this.LblServiceRate.Name = "LblServiceRate";
            this.LblServiceRate.Size = new System.Drawing.Size(188, 30);
            this.LblServiceRate.TabIndex = 14;
            this.LblServiceRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblServiceAvg
            // 
            this.LblServiceAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblServiceAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceAvg.Location = new System.Drawing.Point(190, 83);
            this.LblServiceAvg.Name = "LblServiceAvg";
            this.LblServiceAvg.Size = new System.Drawing.Size(188, 30);
            this.LblServiceAvg.TabIndex = 13;
            this.LblServiceAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblArrival
            // 
            this.LblArrival.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrival.Location = new System.Drawing.Point(190, 53);
            this.LblArrival.Name = "LblArrival";
            this.LblArrival.Size = new System.Drawing.Size(188, 30);
            this.LblArrival.TabIndex = 12;
            this.LblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInterarriavalavg
            // 
            this.LblInterarriavalavg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInterarriavalavg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInterarriavalavg.Location = new System.Drawing.Point(190, 23);
            this.LblInterarriavalavg.Name = "LblInterarriavalavg";
            this.LblInterarriavalavg.Size = new System.Drawing.Size(188, 30);
            this.LblInterarriavalavg.TabIndex = 11;
            this.LblInterarriavalavg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wait avg :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Delay Avg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Service avg :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Service rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrival avg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Interarrival avg:";
            // 
            // BtnSimulate
            // 
            this.BtnSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimulate.Location = new System.Drawing.Point(186, 94);
            this.BtnSimulate.Name = "BtnSimulate";
            this.BtnSimulate.Size = new System.Drawing.Size(117, 43);
            this.BtnSimulate.TabIndex = 3;
            this.BtnSimulate.Text = "Simulate";
            this.BtnSimulate.UseVisualStyleBackColor = true;
            this.BtnSimulate.Click += new System.EventHandler(this.BtnSimulate_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(363, 24);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(58, 32);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TXTDirectory
            // 
            this.TXTDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDirectory.Location = new System.Drawing.Point(171, 27);
            this.TXTDirectory.Name = "TXTDirectory";
            this.TXTDirectory.Size = new System.Drawing.Size(199, 26);
            this.TXTDirectory.TabIndex = 1;
            this.TXTDirectory.Text = "C:\\Users\\yasser\\Desktop\\data.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Directory :";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Waiting Queue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.DrawPanel.ResumeLayout(false);
            this.DrawPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSimulateSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TXTDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSimulate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblWaitAvg;
        private System.Windows.Forms.Label LblDelayAvg;
        private System.Windows.Forms.Label LblServiceRate;
        private System.Windows.Forms.Label LblServiceAvg;
        private System.Windows.Forms.Label LblArrival;
        private System.Windows.Forms.Label LblInterarriavalavg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDSimulateSpeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblServerUtilization;
        private System.Windows.Forms.Label label9;
    }
}

