namespace StudentEnrolmentApp
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            this.lblCourseFees = new System.Windows.Forms.Label();
            this.txtBoxCourseName = new System.Windows.Forms.TextBox();
            this.txtBoxCourseDuration = new System.Windows.Forms.TextBox();
            this.txtBoxCourseFees = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddCourseHeading = new System.Windows.Forms.Label();
            this.errorProviderAddCourseForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddCourseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(57, 90);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(97, 23);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course    :";
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.AutoSize = true;
            this.lblCourseDuration.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDuration.Location = new System.Drawing.Point(57, 150);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(95, 23);
            this.lblCourseDuration.TabIndex = 1;
            this.lblCourseDuration.Text = "Duration :";
            // 
            // lblCourseFees
            // 
            this.lblCourseFees.AutoSize = true;
            this.lblCourseFees.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseFees.Location = new System.Drawing.Point(57, 212);
            this.lblCourseFees.Name = "lblCourseFees";
            this.lblCourseFees.Size = new System.Drawing.Size(92, 23);
            this.lblCourseFees.TabIndex = 2;
            this.lblCourseFees.Text = "Fees       :";
            // 
            // txtBoxCourseName
            // 
            this.txtBoxCourseName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCourseName.Location = new System.Drawing.Point(177, 87);
            this.txtBoxCourseName.Name = "txtBoxCourseName";
            this.txtBoxCourseName.Size = new System.Drawing.Size(149, 30);
            this.txtBoxCourseName.TabIndex = 4;
            this.txtBoxCourseName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCourseName_Validating);
            // 
            // txtBoxCourseDuration
            // 
            this.txtBoxCourseDuration.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCourseDuration.Location = new System.Drawing.Point(177, 147);
            this.txtBoxCourseDuration.Name = "txtBoxCourseDuration";
            this.txtBoxCourseDuration.Size = new System.Drawing.Size(149, 30);
            this.txtBoxCourseDuration.TabIndex = 5;
            this.txtBoxCourseDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCourseDuration_Validating);
            // 
            // txtBoxCourseFees
            // 
            this.txtBoxCourseFees.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCourseFees.Location = new System.Drawing.Point(177, 209);
            this.txtBoxCourseFees.Name = "txtBoxCourseFees";
            this.txtBoxCourseFees.Size = new System.Drawing.Size(149, 30);
            this.txtBoxCourseFees.TabIndex = 6;
            this.txtBoxCourseFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCourseFees_Validating);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Teal;
            this.btnAddCourse.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddCourse.Location = new System.Drawing.Point(137, 301);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(74, 35);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Save";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblAddCourseHeading);
            this.panel1.Controls.Add(this.txtBoxCourseName);
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.lblCourseName);
            this.panel1.Controls.Add(this.lblCourseDuration);
            this.panel1.Controls.Add(this.txtBoxCourseFees);
            this.panel1.Controls.Add(this.lblCourseFees);
            this.panel1.Controls.Add(this.txtBoxCourseDuration);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 399);
            this.panel1.TabIndex = 9;
            // 
            // lblAddCourseHeading
            // 
            this.lblAddCourseHeading.AutoSize = true;
            this.lblAddCourseHeading.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseHeading.ForeColor = System.Drawing.Color.Green;
            this.lblAddCourseHeading.Location = new System.Drawing.Point(55, 12);
            this.lblAddCourseHeading.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAddCourseHeading.Name = "lblAddCourseHeading";
            this.lblAddCourseHeading.Size = new System.Drawing.Size(168, 33);
            this.lblAddCourseHeading.TabIndex = 18;
            this.lblAddCourseHeading.Text = "Add Course";
            // 
            // errorProviderAddCourseForm
            // 
            this.errorProviderAddCourseForm.ContainerControl = this;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(622, 413);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddCourseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseDuration;
        private System.Windows.Forms.Label lblCourseFees;
        private System.Windows.Forms.TextBox txtBoxCourseName;
        private System.Windows.Forms.TextBox txtBoxCourseDuration;
        private System.Windows.Forms.TextBox txtBoxCourseFees;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddCourseHeading;
        private System.Windows.Forms.ErrorProvider errorProviderAddCourseForm;
    }
}