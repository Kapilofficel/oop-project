using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Models;


namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // LoadForm(new WelcomeForm()); // first show Welcome Form
        }


        private void LoadForm(Form form)
        {
            //panelMain.Controls.Clear(); // old  Form clear 
            //form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;
            //panelMain.Controls.Add(form);
            //form.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadForm(new StudentForm());
            StudentForm studentForm = new StudentForm();

            studentForm.Show();
        }
    

    private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadForm(new CourseForm());
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
           
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectForm subjectForm = new SubjectForm();
            LoadForm(new SubjectForm());
            subjectForm.Show();
        }

       

        private void btnExams_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm examForm = new ExamForm();
            LoadForm(new ExamForm());
            examForm.Show();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkForm markForm = new MarkForm();
            LoadForm(new MarkForm());
            markForm.Show();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimetableForm timetableForm = new TimetableForm();  
            LoadForm(new TimetableForm());
            timetableForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // MainForm hiden
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm accountForm = new AccountForm();
            LoadForm(new AccountForm());
            accountForm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm();
            LoadForm(new RoomForm());
            roomForm.Show(roomForm);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
