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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentDBEntities1 db = new StudentDBEntities1();
            Student student = new Student();

            try
            {
                student.Student_Name = txtBoxFirstName.Text + " " + txtBoxMiddleName.Text + " " + txtBoxLastName.Text;
                var isMaleChecked = radioButtonMale.Checked;
                var isFemaleChecked = radioButtonFemale.Checked;
                if (isMaleChecked)
                {
                    student.Student_Gender = radioButtonMale.Text;
                }
                if (isFemaleChecked)
                {
                    student.Student_Gender = radioButtonFemale.Text;
                }
                if(!isMaleChecked && !isFemaleChecked)
                {
                    throw new InvalidOperationException();
                }

                student.Student_DOB = dateTimePickerDOB.Value;
                if (!string.IsNullOrEmpty(txtBoxAge.Text))
                {
                    student.Student_Age = Convert.ToInt32(txtBoxAge.Text);
                }
                student.Student_Course = comboBoxCourses.SelectedValue.ToString();
                student.Student_EmailID = txtBoxEmailID.Text;

                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("Student Added successfully");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Please select Gender");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCourses_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCourses.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderAddStudentForm.SetError(comboBoxCourses, "Please select course");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddStudentForm.SetError(comboBoxCourses,null);
            }
        
        }

        private void txtBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxFirstName.Text))
            {
                e.Cancel = true;
                errorProviderAddStudentForm.SetError(txtBoxFirstName, "Please enter first name");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddStudentForm.SetError(txtBoxFirstName, null);
            }
        }

        private void txtBoxMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxMiddleName.Text))
            {
                e.Cancel = true;
                errorProviderAddStudentForm.SetError(txtBoxMiddleName, "Please enter middle name");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddStudentForm.SetError(txtBoxMiddleName, null);
            }
        }

        private void txtBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxLastName.Text))
            {
                e.Cancel = true;
                errorProviderAddStudentForm.SetError(txtBoxLastName, "Please enter last name");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddStudentForm.SetError(txtBoxLastName, null);
            }
        }

        private void txtBoxAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxAge.Text))
            {
                e.Cancel = true;
                errorProviderAddStudentForm.SetError(txtBoxAge, "Please enter Age");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddStudentForm.SetError(txtBoxAge, null);
            }
        }

        private void txtBoxEmailID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxEmailID.Text))
            {
                e.Cancel = true;
                errorProviderAddStudentForm.SetError(txtBoxEmailID, "Please enter Email");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddStudentForm.SetError(txtBoxEmailID, null);
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet1CourseComboBox.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentDBDataSet1CourseComboBox.Course);
            // TODO: This line of code loads data into the 'studentDBDataSetCourseComboBox.Course' table. You can move, or remove it, as needed.
        }
    }
}
