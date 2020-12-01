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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserAuthenticationCheck()
        {
            StudentDBEntities1 db = new StudentDBEntities1();

            try
            {
                var userName = txtBoxUsername.Text;
                var password = txtBoxPassword.Text;
                var users = db.StudentEnrolmentUsers;
                var userRole = "";
                foreach (var item in users)
                {
                    if(item.Username == userName)
                    {
                        userRole = item.UserRole;
                    }
                }

                var user = db.StudentEnrolmentUsers.Any(u => u.Username == userName && u.Password == password);
                if (user)
                {
                    HomeForm homeForm = new HomeForm(userRole);
                    homeForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Please enter correct credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAuthenticationCheck();
        }

        private void btnEye_MouseHover(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = false;
        }

        private void btnEye_MouseLeave(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void txtBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxUsername.Text))
            {                
                e.Cancel = true;
                errorProviderLoginForm.SetError(txtBoxUsername, "Please enter username");
            }
            else
            {
                e.Cancel = false;
                errorProviderLoginForm.SetError(txtBoxUsername, null);
            }
        }

        private void txtBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                e.Cancel = true;
                errorProviderLoginForm.SetError(txtBoxPassword, "Please enter password");
            }
            else
            {
                e.Cancel = false;
                errorProviderLoginForm.SetError(txtBoxPassword, null);
            }
        }
    }
}
