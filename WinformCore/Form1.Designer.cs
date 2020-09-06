namespace WinformCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUserSSId = new System.Windows.Forms.TextBox();
            this.textDailySalary = new System.Windows.Forms.TextBox();
            this.textMonthlySalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextAddress = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxMilitary = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxMilitary.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(250, 368);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(122, 43);
            this.buttonShow.TabIndex = 14;
            this.buttonShow.Text = "Bilgileri Göster";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(13, 218);
            this.textPhone.Name = "textPhone";
            this.textPhone.PlaceholderText = "Telefon No Giriniz";
            this.textPhone.Size = new System.Drawing.Size(142, 23);
            this.textPhone.TabIndex = 3;
            this.textPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textPhone_Validating);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(14, 154);
            this.textSurname.Name = "textSurname";
            this.textSurname.PlaceholderText = "Soyad Giriniz";
            this.textSurname.Size = new System.Drawing.Size(141, 23);
            this.textSurname.TabIndex = 2;
            this.textSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textSurname_Validating);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(13, 99);
            this.textName.Name = "textName";
            this.textName.PlaceholderText = "Ad Giriniz";
            this.textName.Size = new System.Drawing.Size(142, 23);
            this.textName.TabIndex = 1;
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // textUserSSId
            // 
            this.textUserSSId.Location = new System.Drawing.Point(13, 41);
            this.textUserSSId.Name = "textUserSSId";
            this.textUserSSId.PlaceholderText = "TC Kimlik No Giriniz";
            this.textUserSSId.Size = new System.Drawing.Size(142, 23);
            this.textUserSSId.TabIndex = 0;
            this.textUserSSId.TextChanged += new System.EventHandler(this.textUserSSId_TextChanged);
            this.textUserSSId.Validating += new System.ComponentModel.CancelEventHandler(this.textUserSSId_Validating);
            // 
            // textDailySalary
            // 
            this.textDailySalary.Location = new System.Drawing.Point(183, 41);
            this.textDailySalary.Name = "textDailySalary";
            this.textDailySalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textDailySalary.Size = new System.Drawing.Size(189, 23);
            this.textDailySalary.TabIndex = 5;
            this.textDailySalary.TextChanged += new System.EventHandler(this.textDailySalary_TextChanged);
            this.textDailySalary.Validating += new System.ComponentModel.CancelEventHandler(this.textDailySalary_Validating);
            // 
            // textMonthlySalary
            // 
            this.textMonthlySalary.Enabled = false;
            this.textMonthlySalary.Location = new System.Drawing.Point(184, 99);
            this.textMonthlySalary.Name = "textMonthlySalary";
            this.textMonthlySalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textMonthlySalary.Size = new System.Drawing.Size(188, 23);
            this.textMonthlySalary.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Günlük Maaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aylık Maaş";
            // 
            // radioWoman
            // 
            this.radioWoman.AutoSize = true;
            this.radioWoman.Location = new System.Drawing.Point(6, 22);
            this.radioWoman.Name = "radioWoman";
            this.radioWoman.Size = new System.Drawing.Size(55, 19);
            this.radioWoman.TabIndex = 7;
            this.radioWoman.TabStop = true;
            this.radioWoman.Text = "Kadın";
            this.radioWoman.UseVisualStyleBackColor = true;
            this.radioWoman.CheckedChanged += new System.EventHandler(this.radioWoman_CheckedChanged);
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Location = new System.Drawing.Point(67, 22);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(53, 19);
            this.radioMan.TabIndex = 8;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "Erkek";
            this.radioMan.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Adres";
            // 
            // richTextAddress
            // 
            this.richTextAddress.Location = new System.Drawing.Point(13, 275);
            this.richTextAddress.Name = "richTextAddress";
            this.richTextAddress.Size = new System.Drawing.Size(142, 81);
            this.richTextAddress.TabIndex = 4;
            this.richTextAddress.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(56, 368);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 42);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Temizle";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBoxMilitary
            // 
            this.groupBoxMilitary.Controls.Add(this.radioButton4);
            this.groupBoxMilitary.Controls.Add(this.radioButton3);
            this.groupBoxMilitary.Controls.Add(this.radioButton2);
            this.groupBoxMilitary.Controls.Add(this.radioButton1);
            this.groupBoxMilitary.Location = new System.Drawing.Point(183, 200);
            this.groupBoxMilitary.Name = "groupBoxMilitary";
            this.groupBoxMilitary.Size = new System.Drawing.Size(189, 86);
            this.groupBoxMilitary.TabIndex = 10;
            this.groupBoxMilitary.TabStop = false;
            this.groupBoxMilitary.Text = "Askerlik Durumu";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(89, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 19);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Muaf";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(89, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 19);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tecilli";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yapmadı";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yaptı";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButton5);
            this.groupBoxGender.Controls.Add(this.radioMan);
            this.groupBoxGender.Controls.Add(this.radioWoman);
            this.groupBoxGender.Location = new System.Drawing.Point(183, 136);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(189, 55);
            this.groupBoxGender.TabIndex = 7;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Cinsiyet";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(126, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 19);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Diğer";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.groupBoxMilitary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.richTextAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMonthlySalary);
            this.Controls.Add(this.textDailySalary);
            this.Controls.Add(this.textUserSSId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxMilitary.ResumeLayout(false);
            this.groupBoxMilitary.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUserSSId;
        private System.Windows.Forms.TextBox textDailySalary;
        private System.Windows.Forms.TextBox textMonthlySalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextAddress;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxMilitary;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

