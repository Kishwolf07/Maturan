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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1_;
            pictureBox2.Location = new Point(247, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download__2_;
            pictureBox3.Location = new Point(499, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(211, 194);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.download__1_;
            pictureBox4.Location = new Point(247, 246);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(218, 173);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images;
            pictureBox5.Location = new Point(499, 246);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(211, 173);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}