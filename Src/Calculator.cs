using System;

class Calculator
{
    static void Main(string[] args)
    {
        // Kullanıcıdan veri almak için bir Scanner nesnesi oluştur
        Console.WriteLine("Basit Hesap Makinesi");
        Console.Write("İşlem seçin (+, -, *, /): ");
        // Kullanıcının seçtiği işlem türünü al
        char islemTuru = Console.ReadLine()[0];

        // İşlem için kullanılacak iki sayıyı al
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        // Sonuç değişkenini başlangıçta sıfıra ayarla
        int sonuc = 0;

        // Eğer işlem türü bölme (/) ise
        if (islemTuru == '/') {
            // Koşul açılıyor: Eğer ikinci sayı sıfıra eşit değilse
            if (sayi2 != 0) {
                // Bölme işlemi yapılır
                double bolme = (double) sayi1 / sayi2;
                Console.WriteLine("Sonuç: " + bolme);
                return; // Programın sonlandırılmasını sağlar
            } else {
                // Eğer ikinci sayı sıfırsa, sıfıra bölme hatası alınır
                Console.WriteLine("Hata: Sıfıra bölme hatası!");
                return; // Programın sonlandırılmasını sağlar
            }
        } else if (islemTuru == '+') {
            sonuc = sayi1 + sayi2;
        } else if (islemTuru == '-') {
            sonuc = sayi1 - sayi2;
        } else if (islemTuru == '*') {
            sonuc = sayi1 * sayi2;
        } else {
            // Geçersiz işlem hatası alınır (örneğin: ())
            Console.WriteLine("Geçersiz işlem.");
            return; // Programın sonlandırılmasını sağlar
        }

        Console.WriteLine("Sonuç: " + sonuc);
    }
}
