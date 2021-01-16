using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string oyun1 = "Stardew Valley";
            string oyun2 = "Undertale";
            string oyun3 = "Skyrim";
            string oyun4 = "Superliminal";

            //array

            string[] oyunlar = new string[] {"Stardew Valley" , "Undertale" , "Skyrim" , "Superliminal"};

            for (int i = 0; i <oyunlar.Length ; i++)
            {
                Console.WriteLine(oyunlar[i]);
            }

            Console.WriteLine("For bitti");
            Console.WriteLine("");

            foreach (string oyun in oyunlar) // foreach dizileri kolay dolaşmak için
            {
                Console.WriteLine(oyun);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Sayfa Sonu -  Footer");
        }
    }
}
