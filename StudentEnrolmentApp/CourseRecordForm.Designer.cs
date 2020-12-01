namespace StudentEnrolmentApp
{
    partial class CourseRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseRecordForm));
            this.panelCourseRecordDataGrid = new System.Windows.Forms.Panel();
            this.saveCourseDataGrid = new System.Windows.Forms.Button();
            this.deleteCourseDataGrid = new System.Windows.Forms.Button();
            this.dataGridViewCourseRecord = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSetCourse = new StudentEnrolmentApp.StudentDBDataSetCourse();
            this.courseTableAdapter = new StudentEnrolmentApp.StudentDBDataSetCourseTableAdapters.CourseTableAdapter();
            this.panelCourseRecordDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCourseRecordDataGrid
            // 
            this.panelCourseRecordDataGrid.AutoSize = true;
            this.panelCourseRecordDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelCourseRecordDataGrid.Controls.Add(this.saveCourseDataGrid);
            this.panelCourseRecordDataGrid.Controls.Add(this.deleteCourseDataGrid);
            this.panelCourseRecordDataGrid.Controls.Add(this.dataGridViewCourseRecord);
            this.panelCourseRecordDataGrid.Location = new System.Drawing.Point(12, 12);
            this.panelCourseRecordDataGrid.Name = "panelCourseRecordDataGrid";
            this.panelCourseRecordDataGrid.Size = new System.Drawing.Size(474, 335);
            this.panelCourseRecordDataGrid.TabIndex = 0;
            // 
            // saveCourseDataGrid
            // 
            this.saveCourseDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.saveCourseDataGrid.Enabled = false;
            this.saveCourseDataGrid.Location = new System.Drawing.Point(156, 292);
            this.saveCourseDataGrid.Name = "saveCourseDataGrid";
            this.saveCourseDataGrid.Size = new System.Drawing.Size(75, 30);
            this.saveCourseDataGrid.TabIndex = 4;
            this.saveCourseDataGrid.Text = "Save";
            this.saveCourseDataGrid.UseVisualStyleBackColor = false;
            this.saveCourseDataGrid.Click += new System.EventHandler(this.saveCourseDataGrid_Click);
            // 
            // deleteCourseDataGrid
            // 
            this.deleteCourseDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.deleteCourseDataGrid.Enabled = false;
            this.deleteCourseDataGrid.Location = new System.Drawing.Point(246, 292);
            this.deleteCourseDataGrid.Name = "deleteCourseDataGrid";
            this.deleteCourseDataGrid.Size = new System.Drawing.Size(75, 30);
            this.deleteCourseDataGrid.TabIndex = 3;
            this.deleteCourseDataGrid.Text = "Delete";
            this.deleteCourseDataGrid.UseVisualStyleBackColor = false;
            this.deleteCourseDataGrid.Click += new System.EventHandler(this.deleteCourseDataGrid_Click);
            // 
            // dataGridViewCourseRecord
            // 
            this.dataGridViewCourseRecord.AllowUserToAddRows = false;
            this.dataGridViewCourseRecord.AllowUserToDeleteRows = false;
            this.dataGridViewCourseRecord.AutoGenerateColumns = false;
            this.dataGridViewCourseRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseDurationDataGridViewTextBoxColumn,
            this.courseFeesDataGridViewTextBoxColumn});
            this.dataGridViewCourseRecord.DataSource = this.courseBindingSource;
            this.dataGridViewCourseRecord.Location = new System.Drawing.Point(18, 12);
            this.dataGridViewCourseRecord.Name = "dataGridViewCourseRecord";
            this.dataGridViewCourseRecord.Size = new System.Drawing.Size(442, 260);
            this.dataGridViewCourseRecord.TabIndex = 0;
            this.dataGridViewCourseRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourseRecord_CellDoubleClick);
            
            this.dataGridViewCourseRecord.SelectionChanged += new System.EventHandler(this.dataGridViewCourseRecord_SelectionChanged);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // courseDurationDataGridViewTextBoxColumn
            // 
            this.courseDurationDataGridViewTextBoxColumn.DataPropertyName = "Course_Duration";
            this.courseDurationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.courseDurationDataGridViewTextBoxColumn.Name = "courseDurationDataGridViewTextBoxColumn";
            // 
            // courseFeesDataGridViewTextBoxColumn
            // 
            this.courseFeesDataGridViewTextBoxColumn.DataPropertyName = "Course_Fees";
            this.courseFeesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.courseFeesDataGridViewTextBoxColumn.Name = "courseFeesDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.studentDBDataSetCourse;
            // 
            // studentDBDataSetCourse
            // 
            this.studentDBDataSetCourse.DataSetName = "StudentDBDataSetCourse";
            this.studentDBDataSetCourse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // CourseRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(494, 359);
            this.Controls.Add(this.panelCourseRecordDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseRecordForm";
            this.Text = "Course Record ";
            this.Load += new System.EventHandler(this.CourseRecordForm_Load);
            this.panelCourseRecordDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCourseRecordDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewCourseRecord;
        private StudentDBDataSetCourse studentDBDataSetCourse;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StudentDBDataSetCourseTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button saveCourseDataGrid;
        private System.Windows.Forms.Button deleteCourseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseFeesDataGridViewTextBoxColumn;
    }
}