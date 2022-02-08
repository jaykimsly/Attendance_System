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
    public partial class FrmAddClass : Form
    {
        public int userID { get; set; }
        public FrmAddClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTBLTableAdapter ada = new DataSet1TableAdapters.ClassesTBLTableAdapter();
            ada.Addclass(textBox1.Text, userID);
            Close();
        }
    }
}
