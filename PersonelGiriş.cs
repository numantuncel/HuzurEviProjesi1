using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Runtime.Remoting;
using LogicLayer;

namespace HuzurEviProjesi1
{
    public partial class PersonelGiriş : Form
    {
        public PersonelGiriş()
        {
            InitializeComponent();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (textNo.Text =="" && textŞifre.Text=="")
            {
                MessageBox.Show("Boş Alanları Doldurun.");

            }
            else if (!int.TryParse(textNo.Text, out _))
            {
                MessageBox.Show("No alanına sadece sayısal değerler giriniz.");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Personel where PersonelID=@p1 and Şifre=@p2", Baglanti.baglan);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.AddWithValue("@p1", textNo.Text);
                cmd.Parameters.AddWithValue("@p2", textŞifre.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    reader.Close();
                    FrmPersoneller frmPersoneller = new FrmPersoneller();
                    frmPersoneller.no = int.Parse(textNo.Text);
                    frmPersoneller.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı No yada Şifre Hatalı.");
                }

                Baglanti.baglan.Close();
            }



        }
        private void btnGiriş_MouseHover(object sender, EventArgs e)
        {
            btnGiriş.BackColor = Color.LightGreen;
        }

        private void btnGiriş_MouseLeave(object sender, EventArgs e)
        {
            btnGiriş.BackColor = Color.White;
        }

        private void textNo_TextChanged(object sender, EventArgs e)
        {

            textNo.ForeColor = Color.Black;
        }

        private void textŞifre_TextChanged(object sender, EventArgs e)
        {
            textŞifre.UseSystemPasswordChar = true;
            textŞifre.ForeColor = Color.Black;
        }

        private void PersonelGiriş_Load(object sender, EventArgs e)
        {
           
        }

        private void textNo_Click(object sender, EventArgs e)
        {
            textNo.Text = "";
            textŞifre.Text = "";
        }
    }
}
