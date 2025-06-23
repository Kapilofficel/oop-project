namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.student_data = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tnic = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 71);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "STUDENTS   MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // student_data
            // 
            this.student_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_data.Location = new System.Drawing.Point(201, 313);
            this.student_data.Margin = new System.Windows.Forms.Padding(4);
            this.student_data.Name = "student_data";
            this.student_data.RowHeadersWidth = 51;
            this.student_data.Size = new System.Drawing.Size(390, 201);
            this.student_data.TabIndex = 16;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(245, 250);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 43);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(367, 250);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(72, 43);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(490, 250);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(70, 43);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tnic
            // 
            this.tnic.Location = new System.Drawing.Point(342, 148);
            this.tnic.Margin = new System.Windows.Forms.Padding(4);
            this.tnic.Name = "tnic";
            this.tnic.Size = new System.Drawing.Size(249, 26);
            this.tnic.TabIndex = 12;
            this.tnic.TextChanged += new System.EventHandler(this.tnic_TextChanged);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(342, 113);
            this.tname.Margin = new System.Windows.Forms.Padding(4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(248, 26);
            this.tname.TabIndex = 11;
            this.tname.TextChanged += new System.EventHandler(this.tname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "NIC NO : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "NAME   : ";
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Location = new System.Drawing.Point(342, 192);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(248, 28);
            this.cmbcourse.TabIndex = 18;
            this.cmbcourse.SelectedIndexChanged += new System.EventHandler(this.cmbcourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "COURSE NAME : ";
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(928, 527);
            this.Controls.Add(this.cmbcourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.student_data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tnic);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView student_data;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tnic;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcourse;
    }
}
