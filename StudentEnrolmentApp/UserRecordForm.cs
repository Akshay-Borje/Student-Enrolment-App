using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentEnrolmentApp
{
    public partial class UserRecordForm : Form
    {
        public UserRecordForm()
        {
            InitializeComponent();
        }

        private void UserRecordForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSetUser.StudentEnrolmentUser' table. You can move, or remove it, as needed.
            this.studentEnrolmentUserTableAdapter.Fill(this.studentDBDataSetUser.StudentEnrolmentUser);

        }

        private void saveUserDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDBEntities1 db = new StudentDBEntities1();
                int id = Convert.ToInt32(dataGridViewUserRecord.CurrentRow.Cells[0].Value);
                var userRecord = db.StudentEnrolmentUsers.First(x => x.userId == id);
                userRecord.Name = dataGridViewUserRecord.CurrentRow.Cells[1].Value.ToString();
                userRecord.Username = dataGridViewUserRecord.CurrentRow.Cells[2].Value.ToString();
                userRecord.Password = dataGridViewUserRecord.CurrentRow.Cells[3].Value.ToString();
                userRecord.UserRole = dataGridViewUserRecord.CurrentRow.Cells[4].Value.ToString();
                db.SaveChanges();
                MessageBox.Show("User Updated Successfully");
                saveUserDataGrid.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteUserDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmDelete = MessageBox.Show("Do you want to delete this User", "Confirm Dialog", MessageBoxButtons.YesNo);
                if (confirmDelete.ToString() == "Yes")
                {
                    StudentDBEntities1 db = new StudentDBEntities1();
                    int id = Convert.ToInt32(dataGridViewUserRecord.CurrentRow.Cells[0].Value);
                    var userRecord = db.StudentEnrolmentUsers.First(x => x.userId == id);
                    db.StudentEnrolmentUsers.Remove(userRecord);
                    db.SaveChanges();
                    dataGridViewUserRecord.Rows.Remove(dataGridViewUserRecord.CurrentRow);
                    MessageBox.Show("User Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewUserRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            saveUserDataGrid.Enabled = true;
        }

        private void dataGridViewUserRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUserRecord.CurrentRow.Selected)
            {
                deleteUserDataGrid.Enabled = true;
            }
            else
            {
                deleteUserDataGrid.Enabled = false;
            }
        }
    }
}
