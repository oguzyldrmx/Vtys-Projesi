namespace AlışverişSistemi
{
    partial class AlışverişSistemi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlışverişSistemi));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TVfiyatlabeli = new System.Windows.Forms.Label();
            this.TVStokLabeli = new System.Windows.Forms.Label();
            this.BuzFiyatLabel = new System.Windows.Forms.Label();
            this.BuzStokLabel = new System.Windows.Forms.Label();
            this.LapFiyatLabel = new System.Windows.Forms.Label();
            this.LapStokLabel = new System.Windows.Forms.Label();
            this.CepFiyatLabel = new System.Windows.Forms.Label();
            this.CepStokLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TvAdet = new System.Windows.Forms.NumericUpDown();
            this.LaptopAdet = new System.Windows.Forms.NumericUpDown();
            this.TelefonAdet = new System.Windows.Forms.NumericUpDown();
            this.BuzdolabiAdet = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ToplamFiyat = new System.Windows.Forms.Label();
            this.SepeteEkle = new System.Windows.Forms.Button();
            this.SepetiTemizle = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.FiyatListbox = new System.Windows.Forms.ListBox();
            this.ÜrünListbox = new System.Windows.Forms.ListBox();
            this.AdetListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuzdolabiAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyat :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fiyat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürünlere Ait KDV\'siz Fiyatlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stok :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stok :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stok :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stok :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(213, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(213, 214);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // TVfiyatlabeli
            // 
            this.TVfiyatlabeli.AutoSize = true;
            this.TVfiyatlabeli.Location = new System.Drawing.Point(70, 140);
            this.TVfiyatlabeli.Name = "TVfiyatlabeli";
            this.TVfiyatlabeli.Size = new System.Drawing.Size(41, 13);
            this.TVfiyatlabeli.TabIndex = 13;
            this.TVfiyatlabeli.Text = "label10";
            // 
            // TVStokLabeli
            // 
            this.TVStokLabeli.AutoSize = true;
            this.TVStokLabeli.Location = new System.Drawing.Point(70, 155);
            this.TVStokLabeli.Name = "TVStokLabeli";
            this.TVStokLabeli.Size = new System.Drawing.Size(41, 13);
            this.TVStokLabeli.TabIndex = 14;
            this.TVStokLabeli.Text = "label11";
            // 
            // BuzFiyatLabel
            // 
            this.BuzFiyatLabel.AutoSize = true;
            this.BuzFiyatLabel.Location = new System.Drawing.Point(251, 140);
            this.BuzFiyatLabel.Name = "BuzFiyatLabel";
            this.BuzFiyatLabel.Size = new System.Drawing.Size(41, 13);
            this.BuzFiyatLabel.TabIndex = 15;
            this.BuzFiyatLabel.Text = "label12";
            // 
            // BuzStokLabel
            // 
            this.BuzStokLabel.AutoSize = true;
            this.BuzStokLabel.Location = new System.Drawing.Point(251, 155);
            this.BuzStokLabel.Name = "BuzStokLabel";
            this.BuzStokLabel.Size = new System.Drawing.Size(41, 13);
            this.BuzStokLabel.TabIndex = 16;
            this.BuzStokLabel.Text = "label13";
            // 
            // LapFiyatLabel
            // 
            this.LapFiyatLabel.AutoSize = true;
            this.LapFiyatLabel.Location = new System.Drawing.Point(70, 294);
            this.LapFiyatLabel.Name = "LapFiyatLabel";
            this.LapFiyatLabel.Size = new System.Drawing.Size(41, 13);
            this.LapFiyatLabel.TabIndex = 17;
            this.LapFiyatLabel.Text = "label14";
            // 
            // LapStokLabel
            // 
            this.LapStokLabel.AutoSize = true;
            this.LapStokLabel.Location = new System.Drawing.Point(70, 314);
            this.LapStokLabel.Name = "LapStokLabel";
            this.LapStokLabel.Size = new System.Drawing.Size(41, 13);
            this.LapStokLabel.TabIndex = 18;
            this.LapStokLabel.Text = "label15";
            // 
            // CepFiyatLabel
            // 
            this.CepFiyatLabel.AutoSize = true;
            this.CepFiyatLabel.Location = new System.Drawing.Point(251, 294);
            this.CepFiyatLabel.Name = "CepFiyatLabel";
            this.CepFiyatLabel.Size = new System.Drawing.Size(41, 13);
            this.CepFiyatLabel.TabIndex = 19;
            this.CepFiyatLabel.Text = "label16";
            // 
            // CepStokLabel
            // 
            this.CepStokLabel.AutoSize = true;
            this.CepStokLabel.Location = new System.Drawing.Point(251, 314);
            this.CepStokLabel.Name = "CepStokLabel";
            this.CepStokLabel.Size = new System.Drawing.Size(41, 13);
            this.CepStokLabel.TabIndex = 20;
            this.CepStokLabel.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(210, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Adet :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Adet :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(210, 180);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Adet :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 342);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Adet :";
            // 
            // TvAdet
            // 
            this.TvAdet.Location = new System.Drawing.Point(73, 178);
            this.TvAdet.Name = "TvAdet";
            this.TvAdet.Size = new System.Drawing.Size(30, 20);
            this.TvAdet.TabIndex = 25;
            // 
            // LaptopAdet
            // 
            this.LaptopAdet.Location = new System.Drawing.Point(73, 340);
            this.LaptopAdet.Name = "LaptopAdet";
            this.LaptopAdet.Size = new System.Drawing.Size(30, 20);
            this.LaptopAdet.TabIndex = 26;
            // 
            // TelefonAdet
            // 
            this.TelefonAdet.Location = new System.Drawing.Point(254, 340);
            this.TelefonAdet.Name = "TelefonAdet";
            this.TelefonAdet.Size = new System.Drawing.Size(30, 20);
            this.TelefonAdet.TabIndex = 27;
            // 
            // BuzdolabiAdet
            // 
            this.BuzdolabiAdet.Location = new System.Drawing.Point(254, 178);
            this.BuzdolabiAdet.Name = "BuzdolabiAdet";
            this.BuzdolabiAdet.Size = new System.Drawing.Size(30, 20);
            this.BuzdolabiAdet.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(390, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Sipariş Özeti";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(390, 294);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "KDV\'li toplam fiyat :";
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.AutoSize = true;
            this.ToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamFiyat.Location = new System.Drawing.Point(506, 287);
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.Size = new System.Drawing.Size(0, 20);
            this.ToplamFiyat.TabIndex = 37;
            // 
            // SepeteEkle
            // 
            this.SepeteEkle.Location = new System.Drawing.Point(32, 397);
            this.SepeteEkle.Name = "SepeteEkle";
            this.SepeteEkle.Size = new System.Drawing.Size(116, 23);
            this.SepeteEkle.TabIndex = 38;
            this.SepeteEkle.Text = "Ürünü Sepete Ekle";
            this.SepeteEkle.UseVisualStyleBackColor = true;
            this.SepeteEkle.Click += new System.EventHandler(this.SepeteEkle_Click);
            // 
            // SepetiTemizle
            // 
            this.SepetiTemizle.Location = new System.Drawing.Point(185, 397);
            this.SepetiTemizle.Name = "SepetiTemizle";
            this.SepetiTemizle.Size = new System.Drawing.Size(99, 23);
            this.SepetiTemizle.TabIndex = 39;
            this.SepetiTemizle.Text = "Sepeti Temizle";
            this.SepetiTemizle.UseVisualStyleBackColor = true;
            this.SepetiTemizle.Click += new System.EventHandler(this.SepetiTemizle_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(539, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "KDV\'li fiyat";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(473, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "Ürün";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(390, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Adet";
            // 
            // FiyatListbox
            // 
            this.FiyatListbox.FormattingEnabled = true;
            this.FiyatListbox.Location = new System.Drawing.Point(530, 73);
            this.FiyatListbox.Name = "FiyatListbox";
            this.FiyatListbox.Size = new System.Drawing.Size(76, 160);
            this.FiyatListbox.TabIndex = 35;
            // 
            // ÜrünListbox
            // 
            this.ÜrünListbox.FormattingEnabled = true;
            this.ÜrünListbox.Location = new System.Drawing.Point(448, 73);
            this.ÜrünListbox.Name = "ÜrünListbox";
            this.ÜrünListbox.Size = new System.Drawing.Size(76, 160);
            this.ÜrünListbox.TabIndex = 34;
            // 
            // AdetListbox
            // 
            this.AdetListbox.FormattingEnabled = true;
            this.AdetListbox.Location = new System.Drawing.Point(393, 73);
            this.AdetListbox.Name = "AdetListbox";
            this.AdetListbox.Size = new System.Drawing.Size(36, 160);
            this.AdetListbox.TabIndex = 33;
            // 
            // AlışverişSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 468);
            this.Controls.Add(this.SepetiTemizle);
            this.Controls.Add(this.SepeteEkle);
            this.Controls.Add(this.ToplamFiyat);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.FiyatListbox);
            this.Controls.Add(this.ÜrünListbox);
            this.Controls.Add(this.AdetListbox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.BuzdolabiAdet);
            this.Controls.Add(this.TelefonAdet);
            this.Controls.Add(this.LaptopAdet);
            this.Controls.Add(this.TvAdet);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CepStokLabel);
            this.Controls.Add(this.CepFiyatLabel);
            this.Controls.Add(this.LapStokLabel);
            this.Controls.Add(this.LapFiyatLabel);
            this.Controls.Add(this.BuzStokLabel);
            this.Controls.Add(this.BuzFiyatLabel);
            this.Controls.Add(this.TVStokLabeli);
            this.Controls.Add(this.TVfiyatlabeli);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AlışverişSistemi";
            this.Text = "AlışverişSistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuzdolabiAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label TVfiyatlabeli;
        private System.Windows.Forms.Label TVStokLabeli;
        private System.Windows.Forms.Label BuzFiyatLabel;
        private System.Windows.Forms.Label BuzStokLabel;
        private System.Windows.Forms.Label LapFiyatLabel;
        private System.Windows.Forms.Label LapStokLabel;
        private System.Windows.Forms.Label CepFiyatLabel;
        private System.Windows.Forms.Label CepStokLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown TvAdet;
        private System.Windows.Forms.NumericUpDown LaptopAdet;
        private System.Windows.Forms.NumericUpDown TelefonAdet;
        private System.Windows.Forms.NumericUpDown BuzdolabiAdet;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label ToplamFiyat;
        private System.Windows.Forms.Button SepeteEkle;
        private System.Windows.Forms.Button SepetiTemizle;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox FiyatListbox;
        private System.Windows.Forms.ListBox ÜrünListbox;
        private System.Windows.Forms.ListBox AdetListbox;
    }
}

