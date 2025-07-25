namespace Maturan
{
    partial class Student
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
            lblstudentuser = new Label();
            SuspendLayout();
            // 
            // lblstudentuser
            // 
            lblstudentuser.AutoSize = true;
            lblstudentuser.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstudentuser.Location = new Point(245, 175);
            lblstudentuser.Name = "lblstudentuser";
            lblstudentuser.Size = new Size(249, 40);
            lblstudentuser.TabIndex = 0;
            lblstudentuser.Text = "Welcome Student!";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblstudentuser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentuser;
    }
}