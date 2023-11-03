using System;
using System.Collections.Generic;

class CafeSystem
{
    static void Main(string[] args)
    {
        // Kullanıcıdan veri almak için bir Scanner nesnesi tanımla
        Console.WriteLine("Kafe Sistemi");
        Console.WriteLine("Ürünler:");
        
        Dictionary<string, double> urunler = new Dictionary<string, double>
        {
            { "Çay", 2.0 },
            { "Kahve", 3.0 },
            { "Sandviç", 5.0 },
            { "Meyve Suyu", 4.0 }
        };

        Dictionary<string, int> siparisler = new Dictionary<string, int>();

        bool devamEt = true;
        while (devamEt)
        {
            Console.WriteLine("Kantin Ürünleri:");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Key + " - " + urun.Value + " TL");
            }

            Console.WriteLine("Lütfen bir işlem seçin:");
            Console.WriteLine("1. Ürün Satın Alma");
            Console.WriteLine("2. Sipariş Geçmişi Görüntüle");
            Console.WriteLine("3. Çıkış");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    UrunSatinAl(urunler, siparisler);
                    break;
                case 2:
                    SiparisGecmisiGoruntule(siparisler);
                    break;
                case 3:
                    Console.WriteLine("Çıkış yapılıyor...");
                    devamEt = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    public static void UrunSatinAl(Dictionary<string, double> urunler, Dictionary<string, int> siparisler)
    {
        Console.Write("Satın almak istediğiniz ürünü seçin: ");
        string urun = Console.ReadLine();

        if (urunler.ContainsKey(urun))
        {
            Console.Write("Kaç adet almak istiyorsunuz: ");
            int adet = int.Parse(Console.ReadLine);

            double toplamFiyat = urunler[urun] * adet;

            if (siparisler.ContainsKey(urun))
            {
                siparisler[urun] += adet;
            }
            else
            {
                siparisler[urun] = adet;
            }

            Console.WriteLine("Siparişiniz alındı. Toplam Tutar: " + toplamFiyat + " TL");
        }
        else
        {
            Console.WriteLine("Geçersiz ürün seçimi.");
        }
    }

    public static void SiparisGecmisiGoruntule(Dictionary<string, int> siparisler)
    {
        Console.WriteLine("Sipariş Geçmişi:");
        foreach (var siparis in siparisler)
        {
            Console.WriteLine(siparis.Key + " - " + siparis.Value + " adet");
        }
    }
}
