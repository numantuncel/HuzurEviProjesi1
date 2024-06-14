using DataAccessLayer;
using EntityLayer;
using HuzurEviProjesi1;
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

namespace LogicLayer
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        public int no;
        private void btnSakinler_Click(object sender, EventArgs e)
        {
            FrmSakinler frmSakinler = new FrmSakinler();
            frmSakinler.gelenPersonelNo = no;
            frmSakinler.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frmPersonelEkle = new FrmPersonelEkle();
            frmPersonelEkle.Show();
            this.Hide();
        }

        private void btnÇık_Click(object sender, EventArgs e)
        {
            PersonelGiriş personelGiriş = new PersonelGiriş();
            personelGiriş.Show();
            this.Close();
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Ad,Soyad,Telefon,Şifre from Tbl_Personel where PersonelID=@p1", Baglanti.baglan);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", no);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                
                textAd.Text = veriOku[0].ToString();
                textSoyad.Text = veriOku[1].ToString();
                maskedTelefon.Text = veriOku[2].ToString();
                textŞifre.Text = veriOku[3].ToString();
            }
            veriOku.Close();
            Baglanti.baglan.Close();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (no != null)
            {
                EntityPersoneller ent = new EntityPersoneller();

                ent.Ad = textAd.Text;
                ent.Soyad = textSoyad.Text;
                ent.Telefon = maskedTelefon.Text;
                ent.Şifre=textŞifre.Text;
                ent.Id = no;

                LogicPersonel.PersonelGüncele(ent);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız.");
            }
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.Show();
            this.Hide();
        }
    }
}
