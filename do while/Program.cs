using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan limit değeri alıyoruz
        Console.Write("Bir limit değeri giriniz: ");
        int limit = int.Parse(Console.ReadLine());

        // While Döngüsü ile Çözüm
        Console.WriteLine("\n--- While Döngüsü Çözümü ---");
        int sayac1 = 0; // Sayaç başlangıç değeri
        while (sayac1 <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım - While");
            sayac1++; // Sayaç 1 artırılıyor
        }

        /*
         While döngüsü açıklaması:
         - Döngüye girmeden önce koşul (sayac1 <= limit) kontrol edilir.
         - Eğer koşul sağlanmazsa döngü çalışmaz.
        */

        // Do-While Döngüsü ile Çözüm
        Console.WriteLine("\n--- Do-While Döngüsü Çözümü ---");
        int sayac2 = 0; // Sayaç başlangıç değeri
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım - Do-While");
            sayac2++; // Sayaç 1 artırılıyor
        }
        while (sayac2 <= limit);

        /*
         Do-While döngüsü açıklaması:
         - Döngü koşul kontrol edilmeden çalıştırılır.
         - Döngüye mutlaka 1 kez girilir.
         - Daha sonra koşul (sayac2 <= limit) kontrol edilir.
        */
    }
}
