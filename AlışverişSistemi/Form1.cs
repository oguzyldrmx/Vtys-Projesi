using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlışverişSistemi
{
    public partial class AlışverişSistemi : Form
    {
        public AlışverişSistemi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5252;Database=dbProje; user ID=postgres;password=56791384812o");
        private void Form1_Load(object sender, EventArgs e)
        {
            Ürün ürün = new Ürün();
            Buzdolabi b1 = new Buzdolabi("Buzdobali", "Nevo", "Nevo13", "Kokusuz", 3500, Convert.ToInt32(BuzdolabiAdet.Value), 1000, "B"); //Nesneler oluşturuldu
            LedTv tv1 = new LedTv("TV", "Evo", "Evo10", "HD", 4000, Convert.ToInt32(TvAdet.Value), 20, "FHD");
            Laptop lap1 = new Laptop("PC", "Acid", "A100", "i9", 6000, Convert.ToInt32(LaptopAdet.Value), 1920, "FHD", 2, 16, 3400);
            CepTel cep1 = new CepTel("Akıllı Telefon", "Ayfon", "S5", "Smart", 2500, Convert.ToInt32(TelefonAdet.Value), 1, 4, 2000);
            TVfiyatlabeli.Text = tv1.HamFiyat.ToString();
            BuzFiyatLabel.Text = b1.HamFiyat.ToString();
            LapFiyatLabel.Text = lap1.HamFiyat.ToString();
            CepFiyatLabel.Text = cep1.HamFiyat.ToString();

            TVStokLabeli.Text = ürün.stoklar[0].ToString();
            BuzStokLabel.Text = ürün.stoklar[1].ToString();
            LapStokLabel.Text = ürün.stoklar[2].ToString();
            CepStokLabel.Text = ürün.stoklar[3].ToString();

        }

        private void SepeteEkle_Click(object sender, EventArgs e) 
        {
            AdetListbox.Items.Clear(); //Adet listboxunu temizler
            ÜrünListbox.Items.Clear(); //Ürün listboxunu temizler
            FiyatListbox.Items.Clear(); //Fiyat listboxunu temizler.
            Buzdolabi b1 = new Buzdolabi("Buzdobali", "Nevo", "Nevo13", "Kokusuz", 3500, Convert.ToInt32(BuzdolabiAdet.Value), 1000, "B");
            LedTv tv1 = new LedTv("TV", "Evo", "Evo10", "HD", 4000, Convert.ToInt32(TvAdet.Value), 20, "FHD");
            Laptop lap1 = new Laptop("PC", "Acid", "A100", "i9", 6000, Convert.ToInt32(LaptopAdet.Value), 1920, "FHD", 2, 16, 3400);
            CepTel cep1 = new CepTel("Akıllı Telefon", "Ayfon", "S5", "Smart", 2500, Convert.ToInt32(TelefonAdet.Value), 1, 4, 2000);
            //Sepet sınıfını pek anlayamadığım için sepet sınıfını kullanmadım.
            if (TvAdet.Value != 0 && Convert.ToInt32(TVStokLabeli.Text)!=0)  //Stok adedi 0 değil ve Adet seçimi 0 değilse sepete ekler.
            {
                TvAdet.Maximum = Convert.ToDecimal(TVStokLabeli.Text);  //Adet seçimini en fazla stok sayısı kadar seçebilir.
                AdetListbox.Items.Add(TvAdet.Value);  //Adet sayısını listboxa ekler
                ÜrünListbox.Items.Add(tv1.Ad);  //Ürün ismini listboxa ekler
                FiyatListbox.Items.Add(tv1.KdvUygula()); //Ürün KDV li fiyatini fiyat listboxuna ekler.
                TVStokLabeli.Text = (Convert.ToInt32(TVStokLabeli.Text) - TvAdet.Value).ToString();  //Eklediğimiz adet kadar ürünü stoktan siler.
                if(Convert.ToInt32(TVStokLabeli.Text)==0)   //Stok sayısı tükenince uyarı verir ve adet seçimini engeller.
                {
                    MessageBox.Show("TV Ürününün stokları tükenmiştir..!");
                    TvAdet.Enabled=false;
                }
            }
            if (BuzdolabiAdet.Value != 0 && Convert.ToInt32(BuzStokLabel.Text) != 0) //Stok adedi 0 değil ve Adet seçimi 0 değilse sepete ekler.
            {
                BuzdolabiAdet.Maximum = Convert.ToDecimal(BuzStokLabel.Text);//Adet seçimini en fazla stok sayısı kadar seçebilir.
                AdetListbox.Items.Add(BuzdolabiAdet.Value);//Adet sayısını listboxa ekler
                ÜrünListbox.Items.Add(b1.Ad);//Ürün ismini listboxa ekler
                FiyatListbox.Items.Add(b1.KdvUygula()); //Ürün KDV li fiyatini fiyat listboxuna ekler.
                BuzStokLabel.Text = (Convert.ToInt32(BuzStokLabel.Text) - BuzdolabiAdet.Value).ToString(); //Eklediğimiz adet kadar ürünü stoktan siler.
                if (Convert.ToInt32(BuzStokLabel.Text) == 0)   //Stok sayısı tükenince uyarı verir ve adet seçimini engeller.
                {
                    MessageBox.Show("Buzdolabi Ürününün stokları tükenmiştir..!");
                    BuzdolabiAdet.Enabled=false;
                }
            }
            if(LaptopAdet.Value!=0 && Convert.ToInt32(LapStokLabel.Text)!=0) //Stok adedi 0 değil ve Adet seçimi 0 değilse sepete ekler.
            {
                LaptopAdet.Maximum = Convert.ToDecimal(LapStokLabel.Text); //Adet seçimini en fazla stok sayısı kadar seçebilir.
                AdetListbox.Items.Add(LaptopAdet.Value); //Adet sayısını listboxa ekler
                ÜrünListbox.Items.Add(lap1.Ad);  //Ürün ismini listboxa ekler
                FiyatListbox.Items.Add(lap1.KdvUygula());       //Ürün KDV li fiyatini fiyat listboxuna ekler.
                LapStokLabel.Text = (Convert.ToInt32(LapStokLabel.Text) - LaptopAdet.Value).ToString();     //Eklediğimiz adet kadar ürünü stoktan siler.
                if (Convert.ToInt32(LapStokLabel.Text) == 0)        //Stok sayısı tükenince uyarı verir ve adet seçimini engeller.
                {
                    MessageBox.Show("Laptop Ürününün stokları tükenmiştir..!");
                    LaptopAdet.Enabled=false;
                }
            }
            if(TelefonAdet.Value!=0 && Convert.ToInt32(CepStokLabel.Text)!=0)   //Stok adedi 0 değil ve Adet seçimi 0 değilse sepete ekler.
            {
                TelefonAdet.Maximum = Convert.ToDecimal(CepStokLabel.Text);  //Adet seçimini en fazla stok sayısı kadar seçebilir.
                AdetListbox.Items.Add(TelefonAdet.Value);   //Adet sayısını listboxa ekler
                ÜrünListbox.Items.Add(cep1.Ad);   //Ürün ismini listboxa ekler
                FiyatListbox.Items.Add(cep1.KdvUygula());  //Ürün KDV li fiyatini fiyat listboxuna ekler.
                CepStokLabel.Text = (Convert.ToInt32(CepStokLabel.Text) - TelefonAdet.Value).ToString(); //Eklediğimiz adet kadar ürünü stoktan siler.
                if (Convert.ToInt32(CepStokLabel.Text) == 0)    //Stok sayısı tükenince uyarı verir ve adet seçimini engeller.
                {
                    MessageBox.Show("Telefon Ürününün stokları tükenmiştir..!");
                    TelefonAdet.Enabled=false;
                }
            }
            ToplamFiyat.Text = (tv1.KdvUygula() + b1.KdvUygula() + lap1.KdvUygula() + cep1.KdvUygula()).ToString(); //Sepetteki ürünlerin KDV'Lİ Fiyatı toplayıp labeline yazar.
        }

        private void SepetiTemizle_Click(object sender, EventArgs e) //Sepeti temizle butonu
        {
            Buzdolabi b1 = new Buzdolabi("Buzdobali", "Nevo", "Nevo13", "Kokusuz", 3500, Convert.ToInt32(BuzdolabiAdet.Value), 1000, "B"); // Nesneler tanımlandı.
            LedTv tv1 = new LedTv("TV", "Evo", "Evo10", "HD", 4000, Convert.ToInt32(TvAdet.Value), 20, "FHD");
            Laptop lap1 = new Laptop("PC", "Acid", "A100", "i9", 6000, Convert.ToInt32(LaptopAdet.Value), 1920, "FHD", 2, 16, 3400);
            CepTel cep1 = new CepTel("Akıllı Telefon", "Ayfon", "S5", "Smart", 2500, Convert.ToInt32(TelefonAdet.Value), 1, 4, 2000);
            TVStokLabeli.Text = (Convert.ToInt32(TVStokLabeli.Text) + TvAdet.Value).ToString();  //Sepete eklenen ürün adetini geri stoklara ekler.
            BuzStokLabel.Text = (Convert.ToInt32(BuzStokLabel.Text) + BuzdolabiAdet.Value).ToString();  //Sepete eklenen ürün adetini geri stoklara ekler.
            LapStokLabel.Text = (Convert.ToInt32(LapStokLabel.Text) + LaptopAdet.Value).ToString(); //Sepete eklenen ürün adetini geri stoklara ekler.
            CepStokLabel.Text = (Convert.ToInt32(CepStokLabel.Text) + TelefonAdet.Value).ToString();    //Sepete eklenen ürün adetini geri stoklara ekler.

            AdetListbox.Items.Clear();  //Listboxları temizler
            ÜrünListbox.Items.Clear();
            FiyatListbox.Items.Clear();

            TvAdet.Enabled = true;  //Stok sayısı biten ürünlerin adet seçimini kullanıma tekrar açar.
            BuzdolabiAdet.Enabled = true;
            TelefonAdet.Enabled = true;
            LaptopAdet.Enabled = true;

            TvAdet.Value = 0;  //Adet seçimini 0 yapar
            BuzdolabiAdet.Value = 0;
            LaptopAdet.Value = 0;
            TelefonAdet.Value = 0;

            ToplamFiyat.Text = "0"; //Toplam labelini 0 lar.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
