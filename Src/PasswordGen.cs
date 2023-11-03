using System;
using System.Security.Cryptography;
using System.Text;

class PasswordGen
{
    static void Main(string[] args)
    {
        // Kullanıcıdan veri alacak bir Scanner yerine Console kullanıyoruz
        Console.Write("Şifre uzunluğunu girin: ");
        int uzunluk = int.Parse(Console.ReadLine());

        // Şifre oluştur
        string sifre = SifreOlustur(uzunluk);

        // Oluşturulan şifreyi ekrana yazdır
        Console.WriteLine("Oluşturulan şifre: " + sifre);
    }

    // "SifreOlustur" fonksiyonu, Java'daki sifreOlustur fonksiyonunun C# sürümüdür
    public static string SifreOlustur(int uzunluk)
    {
        string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";
        using (RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider())
        {
            byte[] data = new byte[uzunluk];
            cryptoProvider.GetBytes(data);

            StringBuilder sifre = new StringBuilder(uzunluk);
            foreach (byte b in data)
            {
                sifre.Append(karakterler[b % karakterler.Length]);
            }

            // Şifreyi metine dökme ve döndürme
            return sifre.ToString();
        }
    }
}
