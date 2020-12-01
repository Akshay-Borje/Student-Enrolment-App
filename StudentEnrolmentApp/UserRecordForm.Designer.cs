namespace StudentEnrolmentApp
{
    partial class UserRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRecordForm));
            this.panelUserReocordDataGrid = new System.Windows.Forms.Panel();
            this.saveUserDataGrid = new System.Windows.Forms.Button();
            this.deleteUserDataGrid = new System.Windows.Forms.Button();
            this.dataGridViewUserRecord = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEnrolmentUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSetUser = new StudentEnrolmentApp.StudentDBDataSetUser();
            this.studentDBDataSet = new StudentEnrolmentApp.StudentDBDataSet();
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentEnrolmentUserTableAdapter = new StudentEnrolmentApp.StudentDBDataSetUserTableAdapters.StudentEnrolmentUserTableAdapter();
            this.panelUserReocordDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEnrolmentUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserReocordDataGrid
            // 
            this.panelUserReocordDataGrid.AutoSize = true;
            this.panelUserReocordDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelUserReocordDataGrid.Controls.Add(this.saveUserDataGrid);
            this.panelUserReocordDataGrid.Controls.Add(this.deleteUserDataGrid);
            this.panelUserReocordDataGrid.Controls.Add(this.dataGridViewUserRecord);
            this.panelUserReocordDataGrid.Location = new System.Drawing.Point(12, 12);
            this.panelUserReocordDataGrid.Name = "panelUserReocordDataGrid";
            this.panelUserReocordDataGrid.Size = new System.Drawing.Size(569, 310);
            this.panelUserReocordDataGrid.TabIndex = 0;
            // 
            // saveUserDataGrid
            // 
            this.saveUserDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.saveUserDataGrid.Enabled = false;
            this.saveUserDataGrid.Location = new System.Drawing.Point(234, 274);
            this.saveUserDataGrid.Name = "saveUserDataGrid";
            this.saveUserDataGrid.Size = new System.Drawing.Size(75, 30);
            this.saveUserDataGrid.TabIndex = 2;
            this.saveUserDataGrid.Text = "Save";
            this.saveUserDataGrid.UseVisualStyleBackColor = false;
            this.saveUserDataGrid.Click += new System.EventHandler(this.saveUserDataGrid_Click);
            // 
            // deleteUserDataGrid
            // 
            this.deleteUserDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.deleteUserDataGrid.Enabled = false;
            this.deleteUserDataGrid.Location = new System.Drawing.Point(315, 274);
            this.deleteUserDataGrid.Name = "deleteUserDataGrid";
            this.deleteUserDataGrid.Size = new System.Drawing.Size(75, 30);
            this.deleteUserDataGrid.TabIndex = 1;
            this.deleteUserDataGrid.Text = "Delete";
            this.deleteUserDataGrid.UseVisualStyleBackColor = false;
            this.deleteUserDataGrid.Click += new System.EventHandler(this.deleteUserDataGrid_Click);
            // 
            // dataGridViewUserRecord
            // 
            this.dataGridViewUserRecord.AllowUserToAddRows = false;
            this.dataGridViewUserRecord.AllowUserToDeleteRows = false;
            this.dataGridViewUserRecord.AutoGenerateColumns = false;
            this.dataGridViewUserRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn});
            this.dataGridViewUserRecord.DataSource = this.studentEnrolmentUserBindingSource;
            this.dataGridViewUserRecord.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewUserRecord.Name = "dataGridViewUserRecord";
            this.dataGridViewUserRecord.Size = new System.Drawing.Size(542, 255);
            this.dataGridViewUserRecord.TabIndex = 0;
            this.dataGridViewUserRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserRecord_CellDoubleClick);
            
            this.dataGridViewUserRecord.SelectionChanged += new System.EventHandler(this.dataGridViewUserRecord_SelectionChanged);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "User Role";
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            // 
            // studentEnrolmentUserBindingSource
            // 
            this.studentEnrolmentUserBindingSource.DataMember = "StudentEnrolmentUser";
            this.studentEnrolmentUserBindingSource.DataSource = this.studentDBDataSetUser;
            // 
            // studentDBDataSetUser
            // 
            this.studentDBDataSetUser.DataSetName = "StudentDBDataSetUser";
            this.studentDBDataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSetBindingSource
            // 
            this.studentDBDataSetBindingSource.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource.Position = 0;
            // 
            // studentEnrolmentUserTableAdapter
            // 
            this.studentEnrolmentUserTableAdapter.ClearBeforeFill = true;
            // 
            // UserRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(591, 328);
            this.Controls.Add(this.panelUserReocordDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRecordForm";
            this.Text = "User Record";
            this.Load += new System.EventHandler(this.UserRecordForm_Load);
            this.panelUserReocordDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEnrolmentUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUserReocordDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewUserRecord;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private StudentDBDataSet studentDBDataSet;
        private StudentDBDataSetUser studentDBDataSetUser;
        private System.Windows.Forms.BindingSource studentEnrolmentUserBindingSource;
        private StudentDBDataSetUserTableAdapters.StudentEnrolmentUserTableAdapter studentEnrolmentUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveUserDataGrid;
        private System.Windows.Forms.Button deleteUserDataGrid;
    }
}