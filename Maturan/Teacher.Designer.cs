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
            label1 = new Label();
            lblteacheruser = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 181);
            label1.Name = "label1";
            label1.Size = new Size(247, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome Teacher!";
            // 
            // lblteacheruser
            // 
            lblteacheruser.AutoSize = true;
            lblteacheruser.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblteacheruser.Location = new Point(389, 181);
            lblteacheruser.Name = "lblteacheruser";
            lblteacheruser.Size = new Size(94, 40);
            lblteacheruser.TabIndex = 2;
            lblteacheruser.Text = "label1";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblteacheruser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblteacheruser;
    }
}