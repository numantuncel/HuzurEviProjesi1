using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuzurEviProjesi1
{
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            List<EntityPersoneller> per = LogicPersonel.LPersonelListele();
            dataGridView1.DataSource = per;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            EntityPersoneller ent =new EntityPersoneller();

            ent.Ad = textAd.Text;
            ent.Soyad=textSoyad.Text;
            ent.Telefon=maskedTelefon.Text;
            ent.Şifre = textŞifre.Text;

            LogicPersonel.LPersonelEkle(ent);
            MessageBox.Show("Ekleme İşlemi Başarılı");

            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();  
            textŞifre.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            EntityPersoneller ent =new EntityPersoneller();

            ent.Ad=textAd.Text;
            ent.Soyad= textSoyad.Text;
            ent.Telefon =maskedTelefon.Text;
            ent.Şifre=textŞifre.Text;
            ent.Id = int.Parse(textNo.Text);

            LogicPersonel.PersonelGüncele(ent);
            MessageBox.Show("Güncelleme İşlemi Başarılı.");

            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersoneller ent = new EntityPersoneller();

            ent.Id=int.Parse(textNo.Text);

            LogicPersonel.PersoneSil(ent.Id);
            MessageBox.Show("Silme İşlemi Başarılı.");

            Listele();

        }
    }
}
