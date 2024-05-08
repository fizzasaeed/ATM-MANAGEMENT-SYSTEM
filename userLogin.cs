using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_System_PF
{
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            string username;
            string pass;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"users.txt"))
            {
               try
                {
                    string[] strArr = new string[6];
                    strArr = line.Split(',');

                    username = strArr[0];
                    pass = strArr[4];

                    if (txtUsername.Text == username && txt_Password.Text == pass)
                    {
                        userMainDashboard umd = new userMainDashboard(username);
                        this.Hide();
                        umd.Show();
                    }
                }
                catch { }
            }
        }
    }
}
