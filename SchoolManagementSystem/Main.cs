using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.Show();
        }

        private void SubjectBtn_Click(object sender, EventArgs e)
        {
            Subject subjectForm = new Subject();
            subjectForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacherForm = new Teacher();
            teacherForm.Show();
        }

        private void SectionBtn_Click(object sender, EventArgs e)
        {
            Section sectionForm = new Section();
            sectionForm.Show();
        }

        private void EnrollmentBtn_Click(object sender, EventArgs e)
        {
            Enrollement enrollementForm = new Enrollement();
            enrollementForm.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }
    }
}
