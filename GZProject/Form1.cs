using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void loginRegBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginRegBox.Text))
            {
                ValidateLabel.Text = ValidateLabel.Text + "\nPole Login nie może być puste";
            }
            else
                ValidateLabel.Text = "";
        }

        private void emailRegBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(emailRegBox.Text))
            {
                ValidateLabel.Text = "";
            }
            else
            {
                ValidateLabel.Text = "Podany adres e-mail jest niepoprawny";
            }
        }

        private void hasloRegBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(hasloRegBox.Text))
            {
                ValidateLabel.Text = ValidateLabel.Text + "\nPole Hasło nie może być puste";
            }
            else
                ValidateLabel.Text = "";
        }

        private void confirmRegButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ValidateLabel.Text))
            {
                //MessageBox.Show("dupa");
                using (GZKatEntities bazaKatalog = new GZKatEntities())
                {
                    Uzytkownik nowyUzytkownik = new Uzytkownik()
                    {
                        Login = loginRegBox.Text,
                        Hasło = hasloRegBox.Text,
                        Imię = imieRegBox.Text,
                        Nazwisko = nazwiskoRegBox.Text,
                        E_mail = emailRegBox.Text,
                        //Data_urodzenia = dataurReg.Value.Date
                    };
                    bazaKatalog.Uzytkownicy.Add(nowyUzytkownik);
                    bazaKatalog.SaveChanges();
                    MessageBox.Show("Uzytkownik " + loginRegBox.Text + " został dodany");
                }
            }
            else
            {
                MessageBox.Show("Podane dane są nieprawidłowe");
            }
        }
    }
}
