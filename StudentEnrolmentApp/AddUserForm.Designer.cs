namespace StudentEnrolmentApp
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.panelAddUserForm = new System.Windows.Forms.Panel();
            this.btnEyeUserRegPassword = new System.Windows.Forms.Button();
            this.btnEyeConfirmPassword = new System.Windows.Forms.Button();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblAddUserHeading = new System.Windows.Forms.Label();
            this.txtBoxNameOfUser = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblNameOfUser = new System.Windows.Forms.Label();
            this.lblUsernameUserRegistration = new System.Windows.Forms.Label();
            this.txtBoxPasswordUserRegistration = new System.Windows.Forms.TextBox();
            this.lblPasswordUserRegistration = new System.Windows.Forms.Label();
            this.txtBoxUsernameUserRegistration = new System.Windows.Forms.TextBox();
            this.errorProviderAddUserForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAddUserForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddUserForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddUserForm
            // 
            this.panelAddUserForm.AutoSize = true;
            this.panelAddUserForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelAddUserForm.Controls.Add(this.btnEyeUserRegPassword);
            this.panelAddUserForm.Controls.Add(this.btnEyeConfirmPassword);
            this.panelAddUserForm.Controls.Add(this.comboBoxUserRole);
            this.panelAddUserForm.Controls.Add(this.lblUserRole);
            this.panelAddUserForm.Controls.Add(this.txtBoxConfirmPassword);
            this.panelAddUserForm.Controls.Add(this.lblConfirmPassword);
            this.panelAddUserForm.Controls.Add(this.lblAddUserHeading);
            this.panelAddUserForm.Controls.Add(this.txtBoxNameOfUser);
            this.panelAddUserForm.Controls.Add(this.btnAddUser);
            this.panelAddUserForm.Controls.Add(this.lblNameOfUser);
            this.panelAddUserForm.Controls.Add(this.lblUsernameUserRegistration);
            this.panelAddUserForm.Controls.Add(this.txtBoxPasswordUserRegistration);
            this.panelAddUserForm.Controls.Add(this.lblPasswordUserRegistration);
            this.panelAddUserForm.Controls.Add(this.txtBoxUsernameUserRegistration);
            this.panelAddUserForm.Location = new System.Drawing.Point(12, 12);
            this.panelAddUserForm.Name = "panelAddUserForm";
            this.panelAddUserForm.Size = new System.Drawing.Size(598, 484);
            this.panelAddUserForm.TabIndex = 10;
            // 
            // btnEyeUserRegPassword
            // 
            this.btnEyeUserRegPassword.Image = global::StudentEnrolmentApp.Properties.Resources.Eyeicon;
            this.btnEyeUserRegPassword.Location = new System.Drawing.Point(407, 214);
            this.btnEyeUserRegPassword.Name = "btnEyeUserRegPassword";
            this.btnEyeUserRegPassword.Size = new System.Drawing.Size(34, 23);
            this.btnEyeUserRegPassword.TabIndex = 24;
            this.btnEyeUserRegPassword.UseVisualStyleBackColor = true;
            this.btnEyeUserRegPassword.MouseLeave += new System.EventHandler(this.btnEyeUserRegPassword_MouseLeave);
            this.btnEyeUserRegPassword.MouseHover += new System.EventHandler(this.btnEyeUserRegPassword_MouseHover);
            // 
            // btnEyeConfirmPassword
            // 
            this.btnEyeConfirmPassword.Image = global::StudentEnrolmentApp.Properties.Resources.Eyeicon;
            this.btnEyeConfirmPassword.Location = new System.Drawing.Point(407, 277);
            this.btnEyeConfirmPassword.Name = "btnEyeConfirmPassword";
            this.btnEyeConfirmPassword.Size = new System.Drawing.Size(34, 23);
            this.btnEyeConfirmPassword.TabIndex = 23;
            this.btnEyeConfirmPassword.UseVisualStyleBackColor = true;
            this.btnEyeConfirmPassword.MouseLeave += new System.EventHandler(this.btnEyeConfirmPassword_MouseLeave);
            this.btnEyeConfirmPassword.MouseHover += new System.EventHandler(this.btnEyeConfirmPassword_MouseHover);
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Items.AddRange(new object[] {
            "Admin",
            "Operator",
            "Viewer"});
            this.comboBoxUserRole.Location = new System.Drawing.Point(267, 332);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(174, 31);
            this.comboBoxUserRole.TabIndex = 22;
            this.comboBoxUserRole.Text = "Select role";
            this.comboBoxUserRole.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUserRole_Validating);
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(57, 335);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(190, 23);
            this.lblUserRole.TabIndex = 21;
            this.lblUserRole.Text = "User Role                  :";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(267, 272);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(174, 30);
            this.txtBoxConfirmPassword.TabIndex = 20;
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            this.txtBoxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxConfirmPassword_Validating);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(56, 275);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(191, 23);
            this.lblConfirmPassword.TabIndex = 19;
            this.lblConfirmPassword.Text = "Confirm Password   :";
            // 
            // lblAddUserHeading
            // 
            this.lblAddUserHeading.AutoSize = true;
            this.lblAddUserHeading.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserHeading.ForeColor = System.Drawing.Color.Green;
            this.lblAddUserHeading.Location = new System.Drawing.Point(55, 12);
            this.lblAddUserHeading.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAddUserHeading.Name = "lblAddUserHeading";
            this.lblAddUserHeading.Size = new System.Drawing.Size(136, 33);
            this.lblAddUserHeading.TabIndex = 18;
            this.lblAddUserHeading.Text = "Add User";
            // 
            // txtBoxNameOfUser
            // 
            this.txtBoxNameOfUser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameOfUser.Location = new System.Drawing.Point(267, 87);
            this.txtBoxNameOfUser.Name = "txtBoxNameOfUser";
            this.txtBoxNameOfUser.Size = new System.Drawing.Size(174, 30);
            this.txtBoxNameOfUser.TabIndex = 4;
            this.txtBoxNameOfUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNameOfUser_Validating);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Teal;
            this.btnAddUser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddUser.Location = new System.Drawing.Point(173, 419);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 35);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Save";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblNameOfUser
            // 
            this.lblNameOfUser.AutoSize = true;
            this.lblNameOfUser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfUser.Location = new System.Drawing.Point(57, 90);
            this.lblNameOfUser.Name = "lblNameOfUser";
            this.lblNameOfUser.Size = new System.Drawing.Size(186, 23);
            this.lblNameOfUser.TabIndex = 0;
            this.lblNameOfUser.Text = "Name                        :";
            // 
            // lblUsernameUserRegistration
            // 
            this.lblUsernameUserRegistration.AutoSize = true;
            this.lblUsernameUserRegistration.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameUserRegistration.Location = new System.Drawing.Point(57, 152);
            this.lblUsernameUserRegistration.Name = "lblUsernameUserRegistration";
            this.lblUsernameUserRegistration.Size = new System.Drawing.Size(186, 23);
            this.lblUsernameUserRegistration.TabIndex = 1;
            this.lblUsernameUserRegistration.Text = "Username                :";
            // 
            // txtBoxPasswordUserRegistration
            // 
            this.txtBoxPasswordUserRegistration.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPasswordUserRegistration.Location = new System.Drawing.Point(267, 209);
            this.txtBoxPasswordUserRegistration.Name = "txtBoxPasswordUserRegistration";
            this.txtBoxPasswordUserRegistration.Size = new System.Drawing.Size(174, 30);
            this.txtBoxPasswordUserRegistration.TabIndex = 6;
            this.txtBoxPasswordUserRegistration.UseSystemPasswordChar = true;
            this.txtBoxPasswordUserRegistration.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPasswordUserRegistration_Validating);
            // 
            // lblPasswordUserRegistration
            // 
            this.lblPasswordUserRegistration.AutoSize = true;
            this.lblPasswordUserRegistration.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordUserRegistration.Location = new System.Drawing.Point(57, 212);
            this.lblPasswordUserRegistration.Name = "lblPasswordUserRegistration";
            this.lblPasswordUserRegistration.Size = new System.Drawing.Size(187, 23);
            this.lblPasswordUserRegistration.TabIndex = 2;
            this.lblPasswordUserRegistration.Text = "Password                 :";
            // 
            // txtBoxUsernameUserRegistration
            // 
            this.txtBoxUsernameUserRegistration.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsernameUserRegistration.Location = new System.Drawing.Point(267, 149);
            this.txtBoxUsernameUserRegistration.Name = "txtBoxUsernameUserRegistration";
            this.txtBoxUsernameUserRegistration.Size = new System.Drawing.Size(174, 30);
            this.txtBoxUsernameUserRegistration.TabIndex = 5;
            this.txtBoxUsernameUserRegistration.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxUsernameUserRegistration_Validating);
            // 
            // errorProviderAddUserForm
            // 
            this.errorProviderAddUserForm.ContainerControl = this;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 508);
            this.Controls.Add(this.panelAddUserForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.panelAddUserForm.ResumeLayout(false);
            this.panelAddUserForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddUserForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAddUserForm;
        private System.Windows.Forms.Label lblAddUserHeading;
        private System.Windows.Forms.TextBox txtBoxNameOfUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblNameOfUser;
        private System.Windows.Forms.Label lblUsernameUserRegistration;
        private System.Windows.Forms.TextBox txtBoxPasswordUserRegistration;
        private System.Windows.Forms.Label lblPasswordUserRegistration;
        private System.Windows.Forms.TextBox txtBoxUsernameUserRegistration;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ComboBox comboBoxUserRole;
        private System.Windows.Forms.ErrorProvider errorProviderAddUserForm;
        private System.Windows.Forms.Button btnEyeUserRegPassword;
        private System.Windows.Forms.Button btnEyeConfirmPassword;
    }
}