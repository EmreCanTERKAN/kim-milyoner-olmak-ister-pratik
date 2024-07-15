using System;

class Program
{
    static void Main()
    {
        int dogruCevapSayisi = 0;

        Console.WriteLine("1 -> Türkiyenin Başkenti Neresidir ?");
        Console.WriteLine("a) Afyon  b) Ankara");
        string cevap1 = Console.ReadLine().Trim().ToLower();

        if (cevap1 == "b")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else if (cevap1 == "a")
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap: b) Ankara'dır.");
        }
        else
        {
            Console.WriteLine("Geçersiz cevap!");
        }

 
        Console.WriteLine("2 -> Tavuk mu yumurtadan çıkar Yumurtamı Tavuktan ?");
        Console.WriteLine("a) Tavuk  b) Yumurta c) İkiside");
        string cevap2 = Console.ReadLine().Trim().ToLower();


        if (cevap2 == "c")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else if (cevap2 == "b")
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap: c) İkiside");
        }
        else if (cevap2 == "a")
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap: c) İkiside");
        }
        else
        {
            Console.WriteLine("Geçersiz cevap!");
        }

        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("Tebrikler! Büyük ödülü kazandınız: 1 Milyon TL");
        }
        else
        {

            Console.WriteLine("Dünya Düz müdür Yuvarlak mı ?");
            Console.WriteLine("a) Düz  b) Yuvarlak");
            string cevap3 = Console.ReadLine().Trim().ToLower();

            // Üçüncü sorunun cevabını kontrol ediyoruz
            if (cevap3 == "b")
            {
                Console.WriteLine("Doğru cevap!");
                dogruCevapSayisi++;
            }
            else if (cevap3 == "a")
            {
                Console.WriteLine("Yanlış cevap. Doğru cevap: a) Yuvarlaktır");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap!");
            }

            if (dogruCevapSayisi >= 2)
            {
                Console.WriteLine("Tebrikler! Büyük ödülü kazandınız: 1 Milyon TL");
            }
            else
            {
                Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız.");
            }
        }
    }
}
