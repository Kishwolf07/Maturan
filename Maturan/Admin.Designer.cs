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
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(204, 170);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(265, 45);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Welcome Admin!";
            // 
            // lbladminuser
            // 
            lbladminuser.AutoSize = true;
            lbladminuser.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbladminuser.Location = new Point(475, 174);
            lbladminuser.Name = "lbladminuser";
            lbladminuser.Size = new Size(94, 40);
            lbladminuser.TabIndex = 1;
            lbladminuser.Text = "label1";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbladminuser);
            Controls.Add(lblAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private Label lbladminuser;
    }
}