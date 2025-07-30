namespace Maturan
{
    partial class Teacher
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnlogout = new Button();
            btnreport = new Button();
            btnlogs = new Button();
            btnsubject = new Button();
            btnteacher = new Button();
            btnstudent = new Button();
            btndashboard = new Button();
            pictureBox1 = new PictureBox();
            lbladminuser = new Label();
            lblAdmin = new Label();
            pictureBox2 = new PictureBox();
            txtsearch = new TextBox();
            btnupdate = new Button();
            btndelete = new Button();
            btnadd = new Button();
            teacherid = new DataGridViewTextBoxColumn();
            Tfname = new DataGridViewTextBoxColumn();
            TLname = new DataGridViewTextBoxColumn();
            Hdate = new DataGridViewTextBoxColumn();
            depart = new DataGridViewTextBoxColumn();
            Semail = new DataGridViewTextBoxColumn();
            Sphone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            special = new DataGridViewTextBoxColumn();
            Tstatus = new DataGridViewTextBoxColumn();
            Trole_id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { teacherid, Tfname, TLname, Hdate, depart, Semail, Sphone, address, special, Tstatus, Trole_id });
            dataGridView1.Location = new Point(193, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(585, 330);
            dataGridView1.TabIndex = 6;
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
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 447);
            panel1.TabIndex = 5;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download;
            pictureBox2.Location = new Point(610, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.ForeColor = Color.Silver;
            txtsearch.Location = new Point(644, 36);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(134, 23);
            txtsearch.TabIndex = 18;
            txtsearch.Text = "Search";
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Verdana", 9.75F);
            btnupdate.Location = new Point(560, 405);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(102, 37);
            btnupdate.TabIndex = 17;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Verdana", 9.75F);
            btndelete.Location = new Point(440, 405);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(102, 37);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Verdana", 9.75F);
            btnadd.Location = new Point(315, 405);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(102, 37);
            btnadd.TabIndex = 15;
            btnadd.Text = "Add New";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // teacherid
            // 
            teacherid.HeaderText = "Teacher_id";
            teacherid.Name = "teacherid";
            teacherid.ReadOnly = true;
            // 
            // Tfname
            // 
            Tfname.HeaderText = "first_name";
            Tfname.Name = "Tfname";
            Tfname.ReadOnly = true;
            // 
            // TLname
            // 
            TLname.HeaderText = "Last_name";
            TLname.Name = "TLname";
            TLname.ReadOnly = true;
            // 
            // Hdate
            // 
            Hdate.HeaderText = "Hire Date";
            Hdate.Name = "Hdate";
            // 
            // depart
            // 
            depart.HeaderText = "Department";
            depart.Name = "depart";
            // 
            // Semail
            // 
            Semail.HeaderText = "Email";
            Semail.Name = "Semail";
            // 
            // Sphone
            // 
            Sphone.HeaderText = "Phone";
            Sphone.Name = "Sphone";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.Name = "address";
            // 
            // special
            // 
            special.HeaderText = "Specialization";
            special.Name = "special";
            // 
            // Tstatus
            // 
            Tstatus.HeaderText = "Status";
            Tstatus.Name = "Tstatus";
            // 
            // Trole_id
            // 
            Trole_id.HeaderText = "Role_Id";
            Trole_id.Name = "Trole_id";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(txtsearch);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnlogout;
        private Button btnreport;
        private Button btnlogs;
        private Button btnsubject;
        private Button btnteacher;
        private Button btnstudent;
        private Button btndashboard;
        private PictureBox pictureBox1;
        private Label lbladminuser;
        private Label lblAdmin;
        private PictureBox pictureBox2;
        private TextBox txtsearch;
        private Button btnupdate;
        private Button btndelete;
        private Button btnadd;
        private DataGridViewTextBoxColumn teacherid;
        private DataGridViewTextBoxColumn Tfname;
        private DataGridViewTextBoxColumn TLname;
        private DataGridViewTextBoxColumn Hdate;
        private DataGridViewTextBoxColumn depart;
        private DataGridViewTextBoxColumn Semail;
        private DataGridViewTextBoxColumn Sphone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn special;
        private DataGridViewTextBoxColumn Tstatus;
        private DataGridViewTextBoxColumn Trole_id;
    }
}