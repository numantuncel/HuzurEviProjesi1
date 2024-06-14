namespace LogicLayer
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSakinler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnÇık = new System.Windows.Forms.Button();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textŞifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGüncelle.Location = new System.Drawing.Point(155, 192);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(123, 42);
            this.btnGüncelle.TabIndex = 0;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSakinler
            // 
            this.btnSakinler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSakinler.Location = new System.Drawing.Point(344, 192);
            this.btnSakinler.Name = "btnSakinler";
            this.btnSakinler.Size = new System.Drawing.Size(102, 42);
            this.btnSakinler.TabIndex = 1;
            this.btnSakinler.Text = "Sakinler";
            this.btnSakinler.UseVisualStyleBackColor = true;
            this.btnSakinler.Click += new System.EventHandler(this.btnSakinler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // textAd
            // 
            this.textAd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAd.Location = new System.Drawing.Point(98, 12);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(179, 38);
            this.textAd.TabIndex = 5;
            // 
            // textSoyad
            // 
            this.textSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyad.Location = new System.Drawing.Point(98, 56);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(179, 38);
            this.textSoyad.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(20, 192);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 42);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnÇık
            // 
            this.btnÇık.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnÇık.BackgroundImage")));
            this.btnÇık.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnÇık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÇık.FlatAppearance.BorderSize = 0;
            this.btnÇık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇık.Location = new System.Drawing.Point(20, 250);
            this.btnÇık.Name = "btnÇık";
            this.btnÇık.Size = new System.Drawing.Size(30, 32);
            this.btnÇık.TabIndex = 12;
            this.btnÇık.UseVisualStyleBackColor = true;
            this.btnÇık.Click += new System.EventHandler(this.btnÇık_Click);
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTelefon.Location = new System.Drawing.Point(98, 100);
            this.maskedTelefon.Mask = "(999) 000-0000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(179, 38);
            this.maskedTelefon.TabIndex = 13;
            // 
            // textŞifre
            // 
            this.textŞifre.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textŞifre.Location = new System.Drawing.Point(98, 144);
            this.textŞifre.Name = "textŞifre";
            this.textŞifre.Size = new System.Drawing.Size(179, 38);
            this.textŞifre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şifre:";
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(518, 297);
            this.Controls.Add(this.textŞifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTelefon);
            this.Controls.Add(this.btnÇık);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSakinler);
            this.Controls.Add(this.btnGüncelle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersoneller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSakinler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnÇık;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.TextBox textŞifre;
        private System.Windows.Forms.Label label4;
    }
}