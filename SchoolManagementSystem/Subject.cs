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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void SubjectTable_Render()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM SubjectTable", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO SubjectTable VALUES(@subjectid, @subjectname)", con);
            cmd.Parameters.AddWithValue("@SubjectId", int.Parse(SubjectIdtextBox.Text));
            cmd.Parameters.AddWithValue("@SubjectName", SubjectNametextBox.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();

            SubjectTable_Render();

            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE SubjectTable SET subjectname=@subjectname WHERE subjectid=@subjectid", con);
            cmd.Parameters.AddWithValue("@SubjectId", int.Parse(SubjectIdtextBox.Text));
            cmd.Parameters.AddWithValue("@SubjectName", SubjectNametextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            SubjectTable_Render();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE SubjectTable WHERE subjectid=@subjectid", con);
            cmd.Parameters.AddWithValue("@SubjectId", int.Parse(SubjectIdtextBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            SubjectTable_Render();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SubjectIdtextBox.Clear();
            SubjectNametextBox.Clear();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            SubjectTable_Render();
        }
    }
}
