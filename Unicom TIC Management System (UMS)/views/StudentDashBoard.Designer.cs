namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class StudentDashBoard
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightGray;
            this.panelHeader.Controls.Add(this.lblHeading);
            this.panelHeader.Location = new System.Drawing.Point(1, 5);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 62);
            this.panelHeader.TabIndex = 17;
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(900, 62);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "UNICOM TIC STUDENT\'S DASHBOARD";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(335, 86);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(168, 49);
            this.btnCourses.TabIndex = 11;
            this.btnCourses.Text = "View Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.Location = new System.Drawing.Point(335, 163);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(168, 49);
            this.btnSubjects.TabIndex = 12;
            this.btnSubjects.Text = "View Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnExams
            // 
            this.btnExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.Location = new System.Drawing.Point(335, 241);
            this.btnExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(168, 49);
            this.btnExams.TabIndex = 13;
            this.btnExams.Text = "View Exams";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarks.Location = new System.Drawing.Point(335, 327);
            this.btnMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(168, 49);
            this.btnMarks.TabIndex = 14;
            this.btnMarks.Text = "View Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnTimetables
            // 
            this.btnTimetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetables.Location = new System.Drawing.Point(335, 411);
            this.btnTimetables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(168, 59);
            this.btnTimetables.TabIndex = 15;
            this.btnTimetables.Text = "View Timetables";
            this.btnTimetables.UseVisualStyleBackColor = true;
            this.btnTimetables.Click += new System.EventHandler(this.btnTimetables_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(335, 502);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 49);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentDashBoard";
            this.Text = "StudentDashBoard";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button btnLogout;
    }
}