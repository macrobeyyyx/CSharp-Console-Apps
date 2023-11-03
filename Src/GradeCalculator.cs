using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        // Kullanıcıdan veri almak için bir Scanner nesnesi oluştur
        Console.Write("Lise mi (L) yoksa Üniversite mi (Ü) okuyorsunuz? (L/Ü): ");
        string okulTuru = Console.ReadLine();

        // Toplam ders sayısını öğren
        Console.Write("Toplam ders sayısını girin: ");
        int toplamDersSayisi = int.Parse(Console.ReadLine());

        // Sınıf geçme notunu öğren
        Console.Write("Sınıf geçme notunu girin: ");
        double sinifGecmeNotu = double.Parse(Console.ReadLine());

        // Toplam not değerini saklamak için bir değişken tanımla (double) ve kalan ders sayısını saklamak için bir değişken tanımla (int)
        double toplamNot = 0;
        int kalanDersSayisi = 0;

        // Girilen ders sayısına göre ders notlarını al ve toplam nota ekle
        for (int i = 1; i <= toplamDersSayisi; i++)
        {
            Console.Write("Ders " + i + " notunu girin: ");
            double dersNotu = double.Parse(Console.ReadLine());
            toplamNot += dersNotu;

            // Ders notu sınıf geçme notundan düşükse, kalan ders sayısını artır
            if (dersNotu < sinifGecmeNotu)
            {
                kalanDersSayisi++;
            }
        }
        // Ortalama notu hesapla
        double ortalamaNot = toplamNot / toplamDersSayisi;
        Console.WriteLine("Ortalama Not: " + ortalamaNot);
        Console.WriteLine("Başarılı Ders Sayısı: " + (toplamDersSayisi - kalanDersSayisi));
        Console.WriteLine("Kalan Ders Sayısı: " + kalanDersSayisi);

        // Mantıksal işlem: Kullanıcının okul türüne ve başarı durumuna göre mesaj ver
        if (okulTuru.Equals("L", StringComparison.OrdinalIgnoreCase)) // Lise
        {
            if (kalanDersSayisi > 3 || ortalamaNot < 55)
            {
                Console.WriteLine("Sınıfta kaldınız!");
            }
            else
            {
                Console.WriteLine("Sınıfı geçtiniz!");
            }
        }
        else if (okulTuru.Equals("Ü", StringComparison.OrdinalIgnoreCase)) // Üniversite
        {
            if (kalanDersSayisi > 2 || ortalamaNot < 60)
            {
                Console.WriteLine("Sınıfta kaldınız!");
            }
            else
            {
                Console.WriteLine("Sınıfı geçtiniz!");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz okul türü seçimi.");
        }
    }
}
