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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void txtBoxCourseName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxCourseName.Text))
            {
                e.Cancel = true;
                errorProviderAddCourseForm.SetError(txtBoxCourseName, "Please enter course name");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddCourseForm.SetError(txtBoxCourseName, null);
            }
        }

        private void txtBoxCourseDuration_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxCourseDuration.Text))
            {
                e.Cancel = true;
                errorProviderAddCourseForm.SetError(txtBoxCourseDuration, "Please enter course duration");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddCourseForm.SetError(txtBoxCourseDuration, null);
            }
        }

        private void txtBoxCourseFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxCourseFees.Text))
            {
                e.Cancel = true;
                errorProviderAddCourseForm.SetError(txtBoxCourseFees, "Please enter course fees");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddCourseForm.SetError(txtBoxCourseFees, null);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            StudentDBEntities1 db = new StudentDBEntities1();

            Course course = new Course();

            try
            {
                course.Course_Name = txtBoxCourseName.Text;
                course.Course_Duration = txtBoxCourseDuration.Text;
                course.Course_Fees = Convert.ToInt32(txtBoxCourseFees.Text);

                db.Courses.Add(course);
                db.SaveChanges();
                MessageBox.Show("Course Added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
