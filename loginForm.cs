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
    public partial class loginForm : Form
    {
        public bool loginFlag { get; set; }
        public int userID { get; set; }
        public loginForm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(textBoxUser.Text, textBoxPass.Text);

            if (dt.Rows.Count > 0)
            {
                //Valid

                MessageBox.Show("Succesful Login");
                userID = int.Parse(dt.Rows[0]["UserID"].ToString());
                loginFlag = true;
            }
            else {
                //not Valid
                MessageBox.Show("Access Denied");
                loginFlag = false;
            }

            Close();
        }
    }
}
