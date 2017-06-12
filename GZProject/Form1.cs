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

        private void button1_Click(object sender, EventArgs e)
        {
            using (GZKatalogEntities bazaKatalog = new GZKatalogEntities())
            {
                string s = "Lista Uzytkownikow: \n";
                foreach (Uzytkownik u in bazaKatalog.Uzytkownicy)
                    s += u.Imię + " " + u.Nazwisko + " " + " "+ u.Login +" " + u.E_mail + "\n";
                MessageBox.Show(s);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
