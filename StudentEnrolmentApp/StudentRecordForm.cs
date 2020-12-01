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
    public partial class StudentRecordForm : Form
    {
        public StudentRecordForm()
        {
            InitializeComponent();
        }

        private void StudentRecordForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDBDataSet.Student);

        }

        private void saveBtnStudentDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDBEntities1 db = new StudentDBEntities1();
                int id = Convert.ToInt32(dataGridViewStudentRecord.CurrentRow.Cells[0].Value.ToString());
                var studentRecord = db.Students.First(x => x.Student_Id == id);

                studentRecord.Student_Name = dataGridViewStudentRecord.CurrentRow.Cells[1].Value.ToString();
                studentRecord.Student_Gender = dataGridViewStudentRecord.CurrentRow.Cells[2].Value.ToString();
                studentRecord.Student_Age = Convert.ToInt32(dataGridViewStudentRecord.CurrentRow.Cells[3].Value.ToString());
                studentRecord.Student_DOB = Convert.ToDateTime(dataGridViewStudentRecord.CurrentRow.Cells[4].Value.ToString());
                studentRecord.Student_Course = dataGridViewStudentRecord.CurrentRow.Cells[5].Value.ToString();
                studentRecord.Student_EmailID = dataGridViewStudentRecord.CurrentRow.Cells[6].Value.ToString();
                db.SaveChanges();
                MessageBox.Show("Student Updated Successfully");
                saveBtnStudentDataGrid.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewStudentRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            saveBtnStudentDataGrid.Enabled = true;
        }

        private void deleteBtnStudentDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDBEntities1 db = new StudentDBEntities1();
                int id = Convert.ToInt32(dataGridViewStudentRecord.CurrentRow.Cells[0].Value.ToString());
                var studentRecord = db.Students.First(x => x.Student_Id == id);

                var okCancelBtn = MessageBoxButtons.OKCancel;
                var ConfirmDeletion = MessageBox.Show("Do you want delete this student", "Confirmation Dialog", okCancelBtn);
                if (ConfirmDeletion.ToString() == "OK")
                {
                    db.Students.Remove(studentRecord);
                    db.SaveChanges();
                    dataGridViewStudentRecord.Rows.Remove(dataGridViewStudentRecord.CurrentRow);
                    MessageBox.Show("Student Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewStudentRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudentRecord.CurrentRow.Selected)
            {
                deleteBtnStudentDataGrid.Enabled = true;
            }
            else
            {
                deleteBtnStudentDataGrid.Enabled = false;
            }
        }
    }
}
