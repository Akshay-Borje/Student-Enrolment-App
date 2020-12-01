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
    public partial class CourseRecordForm : Form
    {
        public CourseRecordForm()
        {
            InitializeComponent();
        }

        private void CourseRecordForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSetCourse.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentDBDataSetCourse.Course);
        }

        private void saveCourseDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDBEntities1 db = new StudentDBEntities1();
                int id = Convert.ToInt32(dataGridViewCourseRecord.CurrentRow.Cells[0].Value);
                var courseRecord = db.Courses.First(x => x.Course_ID == id);
                courseRecord.Course_Name = dataGridViewCourseRecord.CurrentRow.Cells[1].Value.ToString();
                courseRecord.Course_Duration = dataGridViewCourseRecord.CurrentRow.Cells[2].Value.ToString();
                courseRecord.Course_Fees = Convert.ToDecimal(dataGridViewCourseRecord.CurrentRow.Cells[3].Value.ToString());
                db.SaveChanges();
                MessageBox.Show("Course Updated Successfully");
                saveCourseDataGrid.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteCourseDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmDelete = MessageBox.Show("Do you want to delete this course", "Confirm Dialog", MessageBoxButtons.YesNo);
                if (confirmDelete.ToString() == "Yes")
                {
                    StudentDBEntities1 db = new StudentDBEntities1();
                    int id = Convert.ToInt32(dataGridViewCourseRecord.CurrentRow.Cells[0].Value);
                    var courseRecord = db.Courses.First(x => x.Course_ID == id);
                    db.Courses.Remove(courseRecord);
                    db.SaveChanges();
                    dataGridViewCourseRecord.Rows.Remove(dataGridViewCourseRecord.CurrentRow);
                    MessageBox.Show("Course Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewCourseRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCourseRecord.CurrentRow.Selected)
            {
                deleteCourseDataGrid.Enabled = true;
            }
            else
            {
                deleteCourseDataGrid.Enabled = false;
            }
        }

        private void dataGridViewCourseRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            saveCourseDataGrid.Enabled = true;
        }
    }
}
