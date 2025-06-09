using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void CountStudents()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentTable", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                SCountLabel.Text = Convert.ToString(count.ToString());
            }
            else
            {
                SCountLabel.Text = "0";
            }

            con.Close();
        }

        private void CountSubjects()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SubjectTable", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                SubjectCountLabel.Text = Convert.ToString(count.ToString());
            }
            else
            {
                SubjectCountLabel.Text = "0";
            }

            con.Close();
        }

        private void CountTeachers()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TeacherTable", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                TeachersCountLabel.Text = Convert.ToString(count.ToString());
            }
            else
            {
                TeachersCountLabel.Text = "0";
            }

            con.Close();
        }

        private void CountEnrollement()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EnrollementTable", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                EnrollementCountLabel.Text = Convert.ToString(count.ToString());
            }
            else
            {
                EnrollementCountLabel.Text = "0";
            }

            con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudents();
            CountSubjects();
            CountTeachers();
            CountEnrollement();
        }
    }
}
