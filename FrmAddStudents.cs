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
    public partial class FrmAddStudents : Form
    {
        public int classID { get; set; }
        public string className { get; set; }
        public FrmAddStudents()
        {
            InitializeComponent();
        }

        private void FrmAddStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentsTBL' table. You can move, or remove it, as needed.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);
            lblClassID.Text = classID.ToString();
            lblClassName.Text = className.ToString();

        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {

            this.studentsTBLBindingSource.EndEdit();
            this.studentsTBLTableAdapter.Update(dataSet1.StudentsTBL);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
