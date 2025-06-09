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
    public partial class Enrollement : Form
    {
        public Enrollement()
        {
            InitializeComponent();
        }

        private void EnrollementTable_Render()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM EnrollementTable", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void Enrollement_Load(object sender, EventArgs e)
        { 
            EnrollementTable_Render();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO EnrollementTable VALUES(@enrollementid, @studentid, @section, @enrolldate)", con);
            cmd.Parameters.AddWithValue("@EnrollementId", int.Parse(EnrollementIdtextBox.Text));
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(StudentIdBox.Text));
            cmd.Parameters.AddWithValue("@Section", SectionNametextBox.Text);
            cmd.Parameters.AddWithValue("@EnrollDate", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            con.Close();

            EnrollementTable_Render();

            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE EnrollementTable SET studentid=@studentid, section=@section, enrolldate=@enrolldate WHERE enrollementid=@enrollementid", con);
            cmd.Parameters.AddWithValue("@EnrollementId", int.Parse(EnrollementIdtextBox.Text));
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(StudentIdBox.Text));
            cmd.Parameters.AddWithValue("@Section", SectionNametextBox.Text);
            cmd.Parameters.AddWithValue("@EnrollDate", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            con.Close();

            EnrollementTable_Render();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE EnrollementTable WHERE enrollementid=@enrollementid", con);
            cmd.Parameters.AddWithValue("@EnrollementId", int.Parse(EnrollementIdtextBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            EnrollementTable_Render();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            EnrollementIdtextBox.Clear();
            StudentIdBox.Clear();
            SectionNametextBox.Clear();
            dateTimePicker1.ResetText();
        }
    }
}
