namespace StudentEnrolmentApp
{
    partial class StudentRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecordForm));
            this.dataGridViewStudentRecord = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet = new StudentEnrolmentApp.StudentDBDataSet();
            this.panelDataGridStuentRecord = new System.Windows.Forms.Panel();
            this.studentTableAdapter = new StudentEnrolmentApp.StudentDBDataSetTableAdapters.StudentTableAdapter();
            this.saveBtnStudentDataGrid = new System.Windows.Forms.Button();
            this.deleteBtnStudentDataGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            this.panelDataGridStuentRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudentRecord
            // 
            this.dataGridViewStudentRecord.AllowUserToAddRows = false;
            this.dataGridViewStudentRecord.AllowUserToDeleteRows = false;
            this.dataGridViewStudentRecord.AutoGenerateColumns = false;
            this.dataGridViewStudentRecord.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudentRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewStudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentGenderDataGridViewTextBoxColumn,
            this.studentAgeDataGridViewTextBoxColumn,
            this.studentDOBDataGridViewTextBoxColumn,
            this.studentCourseDataGridViewTextBoxColumn,
            this.studentEmailIDDataGridViewTextBoxColumn});
            this.dataGridViewStudentRecord.DataSource = this.studentBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentRecord.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewStudentRecord.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStudentRecord.Name = "dataGridViewStudentRecord";
            this.dataGridViewStudentRecord.Size = new System.Drawing.Size(745, 235);
            this.dataGridViewStudentRecord.TabIndex = 0;
            this.dataGridViewStudentRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentRecord_CellDoubleClick);
            
            this.dataGridViewStudentRecord.SelectionChanged += new System.EventHandler(this.dataGridViewStudentRecord_SelectionChanged);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // studentGenderDataGridViewTextBoxColumn
            // 
            this.studentGenderDataGridViewTextBoxColumn.DataPropertyName = "Student_Gender";
            this.studentGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.studentGenderDataGridViewTextBoxColumn.Name = "studentGenderDataGridViewTextBoxColumn";
            // 
            // studentAgeDataGridViewTextBoxColumn
            // 
            this.studentAgeDataGridViewTextBoxColumn.DataPropertyName = "Student_Age";
            this.studentAgeDataGridViewTextBoxColumn.HeaderText = "Age";
            this.studentAgeDataGridViewTextBoxColumn.Name = "studentAgeDataGridViewTextBoxColumn";
            // 
            // studentDOBDataGridViewTextBoxColumn
            // 
            this.studentDOBDataGridViewTextBoxColumn.DataPropertyName = "Student_DOB";
            this.studentDOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.studentDOBDataGridViewTextBoxColumn.Name = "studentDOBDataGridViewTextBoxColumn";
            // 
            // studentCourseDataGridViewTextBoxColumn
            // 
            this.studentCourseDataGridViewTextBoxColumn.DataPropertyName = "Student_Course";
            this.studentCourseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.studentCourseDataGridViewTextBoxColumn.Name = "studentCourseDataGridViewTextBoxColumn";
            this.studentCourseDataGridViewTextBoxColumn.Width = 101;
            // 
            // studentEmailIDDataGridViewTextBoxColumn
            // 
            this.studentEmailIDDataGridViewTextBoxColumn.DataPropertyName = "Student_EmailID";
            this.studentEmailIDDataGridViewTextBoxColumn.HeaderText = "Email ID";
            this.studentEmailIDDataGridViewTextBoxColumn.Name = "studentEmailIDDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelDataGridStuentRecord
            // 
            this.panelDataGridStuentRecord.AutoSize = true;
            this.panelDataGridStuentRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelDataGridStuentRecord.Controls.Add(this.deleteBtnStudentDataGrid);
            this.panelDataGridStuentRecord.Controls.Add(this.saveBtnStudentDataGrid);
            this.panelDataGridStuentRecord.Controls.Add(this.dataGridViewStudentRecord);
            this.panelDataGridStuentRecord.Location = new System.Drawing.Point(12, 12);
            this.panelDataGridStuentRecord.Name = "panelDataGridStuentRecord";
            this.panelDataGridStuentRecord.Size = new System.Drawing.Size(753, 274);
            this.panelDataGridStuentRecord.TabIndex = 1;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // saveBtnStudentDataGrid
            // 
            this.saveBtnStudentDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.saveBtnStudentDataGrid.Enabled = false;
            this.saveBtnStudentDataGrid.Location = new System.Drawing.Point(286, 241);
            this.saveBtnStudentDataGrid.Name = "saveBtnStudentDataGrid";
            this.saveBtnStudentDataGrid.Size = new System.Drawing.Size(75, 30);
            this.saveBtnStudentDataGrid.TabIndex = 1;
            this.saveBtnStudentDataGrid.Text = "Save";
            this.saveBtnStudentDataGrid.UseVisualStyleBackColor = false;
            this.saveBtnStudentDataGrid.Click += new System.EventHandler(this.saveBtnStudentDataGrid_Click);
            // 
            // deleteBtnStudentDataGrid
            // 
            this.deleteBtnStudentDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.deleteBtnStudentDataGrid.Enabled = false;
            this.deleteBtnStudentDataGrid.Location = new System.Drawing.Point(383, 241);
            this.deleteBtnStudentDataGrid.Name = "deleteBtnStudentDataGrid";
            this.deleteBtnStudentDataGrid.Size = new System.Drawing.Size(75, 30);
            this.deleteBtnStudentDataGrid.TabIndex = 2;
            this.deleteBtnStudentDataGrid.Text = "Delete";
            this.deleteBtnStudentDataGrid.UseVisualStyleBackColor = false;
            this.deleteBtnStudentDataGrid.Click += new System.EventHandler(this.deleteBtnStudentDataGrid_Click);
            // 
            // StudentRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 288);
            this.Controls.Add(this.panelDataGridStuentRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Record";
            this.Load += new System.EventHandler(this.StudentRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            this.panelDataGridStuentRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentRecord;
        private System.Windows.Forms.Panel panelDataGridStuentRecord;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteBtnStudentDataGrid;
        private System.Windows.Forms.Button saveBtnStudentDataGrid;
    }
}