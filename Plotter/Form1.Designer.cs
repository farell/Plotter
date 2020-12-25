namespace Plotter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDiplayTemp = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonExport2Sqlserver = new System.Windows.Forms.Button();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSqlserver = new System.Windows.Forms.RadioButton();
            this.radioButtonSqlite = new System.Windows.Forms.RadioButton();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxThirdFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxSecondFilter = new System.Windows.Forms.CheckBox();
            this.numericUpDownWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxSqlStatement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDiplayTemp);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxDatabase);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxPwd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBoxThirdFilter);
            this.groupBox1.Controls.Add(this.checkBoxFirstFilter);
            this.groupBox1.Controls.Add(this.checkBoxSecondFilter);
            this.groupBox1.Controls.Add(this.numericUpDownWindowSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonQuery);
            this.groupBox1.Controls.Add(this.textBoxSqlStatement);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1861, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // checkBoxDiplayTemp
            // 
            this.checkBoxDiplayTemp.AutoSize = true;
            this.checkBoxDiplayTemp.Location = new System.Drawing.Point(384, 118);
            this.checkBoxDiplayTemp.Name = "checkBoxDiplayTemp";
            this.checkBoxDiplayTemp.Size = new System.Drawing.Size(89, 19);
            this.checkBoxDiplayTemp.TabIndex = 21;
            this.checkBoxDiplayTemp.Text = "显示温度";
            this.checkBoxDiplayTemp.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonExport2Sqlserver);
            this.groupBox3.Controls.Add(this.textBoxTableName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.buttonExport);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxFileName);
            this.groupBox3.Location = new System.Drawing.Point(512, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 68);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据导出";
            // 
            // buttonExport2Sqlserver
            // 
            this.buttonExport2Sqlserver.Location = new System.Drawing.Point(200, 26);
            this.buttonExport2Sqlserver.Name = "buttonExport2Sqlserver";
            this.buttonExport2Sqlserver.Size = new System.Drawing.Size(137, 29);
            this.buttonExport2Sqlserver.TabIndex = 8;
            this.buttonExport2Sqlserver.Text = "导出到SQLServer";
            this.buttonExport2Sqlserver.UseVisualStyleBackColor = true;
            this.buttonExport2Sqlserver.Click += new System.EventHandler(this.buttonExport2Sqlserver_Click);
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(52, 28);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(138, 25);
            this.textBoxTableName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "表名：";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(578, 25);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(100, 29);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "导出到CSV";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "文件名：";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(429, 29);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(144, 25);
            this.textBoxFileName.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSqlserver);
            this.groupBox2.Controls.Add(this.radioButtonSqlite);
            this.groupBox2.Location = new System.Drawing.Point(888, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(254, 38);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库类型";
            // 
            // radioButtonSqlserver
            // 
            this.radioButtonSqlserver.AutoSize = true;
            this.radioButtonSqlserver.Checked = true;
            this.radioButtonSqlserver.Location = new System.Drawing.Point(128, 20);
            this.radioButtonSqlserver.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSqlserver.Name = "radioButtonSqlserver";
            this.radioButtonSqlserver.Size = new System.Drawing.Size(100, 19);
            this.radioButtonSqlserver.TabIndex = 1;
            this.radioButtonSqlserver.TabStop = true;
            this.radioButtonSqlserver.Text = "SqlServer";
            this.radioButtonSqlserver.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqlite
            // 
            this.radioButtonSqlite.AutoSize = true;
            this.radioButtonSqlite.Location = new System.Drawing.Point(13, 20);
            this.radioButtonSqlite.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSqlite.Name = "radioButtonSqlite";
            this.radioButtonSqlite.Size = new System.Drawing.Size(84, 19);
            this.radioButtonSqlite.TabIndex = 0;
            this.radioButtonSqlite.TabStop = true;
            this.radioButtonSqlite.Text = "Sqlite3";
            this.radioButtonSqlite.UseVisualStyleBackColor = true;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(725, 20);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(155, 25);
            this.textBoxDatabase.TabIndex = 17;
            this.textBoxDatabase.Text = "BridgeMonitoring";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "数据库：";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(465, 20);
            this.textBoxPwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(147, 25);
            this.textBoxPwd.TabIndex = 15;
            this.textBoxPwd.Text = "123456";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "密码：";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(265, 21);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(132, 25);
            this.textBoxUser.TabIndex = 13;
            this.textBoxUser.Text = "bridge_user";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "用户名：";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(76, 20);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(115, 25);
            this.textBoxIP.TabIndex = 11;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "IP地址：";
            // 
            // checkBoxThirdFilter
            // 
            this.checkBoxThirdFilter.AutoSize = true;
            this.checkBoxThirdFilter.Location = new System.Drawing.Point(232, 118);
            this.checkBoxThirdFilter.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxThirdFilter.Name = "checkBoxThirdFilter";
            this.checkBoxThirdFilter.Size = new System.Drawing.Size(89, 19);
            this.checkBoxThirdFilter.TabIndex = 8;
            this.checkBoxThirdFilter.Text = "三次滤波";
            this.checkBoxThirdFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxFirstFilter
            // 
            this.checkBoxFirstFilter.AutoSize = true;
            this.checkBoxFirstFilter.Location = new System.Drawing.Point(15, 118);
            this.checkBoxFirstFilter.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFirstFilter.Name = "checkBoxFirstFilter";
            this.checkBoxFirstFilter.Size = new System.Drawing.Size(89, 19);
            this.checkBoxFirstFilter.TabIndex = 8;
            this.checkBoxFirstFilter.Text = "一次滤波";
            this.checkBoxFirstFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxSecondFilter
            // 
            this.checkBoxSecondFilter.AutoSize = true;
            this.checkBoxSecondFilter.Location = new System.Drawing.Point(125, 118);
            this.checkBoxSecondFilter.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSecondFilter.Name = "checkBoxSecondFilter";
            this.checkBoxSecondFilter.Size = new System.Drawing.Size(89, 19);
            this.checkBoxSecondFilter.TabIndex = 8;
            this.checkBoxSecondFilter.Text = "二次滤波";
            this.checkBoxSecondFilter.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWindowSize
            // 
            this.numericUpDownWindowSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownWindowSize.Location = new System.Drawing.Point(136, 85);
            this.numericUpDownWindowSize.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWindowSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWindowSize.Name = "numericUpDownWindowSize";
            this.numericUpDownWindowSize.Size = new System.Drawing.Size(93, 25);
            this.numericUpDownWindowSize.TabIndex = 4;
            this.numericUpDownWindowSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWindowSize.ValueChanged += new System.EventHandler(this.numericUpDownWindowSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "窗口长度：";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(1150, 23);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(100, 29);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxSqlStatement
            // 
            this.textBoxSqlStatement.Location = new System.Drawing.Point(136, 55);
            this.textBoxSqlStatement.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSqlStatement.Name = "textBoxSqlStatement";
            this.textBoxSqlStatement.Size = new System.Drawing.Size(1575, 25);
            this.textBoxSqlStatement.TabIndex = 1;
            this.textBoxSqlStatement.Text = "select Stamp,Value from SettlementTilt where SensorId =\'5600001710014\' and Type =" +
    "\'010\'and Stamp between \'2018-06-20\' and \'2018-08-20\' order by stamp asc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Statement:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1861, 663);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1861, 812);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 812);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxSqlStatement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.NumericUpDown numericUpDownWindowSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSecondFilter;
        private System.Windows.Forms.CheckBox checkBoxThirdFilter;
        private System.Windows.Forms.CheckBox checkBoxFirstFilter;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSqlserver;
        private System.Windows.Forms.RadioButton radioButtonSqlite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonExport2Sqlserver;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxDiplayTemp;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

