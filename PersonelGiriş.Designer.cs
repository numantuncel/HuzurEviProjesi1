namespace HuzurEviProjesi1
{
    partial class PersonelGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGiriş));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textŞifre = new System.Windows.Forms.TextBox();
            this.textNo = new System.Windows.Forms.TextBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // textŞifre
            // 
            this.textŞifre.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textŞifre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textŞifre.Location = new System.Drawing.Point(153, 263);
            this.textŞifre.Name = "textŞifre";
            this.textŞifre.Size = new System.Drawing.Size(179, 38);
            this.textŞifre.TabIndex = 30;
            this.textŞifre.Text = "Şifre";
            this.textŞifre.TextChanged += new System.EventHandler(this.textŞifre_TextChanged);
            // 
            // textNo
            // 
            this.textNo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textNo.Location = new System.Drawing.Point(153, 219);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(179, 38);
            this.textNo.TabIndex = 29;
            this.textNo.Text = "No";
            this.textNo.Click += new System.EventHandler(this.textNo_Click);
            this.textNo.TextChanged += new System.EventHandler(this.textNo_TextChanged);
            // 
            // btnGiriş
            // 
            this.btnGiriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiriş.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiriş.Location = new System.Drawing.Point(174, 307);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(136, 51);
            this.btnGiriş.TabIndex = 31;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            this.btnGiriş.MouseLeave += new System.EventHandler(this.btnGiriş_MouseLeave);
            this.btnGiriş.MouseHover += new System.EventHandler(this.btnGiriş_MouseHover);
            // 
            // PersonelGiriş
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(484, 365);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.textŞifre);
            this.Controls.Add(this.textNo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.PersonelGiriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textŞifre;
        private System.Windows.Forms.TextBox textNo;
        private System.Windows.Forms.Button btnGiriş;
    }
}