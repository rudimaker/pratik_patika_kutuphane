using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace pratik_patika_kutuphane
{
    public class Book
    {

        // Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi bilgileri ile kitaplar kaydetmek istiyoruz.


        public string KitapAd;
        public string YazarAd;
        public string YazarSoyad;
        public int SayfaSayısı;
        public string YayınEvi;
        public DateTime KayıtTarihi;


        // 2 Adet constructor alternatifi olsun.

       // Bir tanesi default constructor tarzında parmetre almadan çalışan bir metot.
        public Book()
        {
            KayıtTarihi = DateTime.Now;  // KayıtTarihi nesne oluşturulunca otomatik olarak o an olarak atansın. (Her iki constructor için de geçerli)
        }

        // Diğeri Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot.
        public Book(string kitapad,string yazarad, string yazarsoyad, int sayfasayısı, string yayınevi)
        {
            KitapAd = kitapad;
            YazarAd = yazarad;
            YazarSoyad = yazarsoyad;
            SayfaSayısı = sayfasayısı;
            YayınEvi = yayınevi;

            KayıtTarihi = DateTime.Now; // KayıtTarihi nesne oluşturulunca otomatik olarak o an olarak atansın. (Her iki constructor için de geçerli)
        }


        public void DisplayList()
        {
            Console.WriteLine($"{KitapAd} | {YazarAd} {YazarSoyad} | {SayfaSayısı} | {YayınEvi} | {KayıtTarihi}");
        }















    }
}
