namespace StudentEnrolmentApp
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.panelStudentForm = new System.Windows.Forms.Panel();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet1CourseComboBox = new StudentEnrolmentApp.StudentDBDataSet1CourseComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxEmailID = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddStudentHeading = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderAddStudentForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentDBDataSetCourse = new StudentEnrolmentApp.StudentDBDataSetCourse();
            this.studentDBDataSetCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new StudentEnrolmentApp.StudentDBDataSet1CourseComboBoxTableAdapters.CourseTableAdapter();
            this.panelStudentForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1CourseComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddStudentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStudentForm
            // 
            this.panelStudentForm.AutoScroll = true;
            this.panelStudentForm.AutoSize = true;
            this.panelStudentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelStudentForm.Controls.Add(this.txtBoxAge);
            this.panelStudentForm.Controls.Add(this.lblAge);
            this.panelStudentForm.Controls.Add(this.comboBoxCourses);
            this.panelStudentForm.Controls.Add(this.lblCourse);
            this.panelStudentForm.Controls.Add(this.radioButtonFemale);
            this.panelStudentForm.Controls.Add(this.radioButtonMale);
            this.panelStudentForm.Controls.Add(this.dateTimePickerDOB);
            this.panelStudentForm.Controls.Add(this.txtBoxMiddleName);
            this.panelStudentForm.Controls.Add(this.txtBoxLastName);
            this.panelStudentForm.Controls.Add(this.txtBoxEmailID);
            this.panelStudentForm.Controls.Add(this.txtBoxFirstName);
            this.panelStudentForm.Controls.Add(this.btnAddStudent);
            this.panelStudentForm.Controls.Add(this.lblEmailID);
            this.panelStudentForm.Controls.Add(this.lblGender);
            this.panelStudentForm.Controls.Add(this.lblDateOfBirth);
            this.panelStudentForm.Controls.Add(this.lblName);
            this.panelStudentForm.Controls.Add(this.lblAddStudentHeading);
            this.panelStudentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentForm.Location = new System.Drawing.Point(0, 0);
            this.panelStudentForm.Name = "panelStudentForm";
            this.panelStudentForm.Size = new System.Drawing.Size(910, 578);
            this.panelStudentForm.TabIndex = 17;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.Location = new System.Drawing.Point(673, 189);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(100, 30);
            this.txtBoxAge.TabIndex = 5;
            this.txtBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxAge_Validating);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(587, 189);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(64, 23);
            this.lblAge.TabIndex = 32;
            this.lblAge.Text = "Age   :";
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.DataSource = this.courseBindingSource1;
            this.comboBoxCourses.DisplayMember = "Course_Name";
            this.comboBoxCourses.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(302, 417);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(171, 31);
            this.comboBoxCourses.TabIndex = 9;
            this.comboBoxCourses.ValueMember = "Course_Name";
            this.comboBoxCourses.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCourses_Validating);
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.studentDBDataSet1CourseComboBox;
            // 
            // studentDBDataSet1CourseComboBox
            // 
            this.studentDBDataSet1CourseComboBox.DataSetName = "StudentDBDataSet1CourseComboBox";
            this.studentDBDataSet1CourseComboBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(107, 423);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(132, 23);
            this.lblCourse.TabIndex = 30;
            this.lblCourse.Text = "Course           :";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(392, 257);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(92, 27);
            this.radioButtonFemale.TabIndex = 7;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(302, 257);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(70, 27);
            this.radioButtonMale.TabIndex = 6;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(302, 186);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMiddleName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxMiddleName.Location = new System.Drawing.Point(485, 119);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(148, 30);
            this.txtBoxMiddleName.TabIndex = 2;
            this.txtBoxMiddleName.Text = "Middle Name";
            this.txtBoxMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxMiddleName_Validating);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxLastName.Location = new System.Drawing.Point(673, 119);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(162, 30);
            this.txtBoxLastName.TabIndex = 3;
            this.txtBoxLastName.Text = "Last Name";
            this.txtBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxLastName_Validating);
            // 
            // txtBoxEmailID
            // 
            this.txtBoxEmailID.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmailID.Location = new System.Drawing.Point(302, 339);
            this.txtBoxEmailID.Name = "txtBoxEmailID";
            this.txtBoxEmailID.Size = new System.Drawing.Size(171, 30);
            this.txtBoxEmailID.TabIndex = 8;
            this.txtBoxEmailID.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmailID_Validating);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxFirstName.Location = new System.Drawing.Point(302, 119);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(148, 30);
            this.txtBoxFirstName.TabIndex = 1;
            this.txtBoxFirstName.Text = "First Name";
            this.txtBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxFirstName_Validating);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Teal;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddStudent.Location = new System.Drawing.Point(302, 507);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 38);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Save";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailID.Location = new System.Drawing.Point(108, 342);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(132, 23);
            this.lblEmailID.TabIndex = 21;
            this.lblEmailID.Text = "Email ID         :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(108, 266);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(134, 23);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender           :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(108, 186);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(137, 23);
            this.lblDateOfBirth.TabIndex = 19;
            this.lblDateOfBirth.Text = "Date of Birth  :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(108, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 23);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name              :";
            // 
            // lblAddStudentHeading
            // 
            this.lblAddStudentHeading.AutoSize = true;
            this.lblAddStudentHeading.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentHeading.ForeColor = System.Drawing.Color.Green;
            this.lblAddStudentHeading.Location = new System.Drawing.Point(106, 25);
            this.lblAddStudentHeading.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAddStudentHeading.Name = "lblAddStudentHeading";
            this.lblAddStudentHeading.Size = new System.Drawing.Size(177, 33);
            this.lblAddStudentHeading.TabIndex = 17;
            this.lblAddStudentHeading.Text = "Add Student";
            // 
            // errorProviderAddStudentForm
            // 
            this.errorProviderAddStudentForm.ContainerControl = this;
            // 
            // studentDBDataSetCourse
            // 
            this.studentDBDataSetCourse.DataSetName = "StudentDBDataSetCourse";
            this.studentDBDataSetCourse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSetCourseBindingSource
            // 
            this.studentDBDataSetCourseBindingSource.DataSource = this.studentDBDataSetCourse;
            this.studentDBDataSetCourseBindingSource.Position = 0;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(910, 578);
            this.Controls.Add(this.panelStudentForm);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.panelStudentForm.ResumeLayout(false);
            this.panelStudentForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1CourseComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddStudentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetCourseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStudentForm;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxEmailID;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddStudentHeading;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ErrorProvider errorProviderAddStudentForm;
        private StudentDBDataSetCourse studentDBDataSetCourse;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource studentDBDataSetCourseBindingSource;
        private StudentDBDataSet1CourseComboBox studentDBDataSet1CourseComboBox;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private StudentDBDataSet1CourseComboBoxTableAdapters.CourseTableAdapter courseTableAdapter;
    }
}