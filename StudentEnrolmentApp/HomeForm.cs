using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnrolmentApp
{
    public partial class HomeForm : Form
    {
        public string UserRole { get; set; }
        public HomeForm()
        {
            
        }

        public HomeForm(string userRole)
        {
            UserRole = userRole;
            InitializeComponent();
            if (UserRole == "Admin" || UserRole == "Operator")
            {
                userToolStripMenu.Visible = true;
                addStudentToolStripMenuItem.Enabled = true;
                addCourseToolStripMenuItem.Enabled = true;
            }
            if (UserRole == "Admin")
            {
                addUserToolStripMenuItem.Enabled = true;
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRecordForm studentRecordForm = new StudentRecordForm();
            studentRecordForm.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRecordForm courseRecordForm = new CourseRecordForm();
            courseRecordForm.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRecordForm userRecordForm = new UserRecordForm();
            userRecordForm.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }
    }
}
