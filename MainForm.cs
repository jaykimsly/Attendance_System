using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedin { get; set; }
        public int userID { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loggedin = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentsTBL' table. You can move, or remove it, as needed.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);
            // TODO: This line of code loads data into the 'dataSet1.AttendanceRecordTBL' table. You can move, or remove it, as needed.
            this.attendanceRecordTBLTableAdapter.Fill(this.dataSet1.AttendanceRecordTBL);
            // TODO: This line of code loads data into the 'dataSet1.ClassesTBL' table. You can move, or remove it, as needed.


        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (loggedin == 0)
            {
                //Open Login Form
                loginForm newLogin = new loginForm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    Close();
                }
                else
                {
                    userID = newLogin.userID;
                    statLblUser.Text = userID.ToString();
                    loggedin = 1;

                    this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
                    classesTBLBindingSource.Filter = "UserID = '" + userID.ToString() + "'";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddClass addClass = new FrmAddClass();
            addClass.userID = this.userID;
            addClass.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAddStudents students = new FrmAddStudents();
            students.className = comboBox1.Text;
            students.classID = (int)comboBox1.SelectedValue;
            students.ShowDialog();
        }
    }
}
