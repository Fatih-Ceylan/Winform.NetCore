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
        bool IsValid()
        {
            foreach (Control c in errorProvider.ContainerControl.Controls)
                if (errorProvider.GetError(c) != "")
                    return false;
            return true;
        }
        private void buttonShow_Click(object sender , EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("Lütfen Önce Gerekli Alanları Doldurunuz");
            }
            else
            {
                string outputMessage = string.Format("Kullanıcı Adı: " + textName.Text + "\n" + "Kullanıcı Soyadı: " + textSurname.Text + "\n" + "Aylık Maaşı: " + textMonthlySalary.Text , "Kullanıcı Bilgisi");
                MessageBox.Show(outputMessage , "Personel Bilgisi");
            }
            //MessageBox.Show("Kullanıcı Adı: " + textName.Text + "\n" + "Aylık Maaşı: " + textMonthlySalary.Text , "Kullanıcı Bilgisi");
        }
        private void textUserSSId_TextChanged(object sender , EventArgs e)
        {
            //textUserSSId.PlaceholderText = "TC Kimlik No Giriniz...";
        }

        #region ValidatingUserSSId
        private void textUserSSId_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(textUserSSId.Text , out int parsedValue))
            {
                errorProvider.SetError(textUserSSId , "Only numbers allowed");
                textUserSSId.Text = "";
            }
            else
            {
                errorProvider.SetError(textUserSSId , "");
            }
        }
        #endregion
        private void textName_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            //textName.PlaceholderText = "Kullanıcı Adını Lütfen Giriniz...";
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                //Since FormAutoValidate enabled no need e.Cancel definition
                e.Cancel = true;
                errorProvider.SetError(textName , "Name Required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName , "");
            }
        }
        private void textSurname_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            //textSurname.PlaceholderText = "Soyad Giriniz...";
            if (string.IsNullOrWhiteSpace(textSurname.Text))
            {
                errorProvider.SetError(textSurname , "Surname Required!");
                textSurname.Text = "";
            }
            else
            {
                errorProvider.SetError(textSurname , "");
            }
        }
        private void textPhone_Validating(object sender , System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(textPhone.Text , out int parsedValue))
            {
                errorProvider.SetError(textPhone , "Only numbers allowed");
                textPhone.Text = "";
            }
            else
            {
                errorProvider.SetError(textPhone , "");
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
            string commaConvert = textDailySalary.Text.Replace("." , ",");
            if (float.TryParse(commaConvert , out float outputValue))
            {
                textMonthlySalary.Text = (outputValue * 30).ToString("c");
                errorProvider.SetError(textDailySalary , "");
            }
            else
            {
                errorProvider.SetError(textDailySalary , "Only numbers allowed");
                textDailySalary.Clear();
                textMonthlySalary.Text = "";
            }

            #region oldApproach
            //Throws ex when type string or field is empty
            //float daily = textDailySalary.Text != "" ? float.Parse(textDailySalary.Text) : 0;
            //textMonthlySalary.Text = (daily * 30).ToString("c");
            //textMonthlySalary.Text = (float.Parse(textDailySalary.Text) * 30).ToString("c");

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
            //float parsedValue;
            //if (!float.TryParse(textDailySalary.Text , out parsedValue))
            //{
            //    epName.SetError(textDailySalary , "Only numbers allowed");
            //    textMonthlySalary.Text = "";
            //}
        }
        #endregion
        private void Temizle_Click(object sender , EventArgs e)
        {
            ClearTextBoxes(this);
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
        void Clear()
        {           /*Old clear method*/
            //textUserSSId.Text = textName.Text = textSurname.Text = textPhone.Text = richTextAddress.Text = textMonthlySalary.Text = textDailySalary.Text = "";
        }

        //bool CheckEmpty()
        //{
        //    if (string.IsNullOrWhiteSpace(textName.Text))
        //    {
        //        epName.SetError(textName , "Name Required!");
        //    }
        //    return true;
        //}

        //int errorCount;
        //void SetError(Control c , string message)
        //{
        //    if (message == "")
        //        errorCount--;
        //    else
        //        errorCount++;
        //    errorProvider.SetError(c , message);
        //}
    }
}
