using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ATM_System_PF
{
    public partial class userRegistration : Form
    {
        public userRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            string[][] str = new string[6][];
            str[0] = new string[50];
            str[1] = new string[50];
            str[2] = new string[50];
            str[3] = new string[50];
            str[4] = new string[50];
            str[5] = new string[30];

            str[0][0] = txtUsername.Text;
            str[0][1] = txt_CardNo.Text;
            str[0][2] = txt_Expdate.Text;
            str[0][3] = txt_CVV.Text;
            str[0][4] = txt_Password.Text;
            str[0][5] = txt_InitialBalance.Text;

            StreamWriter txt = new StreamWriter("users.txt", append: true);
            txt.WriteLine(str[0][0] + "," + str[0][1] + "," + str[0][2] + "," + str[0][3] + "," + str[0][4] + "," + str[0][5]  + "\n");
            txt.Close();

            MessageBox.Show("Registered Successfully ! Redirecting to main page.");

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
