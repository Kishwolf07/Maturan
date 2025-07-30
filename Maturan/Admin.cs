using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maturan
{
    public partial class Admin : Form
    {

        public Admin(string getdata)
        {
            InitializeComponent();
            lbladminuser.Text = getdata;

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            //Student studentform = new Student();
            //studentform.Show();
            //this.Hide();
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            //Teacher Teacherform = new Teacher();
            //Teacherform.Show();
            //this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            //Admin adminform = new Admin();
            //adminform.Show();
        }
    }
}
