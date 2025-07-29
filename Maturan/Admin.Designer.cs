namespace Maturan
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblAdmin = new Label();
            lbladminuser = new Label();
            panel1 = new Panel();
            btnlogout = new Button();
            btnreport = new Button();
            btnlogs = new Button();
            btnsubject = new Button();
            btnteacher = new Button();
            btnstudent = new Button();
            btndashboard = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(25, 82);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(57, 15);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Welcome";
            // 
            // lbladminuser
            // 
            lbladminuser.AutoSize = true;
            lbladminuser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbladminuser.Location = new Point(79, 82);
            lbladminuser.Name = "lbladminuser";
            lbladminuser.Size = new Size(53, 15);
            lbladminuser.TabIndex = 1;
            lbladminuser.Text = "<name>";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnreport);
            panel1.Controls.Add(btnlogs);
            panel1.Controls.Add(btnsubject);
            panel1.Controls.Add(btnteacher);
            panel1.Controls.Add(btnstudent);
            panel1.Controls.Add(btndashboard);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbladminuser);
            panel1.Controls.Add(lblAdmin);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 447);
            panel1.TabIndex = 2;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Verdana", 9.75F);
            btnlogout.Location = new Point(25, 400);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(102, 37);
            btnlogout.TabIndex = 9;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnreport
            // 
            btnreport.Font = new Font("Verdana", 9.75F);
            btnreport.Location = new Point(25, 344);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(102, 37);
            btnreport.TabIndex = 8;
            btnreport.Text = "Report";
            btnreport.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            btnlogs.Font = new Font("Verdana", 9.75F);
            btnlogs.Location = new Point(25, 301);
            btnlogs.Name = "btnlogs";
            btnlogs.Size = new Size(102, 37);
            btnlogs.TabIndex = 7;
            btnlogs.Text = "Logs";
            btnlogs.UseVisualStyleBackColor = true;
            // 
            // btnsubject
            // 
            btnsubject.Font = new Font("Verdana", 9.75F);
            btnsubject.Location = new Point(25, 258);
            btnsubject.Name = "btnsubject";
            btnsubject.Size = new Size(102, 37);
            btnsubject.TabIndex = 6;
            btnsubject.Text = "Subject";
            btnsubject.UseVisualStyleBackColor = true;
            // 
            // btnteacher
            // 
            btnteacher.Font = new Font("Verdana", 9.75F);
            btnteacher.Location = new Point(25, 215);
            btnteacher.Name = "btnteacher";
            btnteacher.Size = new Size(102, 37);
            btnteacher.TabIndex = 5;
            btnteacher.Text = "Teacher";
            btnteacher.UseVisualStyleBackColor = true;
            // 
            // btnstudent
            // 
            btnstudent.Font = new Font("Verdana", 9.75F);
            btnstudent.Location = new Point(25, 172);
            btnstudent.Name = "btnstudent";
            btnstudent.Size = new Size(102, 37);
            btnstudent.TabIndex = 4;
            btnstudent.Text = "Student";
            btnstudent.UseVisualStyleBackColor = true;
            // 
            // btndashboard
            // 
            btndashboard.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndashboard.Location = new Point(25, 118);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(102, 37);
            btndashboard.TabIndex = 3;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admin;
            pictureBox1.Location = new Point(25, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(520, 245);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(192, 171);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(264, 39);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(200, 181);
            chart2.TabIndex = 11;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(264, 245);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(200, 171);
            chart3.TabIndex = 12;
            chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart4.Legends.Add(legend4);
            chart4.Location = new Point(520, 39);
            chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart4.Series.Add(series4);
            chart4.Size = new Size(192, 171);
            chart4.TabIndex = 13;
            chart4.Text = "chart4";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart4);
            Controls.Add(chart3);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdmin;
        private Label lbladminuser;
        private Panel panel1;
        private Button btndashboard;
        private PictureBox pictureBox1;
        private Button btnlogs;
        private Button btnsubject;
        private Button btnteacher;
        private Button btnstudent;
        private Button btnreport;
        private Button btnlogout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}