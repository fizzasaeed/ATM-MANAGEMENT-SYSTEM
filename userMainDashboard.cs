using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_System_PF
{
    public partial class userMainDashboard : Form
    {
        string usname;
        public userMainDashboard(string username)
        {
            usname = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            string bal;
            int balanceU;
            double totalB;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"users.txt"))
            {
                try
                {
                    string[] strArr = new string[6];
                    strArr = line.Split(',');

                    if (usname == strArr[0]) { 
                        bal = strArr[5];
                        balanceU = Convert.ToInt32(bal);
                        totalB = Convert.ToDouble(txt_DepositCash.Text) + balanceU;
                        MessageBox.Show("Total Balance Is: " + Convert.ToString(totalB));
                    }

                }
                catch { }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bal;
            int balanceU;
            double totalB;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"users.txt"))
            {
                try
                {
                    string[] strArr = new string[6];
                    strArr = line.Split(',');

                    if (usname == strArr[0])
                    {
                        bal = strArr[5];
                        balanceU = Convert.ToInt32(bal);
                        totalB = balanceU - Convert.ToDouble(txt_CashWithdrawal.Text);
                        MessageBox.Show("Total Remaining Balance Is: " + Convert.ToString(totalB));
                    }

                }
                catch { }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bal;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"users.txt"))
            {
                try
                {
                    string[] strArr = new string[6];
                    strArr = line.Split(',');

                    if (usname == strArr[0])
                    {
                        bal = strArr[5];
                        MessageBox.Show("Current Balance Is: " + bal);
                    }

                }
                catch { }
            }
        }
    }
}
