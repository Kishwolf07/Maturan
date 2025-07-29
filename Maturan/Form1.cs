using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace Maturan
{
    public partial class Form1 : Form
    {
        static string connection = "Data Source=LAB4-PC24\\LAB3PC36;Initial Catalog=SIS;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            txtPass.UseSystemPasswordChar = true;


            using (SqlConnection conn = new SqlConnection(connection))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT role_id FROM user_login WHERE username = @user AND password  = @pass";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int roleId = Convert.ToInt32(result);
                        string passdata = user;
                        switch (roleId)
                        {
                            case 1:
                              // MessageBox.Show($"1  Welcome {user}!");
                               Admin adminform = new Admin(passdata);
                               adminform.Show();
                                break;
                            case 2:
                                //MessageBox.Show("2  Welcome Student!");
                                Student studentform = new Student();
                                studentform.Show();
                                break;
                            case 3:
                                // MessageBox.Show("3  Welcome Teacher!");
                               Teacher Teacherform = new Teacher();
                                Teacherform.Show();
                                break;
                            default:
                                MessageBox.Show("Unknown User");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message);


                }
            }


            //pachuyhuy ranis textboxes nako po
            txtUser.Text = "Username";
            txtUser.ForeColor = Color.Gray;

            txtPass.Text = "Password";
            txtPass.ForeColor = Color.Gray;
            txtPass.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Username";
            txtUser.ForeColor = Color.Gray;

            txtPass.Text = "Password";
            txtPass.ForeColor = Color.Gray;
            txtPass.UseSystemPasswordChar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
