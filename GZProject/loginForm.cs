using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {  
            InitializeComponent();
        }
       
        string cs = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\Documents\Visual Studio 2015\Projects\GZProject\GZProject\GZKatalog.mdf;Integrated Security = True;";

        private void loginForm_Load(object sender, EventArgs e)
        {
            

        }

        private void logowanieButton_Click(object sender, EventArgs e)
        {
            if (loginAutBox.Text == "" || hasloAutBox.Text == "")
            {
                MessageBox.Show("Wpisz poprawny login i hasło");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Uzytkownicy where Login=@username and Hasło=@password", con);
                cmd.Parameters.AddWithValue("@username", loginAutBox.Text);
                cmd.Parameters.AddWithValue("@password", hasloAutBox.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Witaj szanowny "+loginAutBox.Text);
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Nie udało się zalogować");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Uzytkownicy where Login=@username and Hasło=@password", con);
                cmd.Parameters.AddWithValue("@username", "gosc");
                cmd.Parameters.AddWithValue("@password", "gosc");
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Witaj gościu");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Nie udało się zalogować");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm reg = new RegForm();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
