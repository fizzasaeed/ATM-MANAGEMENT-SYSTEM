
namespace ATM_System_PF
{
    partial class userRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txt_CardNo = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Expdate = new System.Windows.Forms.TextBox();
            this.txt_CVV = new System.Windows.Forms.TextBox();
            this.txt_InitialBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_register
            // 
            this.BTN_register.BackColor = System.Drawing.Color.Transparent;
            this.BTN_register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_register.FlatAppearance.BorderSize = 2;
            this.BTN_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_register.Location = new System.Drawing.Point(477, 268);
            this.BTN_register.Name = "BTN_register";
            this.BTN_register.Size = new System.Drawing.Size(149, 37);
            this.BTN_register.TabIndex = 7;
            this.BTN_register.Text = "Proceed";
            this.BTN_register.UseVisualStyleBackColor = false;
            this.BTN_register.Click += new System.EventHandler(this.BTN_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(330, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Get yourself Registered.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(727, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(419, 81);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(265, 29);
            this.txtUsername.TabIndex = 8;
            // 
            // txt_CardNo
            // 
            this.txt_CardNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CardNo.Location = new System.Drawing.Point(419, 116);
            this.txt_CardNo.Name = "txt_CardNo";
            this.txt_CardNo.PlaceholderText = "Card Number";
            this.txt_CardNo.Size = new System.Drawing.Size(265, 29);
            this.txt_CardNo.TabIndex = 9;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(419, 186);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Password";
            this.txt_Password.Size = new System.Drawing.Size(265, 29);
            this.txt_Password.TabIndex = 10;
            // 
            // txt_Expdate
            // 
            this.txt_Expdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Expdate.Location = new System.Drawing.Point(419, 151);
            this.txt_Expdate.Name = "txt_Expdate";
            this.txt_Expdate.PlaceholderText = "Expiry Date";
            this.txt_Expdate.Size = new System.Drawing.Size(130, 29);
            this.txt_Expdate.TabIndex = 11;
            // 
            // txt_CVV
            // 
            this.txt_CVV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CVV.Location = new System.Drawing.Point(555, 151);
            this.txt_CVV.Name = "txt_CVV";
            this.txt_CVV.PlaceholderText = "CVV";
            this.txt_CVV.Size = new System.Drawing.Size(129, 29);
            this.txt_CVV.TabIndex = 12;
            // 
            // txt_InitialBalance
            // 
            this.txt_InitialBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_InitialBalance.Location = new System.Drawing.Point(419, 221);
            this.txt_InitialBalance.Name = "txt_InitialBalance";
            this.txt_InitialBalance.PlaceholderText = "Initial Balance";
            this.txt_InitialBalance.Size = new System.Drawing.Size(265, 29);
            this.txt_InitialBalance.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(644, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Digital Systems";
            // 
            // userRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM_System_PF.Properties.Resources._360_F_161461682_jD3Ie4iH6ofcjv6Clgab0NKLOAA5lB0K;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_InitialBalance);
            this.Controls.Add(this.txt_CVV);
            this.Controls.Add(this.txt_Expdate);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_CardNo);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.BTN_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txt_CardNo;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Expdate;
        private System.Windows.Forms.TextBox txt_CVV;
        private System.Windows.Forms.TextBox txt_InitialBalance;
        private System.Windows.Forms.Label label2;
    }
}