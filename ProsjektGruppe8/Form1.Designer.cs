﻿namespace ProsjektGruppe8
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
            this.txtBatteryStatus = new System.Windows.Forms.TextBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.dgvActiveAlarms = new System.Windows.Forms.DataGridView();
            this.cboComPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowChart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSubscriber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteSubscriber = new System.Windows.Forms.ToolStripMenuItem();
            this.instillingerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReadInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrLog = new System.Windows.Forms.Timer(this.components);
            this.btnAcknowlege = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveAlarms)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBatteryStatus
            // 
            this.txtBatteryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatteryStatus.Location = new System.Drawing.Point(627, 479);
            this.txtBatteryStatus.MaximumSize = new System.Drawing.Size(195, 20);
            this.txtBatteryStatus.Name = "txtBatteryStatus";
            this.txtBatteryStatus.ReadOnly = true;
            this.txtBatteryStatus.Size = new System.Drawing.Size(195, 20);
            this.txtBatteryStatus.TabIndex = 0;
            this.txtBatteryStatus.TabStop = false;
            this.txtBatteryStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // dgvActiveAlarms
            // 
            this.dgvActiveAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActiveAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveAlarms.Location = new System.Drawing.Point(12, 41);
            this.dgvActiveAlarms.Name = "dgvActiveAlarms";
            this.dgvActiveAlarms.ReadOnly = true;
            this.dgvActiveAlarms.Size = new System.Drawing.Size(810, 210);
            this.dgvActiveAlarms.TabIndex = 1;
            // 
            // cboComPorts
            // 
            this.cboComPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComPorts.FormattingEnabled = true;
            this.cboComPorts.Location = new System.Drawing.Point(620, 257);
            this.cboComPorts.Name = "cboComPorts";
            this.cboComPorts.Size = new System.Drawing.Size(121, 21);
            this.cboComPorts.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(747, 257);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Koble Til";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(242, 306);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.instillingerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSendLog,
            this.tsmShowChart,
            this.tsmAddSubscriber,
            this.tsmDeleteSubscriber});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmSendLog
            // 
            this.tsmSendLog.Name = "tsmSendLog";
            this.tsmSendLog.Size = new System.Drawing.Size(169, 22);
            this.tsmSendLog.Text = "Send Log";
            // 
            // tsmShowChart
            // 
            this.tsmShowChart.Name = "tsmShowChart";
            this.tsmShowChart.Size = new System.Drawing.Size(169, 22);
            this.tsmShowChart.Text = "Vis Chart";
            this.tsmShowChart.Click += new System.EventHandler(this.tsmShowChart_Click);
            // 
            // tsmAddSubscriber
            // 
            this.tsmAddSubscriber.Name = "tsmAddSubscriber";
            this.tsmAddSubscriber.Size = new System.Drawing.Size(169, 22);
            this.tsmAddSubscriber.Text = "Legg til Abbonent";
            this.tsmAddSubscriber.Click += new System.EventHandler(this.tsmAddSubscriber_Click);
            // 
            // tsmDeleteSubscriber
            // 
            this.tsmDeleteSubscriber.Name = "tsmDeleteSubscriber";
            this.tsmDeleteSubscriber.Size = new System.Drawing.Size(169, 22);
            this.tsmDeleteSubscriber.Text = "Slett Abbonent";
            this.tsmDeleteSubscriber.Click += new System.EventHandler(this.tsmDeleteSubscriber_Click);
            // 
            // instillingerToolStripMenuItem
            // 
            this.instillingerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReadInterval,
            this.tsmLogInterval});
            this.instillingerToolStripMenuItem.Name = "instillingerToolStripMenuItem";
            this.instillingerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.instillingerToolStripMenuItem.Text = "Instillinger";
            // 
            // tsmReadInterval
            // 
            this.tsmReadInterval.Name = "tsmReadInterval";
            this.tsmReadInterval.Size = new System.Drawing.Size(149, 22);
            this.tsmReadInterval.Text = "Leseintervall";
            this.tsmReadInterval.Click += new System.EventHandler(this.leseintervallToolStripMenuItem_Click);
            // 
            // tsmLogInterval
            // 
            this.tsmLogInterval.Name = "tsmLogInterval";
            this.tsmLogInterval.Size = new System.Drawing.Size(149, 22);
            this.tsmLogInterval.Text = "Loggeintervall";
            this.tsmLogInterval.Click += new System.EventHandler(this.tsmLogInterval_Click);
            // 
            // tmrLog
            // 
            this.tmrLog.Interval = 3600000;
            this.tmrLog.Tick += new System.EventHandler(this.tmrLog_Tick);
            // 
            // btnAcknowlege
            // 
            this.btnAcknowlege.Location = new System.Drawing.Point(12, 255);
            this.btnAcknowlege.Name = "btnAcknowlege";
            this.btnAcknowlege.Size = new System.Drawing.Size(113, 23);
            this.btnAcknowlege.TabIndex = 6;
            this.btnAcknowlege.Text = "Kvitter Alarmer";
            this.btnAcknowlege.UseVisualStyleBackColor = true;
            this.btnAcknowlege.Click += new System.EventHandler(this.btnAcknowlege_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 306);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 170);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAcknowlege);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboComPorts);
            this.Controls.Add(this.dgvActiveAlarms);
            this.Controls.Add(this.txtBatteryStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(370, 405);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveAlarms)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBatteryStatus;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.DataGridView dgvActiveAlarms;
        private System.Windows.Forms.ComboBox cboComPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSendLog;
        private System.Windows.Forms.ToolStripMenuItem instillingerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmReadInterval;
        private System.Windows.Forms.ToolStripMenuItem tsmLogInterval;
        private System.Windows.Forms.Timer tmrLog;
        private System.Windows.Forms.ToolStripMenuItem tsmShowChart;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSubscriber;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteSubscriber;
        private System.Windows.Forms.Button btnAcknowlege;
        private System.Windows.Forms.TextBox textBox1;
    }
}

