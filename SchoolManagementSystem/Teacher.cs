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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void TeacherTable_Render()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TeacherTable", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            TeacherTable_Render();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO TeacherTable VALUES(@teacherid, @teachername, @gender, @phone)", con);
            cmd.Parameters.AddWithValue("@TeacherId", int.Parse(TeacherIdtextBox.Text));
            cmd.Parameters.AddWithValue("@TeacherName", TeacherNametextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", GendertextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", PhonetextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            TeacherTable_Render();

            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE TeacherTable SET teachername=@teachername, gender=@gender, phone=@phone WHERE teacherid=@teacherid", con);
            cmd.Parameters.AddWithValue("@TeacherId", int.Parse(TeacherIdtextBox.Text));
            cmd.Parameters.AddWithValue("@TeacherName", TeacherNametextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", GendertextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", PhonetextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TeacherTable_Render();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE TeacherTable WHERE teacherid=@teacherid", con);
            cmd.Parameters.AddWithValue("@TeacherId", int.Parse(TeacherIdtextBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            TeacherTable_Render();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TeacherIdtextBox.Clear();
            TeacherNametextBox.Clear();
            GendertextBox.Clear();
            PhonetextBox.Clear();
        }
    }
}
