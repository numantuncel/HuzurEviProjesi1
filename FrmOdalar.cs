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
using LogicLayer;

namespace HuzurEviProjesi1
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        public int skngelenOda;
        private void FrmOdalar_Load(object sender, EventArgs e)
        {

            // btn101
            //SqlCommand komut1 = new SqlCommand("Select MevcutDoluluk from Tbl_Odalar where OdaNumarası=@p1", Baglanti.baglan);
            //if (komut1.Connection.State != ConnectionState.Open)
            //{
            //    komut1.Connection.Open();
            //}

            //komut1.Parameters.AddWithValue("@p1", oda101);
            //SqlDataReader veriOku1 = komut1.ExecuteReader();
            //while (veriOku1.Read())
            //{
            //    if (bool.Parse(veriOku1[0].ToString()) == true)
            //    {
            //        btn101.BackColor = Color.Thistle;
            //    }
            //    else
            //    {
            //        btn101.BackColor = Color.White;
            //    }

            //}
            //veriOku1.Close();

            // bu döngü ile yukardaki kodları 12 defa yazmakdan kurtulduk :)


            Button[] buttons = { btn101, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112 };
            for (int i = 0; i < 12; i++)
            {
                SqlCommand komut = new SqlCommand("SELECT Tbl_Odalar.MevcutDoluluk, Tbl_Sakinler.Ad, Tbl_Sakinler.Soyad\r\nFROM Tbl_Odalar\r\nINNER JOIN Tbl_Sakinler ON Tbl_Odalar.OdaNumarası = Tbl_Sakinler.OdaNumarası\r\nWHERE Tbl_Odalar.OdaNumarası = @p", Baglanti.baglan);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@p", i + 1);// 11 buraya geldiğinde +1 yapıp 12 ile tam bitiriyor.
                SqlDataReader veriOku = komut.ExecuteReader();
                while (veriOku.Read())
                {
                    if (bool.Parse(veriOku[0].ToString()) == true)
                    {
                        buttons[i].Text = veriOku[1].ToString() + "\n" + veriOku[2].ToString() + "\n" + buttons[i].Text;
                        buttons[i].BackColor = Color.Thistle;
                        buttons[i].Enabled = false;
                    }
                    else
                    {
                        buttons[i].BackColor = Color.White;
                    }
                }
                veriOku.Close();

            }
        }

        private void btnÇık_Click(object sender, EventArgs e)
        {
            FrmSakinler frmSakinler = new FrmSakinler();
            frmSakinler.gelenPersonelNo = skngelenOda;
            frmSakinler.Show();
            this.Close();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "1";
            frm.Show();
            this.Hide();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "2";
            frm.Show();
            this.Hide();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "3";
            frm.Show();
            this.Hide();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "4";
            frm.Show();
            this.Hide();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "5";
            frm.Show();
            this.Hide();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "6";
            frm.Show();
            this.Hide();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "7";
            frm.Show();
            this.Hide();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "8";
            frm.Show();
            this.Hide();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "9";
            frm.Show();
            this.Hide();
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "10";
            frm.Show();
            this.Hide();
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "11";
            frm.Show();
            this.Hide();
        }

        private void btn112_Click(object sender, EventArgs e)
        {
            FrmSakinler frm = new FrmSakinler();
            frm.GelenOdaNo = "12";
            frm.Show();
            this.Hide();
        }
    }
}

