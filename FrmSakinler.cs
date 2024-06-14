using DataAccessLayer;
using EntityLayer;
using LogicLayer;
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

namespace HuzurEviProjesi1
{
    public partial class FrmSakinler : Form
    {
        public FrmSakinler()
        {
            InitializeComponent();
        }
        public string GelenOdaNo;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textCinsiyet.Text = "Bay";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textCinsiyet.Text = "Bayan";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateTime dogumTarihi = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            maskedDoğumT.Text = dogumTarihi.ToString("dd-MM-yyyy");
            textCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            DateTime kabulTarihi = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            maskedKabulT.Text = kabulTarihi.ToString("dd-MM-yyyy");
            textOda.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString())==true) 
            {
                comboDurum.Text = "Dolu";
            }
            else
            {
                comboDurum.Text = "Boş";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntitySakinler> SakinListesi = LogicSakinler.LSakinlerListesi();
            dataGridView1.DataSource = SakinListesi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textOda.Text != "" && maskedDoğumT.Text != "" && maskedKabulT.Text != "")
            {
                EntitySakinler skn = new EntitySakinler();
                skn.Ad = textAd.Text;
                skn.Soyad = textSoyad.Text;
                skn.DogumTarihi = DateTime.Parse(maskedDoğumT.Text);
                skn.Cinsiyet = textCinsiyet.Text;
                skn.KabulTarihi = DateTime.Parse(maskedKabulT.Text);
                skn.OdaNumarası = Convert.ToInt16(textOda.Text);
                if (comboDurum.Text == "Dolu")
                {
                    skn.MevcutDoluluk = true;
                }
                else
                {
                    skn.MevcutDoluluk = false;
                }

                LogicSakinler.LSakinEkle(skn);
                MessageBox.Show("Ekleme İşlemi Başarılı.");
            }
            else
            {

                MessageBox.Show("Ekleme İşlemi Başarısız.");
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textNo.Text != "")
            {
                EntitySakinler skn = new EntitySakinler();
                skn.Id = int.Parse(textNo.Text);
                skn.OdaNumarası = Convert.ToInt16(textOda.Text);
                LogicSakinler.LSakinSil(skn);
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız.");
            }


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (textNo.Text!="")
            {
                EntitySakinler skn = new EntitySakinler();
                skn.Ad = textAd.Text;
                skn.Soyad = textSoyad.Text;
                skn.DogumTarihi = DateTime.Parse(maskedDoğumT.Text);
                skn.Cinsiyet = textCinsiyet.Text;
                skn.KabulTarihi = DateTime.Parse(maskedKabulT.Text);
                skn.OdaNumarası = Convert.ToInt16(textOda.Text);
                skn.Id=int.Parse(textNo.Text);
                if (comboDurum.Text == "Dolu")
                {
                    skn.MevcutDoluluk = true;
                }
                else
                {
                    skn.MevcutDoluluk = false;
                }

                LogicSakinler.LSakinGüncelle(skn);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");

            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız.");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select SakinID, Ad,Soyad,DoğumTarihi,Cinsiyet,KabulTarihi ,Tbl_Odalar.OdaNumarası,Tbl_Odalar.MevcutDoluluk \r\nfrom Tbl_Sakinler\r\ninner join Tbl_Odalar on Tbl_Odalar.OdaNumarası=Tbl_Sakinler.OdaNumarası WHERE  Soyad LIKE '%' + @p1 + '%'", Baglanti.baglan);//'%' + @p1 + '%' içinde aramk istersen
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",textSoyad.Text);
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable ds= new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }
        FrmPersoneller frmPersoneller = new FrmPersoneller();
        public int gelenPersonelNo;
        private void FrmSakinler_Load(object sender, EventArgs e)
        {
            comboDurum.Text = "Dolu";
            textCinsiyet.Text = "Bay";
            textOda.Text = GelenOdaNo;
            frmPersoneller.no= gelenPersonelNo;

        }

        private void btnÇık_Click(object sender, EventArgs e)
        {
            FrmPersoneller frmPersoneller = new FrmPersoneller();
            frmPersoneller.no = gelenPersonelNo;
            frmPersoneller.Show();
            this.Close();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.skngelenOda = gelenPersonelNo;
            frmOdalar.Show();
            this.Hide();
        }
    }
}
