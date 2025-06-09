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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void StudentTable_Render()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
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
           
            SqlCommand cmd = new SqlCommand("INSERT INTO StudentTable VALUES(@studentid, @studentname, @dob, @gender, @phone, @email)", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(SIdtextBox.Text));
            cmd.Parameters.AddWithValue("@StudentName", SNametextBox.Text);
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", GendertextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", PhonetextBox.Text);
            cmd.Parameters.AddWithValue("@Email", EmailtextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            StudentTable_Render();

            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Student_Load(object sender, EventArgs e)
        {
            StudentTable_Render();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE StudentTable SET studentname=@studentname, dob=@dob, gender=@gender, phone=@phone, email=@email WHERE studentid=@studentid", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(SIdtextBox.Text));
            cmd.Parameters.AddWithValue("@StudentName", SNametextBox.Text);
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", GendertextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", PhonetextBox.Text);
            cmd.Parameters.AddWithValue("@Email", EmailtextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            StudentTable_Render();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE StudentTable WHERE studentid=@studentid", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(SIdtextBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            StudentTable_Render();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SIdtextBox.ResetText();
            SNametextBox.ResetText();
            dateTimePicker1.ResetText();
            GendertextBox.ResetText();
            PhonetextBox.ResetText();
            EmailtextBox.ResetText();
        }
    }
}
