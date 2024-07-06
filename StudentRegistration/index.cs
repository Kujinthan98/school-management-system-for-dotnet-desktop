using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            grades grades = new grades();
            grades.ShowDialog();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            subjects subjects = new subjects();
            subjects.ShowDialog();
        }

        private void btnrdStu_Click(object sender, EventArgs e)
        {
            GradeStudent student = new GradeStudent();
            student.ShowDialog();
        }

        private void btnStuSub_Click(object sender, EventArgs e)
        {
            StudentSubject subject = new StudentSubject();
            subject.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
