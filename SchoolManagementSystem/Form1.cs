using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            SqlCommand cmd = new SqlCommand("SELECT Username, Password from LoginTable WHERE Username='" + username + "' AND Password='" + password + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {   
                MessageBox.Show("Login Successful!");
                Main main = new Main();
                main.Show();
                
                // Proceed to the next form or functionality
                // For example, you can open a new form here
                // new MainForm().Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
            con.Close();
        }
    }
}
