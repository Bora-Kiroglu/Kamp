using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string oyunİsmi = "Stardew Valley";
            int insanSayisi = 29;
            double saat = 14.10;
            bool oyunGüzelMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else 
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (oyunGüzelMi == true)
            {
                Console.WriteLine("Evet bence de ");
            }
            else
            {
                Console.WriteLine("Bir daha düşün");
            }

            Console.WriteLine(oyunİsmi);
        }
    }
}
