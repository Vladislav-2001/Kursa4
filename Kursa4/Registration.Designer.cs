namespace Kursa4
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBithday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SingUp = new System.Windows.Forms.Button();
            this.Reg = new System.Windows.Forms.Button();
            this.maskedTextBoxMail = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // dateBithday
            // 
            this.dateBithday.CustomFormat = "";
            this.dateBithday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBithday.Location = new System.Drawing.Point(193, 296);
            this.dateBithday.Name = "dateBithday";
            this.dateBithday.Size = new System.Drawing.Size(100, 22);
            this.dateBithday.TabIndex = 4;
            this.dateBithday.Value = new System.DateTime(2020, 10, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата рождения";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(193, 134);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(114, 22);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.Text = "до 20 символов";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(193, 177);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(114, 22);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.UseWaitCursor = true;
            // 
            // SingUp
            // 
            this.SingUp.Location = new System.Drawing.Point(77, 371);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(75, 31);
            this.SingUp.TabIndex = 9;
            this.SingUp.Text = "Войти";
            this.SingUp.UseVisualStyleBackColor = true;
            this.SingUp.Click += new System.EventHandler(this.SingUp_Click);
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(216, 371);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(148, 31);
            this.Reg.TabIndex = 10;
            this.Reg.Text = "Зарегистрировать";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // maskedTextBoxMail
            // 
            this.maskedTextBoxMail.Location = new System.Drawing.Point(193, 218);
            this.maskedTextBoxMail.Mask = "L???????@L????.L??";
            this.maskedTextBoxMail.Name = "maskedTextBoxMail";
            this.maskedTextBoxMail.Size = new System.Drawing.Size(155, 22);
            this.maskedTextBoxMail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пол";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxSex.Location = new System.Drawing.Point(193, 257);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSex.TabIndex = 13;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 430);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxMail);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.SingUp);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateBithday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateBithday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button SingUp;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSex;
    }
}