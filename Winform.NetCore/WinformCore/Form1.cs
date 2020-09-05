using System;
using System.Linq;
using System.Windows.Forms;
namespace WinformCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonShow_Click(object sender , EventArgs e)
        {


            string outputMessage = string.Format("Kullanıcı Adı: " + textName.Text + "\n" + "Kullanıcı Soyadı: " + textSurname.Text + "\n" + "Aylık Maaşı: " + textMonthlySalary.Text , "Kullanıcı Bilgisi");
            MessageBox.Show(outputMessage , "Personel Bilgisi");

            //MessageBox.Show("Kullanıcı Adı: " + textName.Text + "\n" + "Aylık Maaşı: " + textMonthlySalary.Text , "Kullanıcı Bilgisi");
        }
        private void textUserId_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            textUserSSId.PlaceholderText = "TC Kimlik No Giriniz...";
            // didn't understand why out parameter is required
            int parsedValue;
            if (!int.TryParse(textUserSSId.Text , out parsedValue))
            {
                epName.SetError(textUserSSId , "Only numbers allowed");
            }
        }
        private void textName_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            textName.PlaceholderText = "Ad Giriniz...";
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                //formAutoValidate enabled
                e.Cancel = true;
                epName.SetError(textName , "Name Required!");
            }
            else
            {
                e.Cancel = false;
                epName.SetError(textName , "");
            }
        }
        private void textSurname_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            //textSurname.PlaceholderText = "Soyad Giriniz...";
            if (string.IsNullOrWhiteSpace(textSurname.Text))
            {
                e.Cancel = true;
                epName.SetError(textSurname , "Surname Required!");
            }
            else
            {
                e.Cancel = false;
                epName.SetError(textSurname , "");
            }
        }
        private void radioWoman_CheckedChanged(object sender , EventArgs e)
        {
            if (radioWoman.Checked)
            {
                groupBoxMilitary.Enabled = false;
                groupBoxMilitary.Controls.OfType<RadioButton>().ToList().ForEach(x => x.Checked = false);
            }
            else
            {
                groupBoxMilitary.Enabled = true;
            }
        }
        private void textDailySalary_TextChanged(object sender , EventArgs e)
        {
            //Throws ex when type string or field is empty
            float daily = textDailySalary.Text != "" ? float.Parse(textDailySalary.Text) : 0;
            textMonthlySalary.Text = (daily * 30).ToString("c");



            //    try
            //    {
            //        textMonthlySalary.Text = (float.Parse(textDailySalary.Text) * 30).ToString("c");
            //    }
            //    catch (Exception ex)
            //    {
            //     
            //        throw ex;
            //    }
            //    float number = 6.58f;
            //    textDailySalary.Text = string.Format("{0:0.00}" , number); 
        }
        private void textDailySalary_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textDailySalary.Text , out parsedValue))
            {
                epName.SetError(textDailySalary , "Only numbers allowed");
            }
            else textDailySalary.Text = "";
        }


        private void textPhone_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textPhone.Text , out parsedValue))
            {
                epName.SetError(textPhone , "Only numbers allowed");
            }
        }
        private void Temizle_Click(object sender , EventArgs e)
        {
            ClearTextBoxes(this);
        }
        void Clear()
        {           /*Old clear method*/
            //textUserSSId.Text = textName.Text = textSurname.Text = textPhone.Text = richTextAddress.Text = textMonthlySalary.Text = textDailySalary.Text = "";
        }
        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox) c).Clear();
                }
                if (c is CheckBox)
                {
                    ((CheckBox) c).Checked = false;
                }
                if (c is RadioButton)
                {
                    ((RadioButton) c).Checked = false;
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox) c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        //bool CheckEmpty()
        //{
        //    if (string.IsNullOrWhiteSpace(textName.Text))
        //    {
        //        epName.SetError(textName , "Name Required!");
        //    }
        //    return true;
        //}
    }
}
