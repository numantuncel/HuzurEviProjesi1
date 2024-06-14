namespace HuzurEviProjesi1
{
    partial class FrmSakinler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSakinler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNo = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textOda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedKabulT = new System.Windows.Forms.MaskedTextBox();
            this.maskedDoğumT = new System.Windows.Forms.MaskedTextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnÇık = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(827, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnListele
            // 
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.Location = new System.Drawing.Point(12, 224);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(123, 64);
            this.btnListele.TabIndex = 35;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(141, 224);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 64);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGüncelle.Location = new System.Drawing.Point(399, 224);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(123, 64);
            this.btnGüncelle.TabIndex = 43;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(270, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 64);
            this.btnSil.TabIndex = 53;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Doğum T:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(344, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(349, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kabul T:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(349, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Oda No:";
            // 
            // textNo
            // 
            this.textNo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNo.Location = new System.Drawing.Point(113, 12);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(188, 38);
            this.textNo.TabIndex = 13;
            // 
            // textAd
            // 
            this.textAd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAd.Location = new System.Drawing.Point(113, 56);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(188, 38);
            this.textAd.TabIndex = 0;
            // 
            // textSoyad
            // 
            this.textSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyad.Location = new System.Drawing.Point(113, 116);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(188, 38);
            this.textSoyad.TabIndex = 1;
            // 
            // textOda
            // 
            this.textOda.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOda.Location = new System.Drawing.Point(440, 104);
            this.textOda.Name = "textOda";
            this.textOda.Size = new System.Drawing.Size(188, 38);
            this.textOda.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 270);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // maskedKabulT
            // 
            this.maskedKabulT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedKabulT.Location = new System.Drawing.Point(440, 58);
            this.maskedKabulT.Mask = "00/00/0000";
            this.maskedKabulT.Name = "maskedKabulT";
            this.maskedKabulT.Size = new System.Drawing.Size(188, 38);
            this.maskedKabulT.TabIndex = 4;
            this.maskedKabulT.ValidatingType = typeof(System.DateTime);
            // 
            // maskedDoğumT
            // 
            this.maskedDoğumT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedDoğumT.Location = new System.Drawing.Point(113, 160);
            this.maskedDoğumT.Mask = "00/00/0000";
            this.maskedDoğumT.Name = "maskedDoğumT";
            this.maskedDoğumT.Size = new System.Drawing.Size(188, 38);
            this.maskedDoğumT.TabIndex = 2;
            this.maskedDoğumT.ValidatingType = typeof(System.DateTime);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(253, 95);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 35);
            this.btnAra.TabIndex = 23;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // comboDurum
            // 
            this.comboDurum.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.comboDurum.Location = new System.Drawing.Point(440, 150);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(188, 39);
            this.comboDurum.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(357, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Durum:";
            // 
            // textCinsiyet
            // 
            this.textCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCinsiyet.FormattingEnabled = true;
            this.textCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.textCinsiyet.Location = new System.Drawing.Point(440, 11);
            this.textCinsiyet.Name = "textCinsiyet";
            this.textCinsiyet.Size = new System.Drawing.Size(188, 39);
            this.textCinsiyet.TabIndex = 3;
            // 
            // btnÇık
            // 
            this.btnÇık.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnÇık.BackgroundImage")));
            this.btnÇık.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnÇık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÇık.FlatAppearance.BorderSize = 0;
            this.btnÇık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇık.Location = new System.Drawing.Point(1018, 7);
            this.btnÇık.Name = "btnÇık";
            this.btnÇık.Size = new System.Drawing.Size(30, 32);
            this.btnÇık.TabIndex = 27;
            this.btnÇık.UseVisualStyleBackColor = true;
            this.btnÇık.Click += new System.EventHandler(this.btnÇık_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdalar.Location = new System.Drawing.Point(528, 224);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(123, 64);
            this.btnOdalar.TabIndex = 28;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // FrmSakinler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1060, 576);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnÇık);
            this.Controls.Add(this.textCinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.maskedDoğumT);
            this.Controls.Add(this.maskedKabulT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textOda);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.textNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSakinler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sakinler";
            this.Load += new System.EventHandler(this.FrmSakinler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNo;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textOda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedKabulT;
        private System.Windows.Forms.MaskedTextBox maskedDoğumT;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox textCinsiyet;
        private System.Windows.Forms.Button btnÇık;
        private System.Windows.Forms.Button btnOdalar;
    }
}

