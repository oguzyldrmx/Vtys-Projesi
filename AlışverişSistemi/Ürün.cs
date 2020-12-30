using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlışverişSistemi
{
    public class Ürün // Ürün sınıfı
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public int StokAdedi;
        public int HamFiyat;
        public int SecilenAdet;
        public int[] stoklar; //Rastgele oluşan stok sayısını 4 elemanlı diziye atadım ki stokadetlerini farklı farklı atıyayım.
        public Ürün() //Ürün kurucu fonksiyonu
        {
            stoklar = new int[4]; //4 elemanlı stoklar dizisi
            for (int i = 0; i < 4; i++) //4 tane rastgele stokadedi oluşturup bunları diziye atar
            {
                RastgeleStok();
                stoklar[i] = StokAdedi;
            }
        }
        Random rastgelesayi = new Random();
        public void RastgeleStok() //Rastgele stok oluşturan kod
        {

            StokAdedi = rastgelesayi.Next(1, 100);

        }
    }
    class Buzdolabi : Ürün  //Buzdolabı sınıfı
    {
        public int IcHacim;
        public string EnerjiSınıfı;
        public Buzdolabi(string b_Ad, string b_Marka, string b_Model, string b_Ozellik,int b_HamFiyat,int b_SecilenAdet, int b_Hacim, string b_Enerji) //Parametreli kurucu fonksiyon
        {
            Ad = b_Ad;
            Marka = b_Marka;
            Model = b_Model;
            Ozellik = b_Ozellik;
            HamFiyat = b_HamFiyat;
            SecilenAdet = b_SecilenAdet;
            IcHacim = b_Hacim;
            EnerjiSınıfı = b_Enerji;
        }
        public  double KdvUygula()  //Ham fiyata kdv uygular
        {
            double KdvliFiyat;
            KdvliFiyat = HamFiyat * 1.05 * SecilenAdet;
            return KdvliFiyat;
        }
    }
    class LedTv : Ürün //TV sınıfı
    {
        public int EkranBoyutu;
        public string EkranCozunurlugu;

        public LedTv(string tv_Ad, string tv_Marka, string tv_Model, string tv_Ozellik, int tv_HamFiyat, int tv_SecilenAdet, int tv_EkranBoyutu, string tv_EkranCozunurlugu)    //Parametreli kurucu fonksiyon
        {
            Ad = tv_Ad;
            Marka = tv_Marka;
            Model = tv_Model;
            Ozellik = tv_Ozellik;
            HamFiyat = tv_HamFiyat;
            SecilenAdet = tv_SecilenAdet;
            EkranBoyutu = tv_EkranBoyutu;
            EkranCozunurlugu = tv_EkranCozunurlugu;
        }
        public double KdvUygula()    //Ham fiyata kdv uygular
        {
            double KdvliFiyat;
            KdvliFiyat = HamFiyat * 1.18 * SecilenAdet;
            return KdvliFiyat;
        }
    }
    class CepTel : Ürün //Telefon sınıfı
    {
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;
        public CepTel(string cep_Ad, string cep_Marka, string cep_Model, string cep_Ozellik, int cep_HamFiyat, int cep_SecilenAdet,int cep_DahiliHafiza,int cep_RamKapasitesi,int cep_PilGucu)//Parametreli kurucu fonksiyon
        {
            Ad = cep_Ad;
            Marka = cep_Marka;
            Model = cep_Model;
            Ozellik = cep_Ozellik;
            HamFiyat = cep_HamFiyat;
            SecilenAdet = cep_SecilenAdet;
            DahiliHafiza = cep_DahiliHafiza;
            RamKapasitesi = cep_RamKapasitesi;
            PilGucu = cep_PilGucu;
        }
        public double KdvUygula()    //Ham fiyata kdv uygular
        {
            double KdvliFiyat;
            KdvliFiyat = HamFiyat * 1.20 * SecilenAdet;
            return KdvliFiyat;
        }
    }
    class Laptop : Ürün //Laptop sınıfı
    {
        public int EkranBoyutu;
        public string EkranCozunurluk;
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;
        public Laptop(string lap_Ad, string lap_Marka, string lap_Model, string lap_Ozellik, int lap_HamFiyat, int lap_SecilenAdet,int lap_Ekranboyutu,string lap_EkranCozunurluk,int lap_DahiliHafiza,int lap_RamKapasitesi,int lap_PilGucu)
        {
            Ad = lap_Ad;
            Marka = lap_Marka;
            Model = lap_Model;
            Ozellik = lap_Ozellik;
            HamFiyat = lap_HamFiyat;
            SecilenAdet = lap_SecilenAdet;
            EkranBoyutu = lap_Ekranboyutu;
            EkranCozunurluk = lap_EkranCozunurluk;
            DahiliHafiza = lap_DahiliHafiza;
            RamKapasitesi = lap_RamKapasitesi;
            PilGucu = lap_PilGucu;
        }
        public double KdvUygula() //Ham fiyata kdv uygular
        {
            double KdvliFiyat;
            KdvliFiyat = HamFiyat * 1.15 * SecilenAdet;
            return KdvliFiyat;
        }
    }
}
