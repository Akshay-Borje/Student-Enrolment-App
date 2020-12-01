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
    public partial class AddUserForm : Form
    {
        public AddUserForm() 
        {
            InitializeComponent();
        }

        private void txtBoxNameOfUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNameOfUser.Text))
            {
                e.Cancel = true;
                errorProviderAddUserForm.SetError(txtBoxNameOfUser, "Please enter name of user");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddUserForm.SetError(txtBoxNameOfUser, null);
            }
        }

        private void txtBoxUsernameUserRegistration_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxUsernameUserRegistration.Text))
            {
                e.Cancel = true;
                errorProviderAddUserForm.SetError(txtBoxUsernameUserRegistration, "Please enter username");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddUserForm.SetError(txtBoxUsernameUserRegistration, null);
            }
        }

        private void txtBoxPasswordUserRegistration_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPasswordUserRegistration.Text))
            {
                e.Cancel = true;
                errorProviderAddUserForm.SetError(txtBoxPasswordUserRegistration, "Please enter password");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddUserForm.SetError(txtBoxPasswordUserRegistration, null);
            }
        }

        private void txtBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProviderAddUserForm.SetError(txtBoxConfirmPassword, "Please confirm the password");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddUserForm.SetError(txtBoxConfirmPassword, null);
            }
        }

        private void comboBoxUserRole_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxUserRole.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderAddUserForm.SetError(comboBoxUserRole, "Please select user role");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddUserForm.SetError(comboBoxUserRole, null);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            StudentDBEntities1 db = new StudentDBEntities1();

            StudentEnrolmentUser user = new StudentEnrolmentUser();

            try
            {
                user.Name = txtBoxNameOfUser.Text;
                user.Username = txtBoxUsernameUserRegistration.Text;
                if (txtBoxPasswordUserRegistration.Text == txtBoxConfirmPassword.Text)
                {
                    user.Password = txtBoxPasswordUserRegistration.Text;
                }
                else
                {
                    throw new InvalidOperationException();
                }
                user.UserRole = comboBoxUserRole.SelectedItem.ToString();

                db.StudentEnrolmentUsers.Add(user);
                db.SaveChanges();
                MessageBox.Show("User Added successfully");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Confirm Password dose not match");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEyeUserRegPassword_MouseHover(object sender, EventArgs e)
        {
            txtBoxPasswordUserRegistration.UseSystemPasswordChar = false;
        }

        private void btnEyeUserRegPassword_MouseLeave(object sender, EventArgs e)
        {
            txtBoxPasswordUserRegistration.UseSystemPasswordChar = true;
        }

        private void btnEyeConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            txtBoxConfirmPassword.UseSystemPasswordChar = false;
        }

        private void btnEyeConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            txtBoxConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
