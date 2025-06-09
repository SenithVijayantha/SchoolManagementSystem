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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void Section_Load(object sender, EventArgs e)
        {
            SectionTable_Render();
        }

        private void SectionTable_Render()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM SectionTable", con);
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

            SqlCommand cmd = new SqlCommand("INSERT INTO SectionTable VALUES(@sectionid, @studentid, @section)", con);
            cmd.Parameters.AddWithValue("@SectionId", int.Parse(SectionIdtextBox.Text));
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(StudentIdBox.Text));
            cmd.Parameters.AddWithValue("@Section", SectionNametextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            SectionTable_Render();

            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE SectionTable SET studentid=@studentid, section=@section WHERE sectionid=@sectionid", con);
            cmd.Parameters.AddWithValue("@SectionId", int.Parse(SectionIdtextBox.Text));
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(StudentIdBox.Text));
            cmd.Parameters.AddWithValue("@Section", SectionNametextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            SectionTable_Render();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE SectionTable WHERE sectionid=@sectionid", con);
            cmd.Parameters.AddWithValue("@SectionId", int.Parse(SectionIdtextBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            SectionTable_Render();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SectionIdtextBox.Clear();
            StudentIdBox.Clear();
            SectionNametextBox.Clear();
        }
    }
}
