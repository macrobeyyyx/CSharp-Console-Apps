using System;

class AirplaneReservationSystem
{
    static void Main(string[] args)
    {
        bool[] koltuklar = new bool[10]; // 10 koltuklu bir uçak

        while (true)
        {
            // Kullanıcıya seçenekleri göster
            Console.WriteLine("Lütfen aşağıdaki seçeneklerden birini seçin:");
            Console.WriteLine("1. Boş koltukları göster");
            Console.WriteLine("2. Koltuk rezervasyonu yap");
            Console.WriteLine("3. Rezervasyonu iptal et");
            Console.WriteLine("4. Çıkış");

            int secim = int.Parse(Console.ReadLine()); // Kullanıcının seçimini al

            switch (secim)
            {
                case 1:
                    BosKoltuklariGoster(koltuklar); // Boş koltukları gösterme işlemini çağır
                    break;
                case 2:
                    RezervasyonYap(koltuklar); // Koltuk rezervasyonu yapma işlemini çağır
                    break;
                case 3:
                    RezervasyonIptalEt(koltuklar); // Rezervasyonu iptal etme işlemini çağır
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor..."); // Çıkış yap ve döngüyü sonlandır
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    // Boş koltukları gösterme işlemi
    public static void BosKoltuklariGoster(bool[] koltuklar)
    {
        Console.WriteLine("Boş koltuklar:");
        for (int i = 0; i < koltuklar.Length; i++)
        {
            if (!koltuklar[i])
            {
                Console.WriteLine("Koltuk " + (i + 1));
            }
        }
    }

    // Koltuk rezervasyonu yapma işlemi
    public static void RezervasyonYap(bool[] koltuklar)
    {
        Console.Write("Rezervasyon yapmak istediğiniz koltuğun numarasını girin: ");
        int koltukNo = int.Parse(Console.ReadLine());

        if (koltukNo < 1 || koltukNo > koltuklar.Length)
        {
            Console.WriteLine("Geçersiz koltuk numarası. Lütfen tekrar deneyin.");
        }
        else if (koltuklar[koltukNo - 1])
        {
            Console.WriteLine("Bu koltuk zaten rezerve edilmiş.");
        }
        else
        {
            koltuklar[koltukNo - 1] = true;
            Console.WriteLine("Rezervasyon tamamlandı. Koltuk " + koltukNo + " sizin.");
        }
    }

    // Rezervasyonu iptal etme işlemi
    public static void RezervasyonIptalEt(bool[] koltuklar)
    {
        Console.Write("Rezervasyonu iptal etmek istediğiniz koltuğun numarasını girin: ");
        int koltukNo = int.Parse(Console.ReadLine);

        if (koltukNo < 1 || koltukNo > koltuklar.Length)
        {
            Console.WriteLine("Geçersiz koltuk numarası. Lütfen tekrar deneyin.");
        }
        else if (!koltuklar[koltukNo - 1])
        {
            Console.WriteLine("Bu koltuk zaten boş.");
        }
        else
        {
            koltuklar[koltukNo - 1] = false;
            Console.WriteLine("Rezervasyon iptal edildi. Koltuk " + koltukNo + " boş.");
        }
    }
}
