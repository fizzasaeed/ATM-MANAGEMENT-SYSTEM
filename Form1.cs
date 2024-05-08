using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System_PF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            userRegistration ur = new userRegistration();
            this.Hide();
            ur.Show();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            userLogin ul = new userLogin();
            this.Hide();
            ul.Show();
        }
    }
}
