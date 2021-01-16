using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Bora";
            int yas = 15;

            Oyun oyun1 = new Oyun();
            oyun1.OyunAdi = "Stardew Valley";
            oyun1.OyuncuSayisi = 571;
            oyun1.Dagitici = "Steam";

            Oyun oyun2 = new Oyun();
            oyun2.OyunAdi = "Undertale";
            oyun2.OyuncuSayisi = 1453;
            oyun2.Dagitici = "Ubisoft";

            Oyun oyun3 = new Oyun();
            oyun3.OyunAdi = "Skyrim";
            oyun3.OyuncuSayisi = 1071;
            oyun3.Dagitici = "Epic Games";

            // Console.WriteLine(oyun1.OyunAdi + " " + oyun1.OyuncuSayisi);

            Oyun[] oyunlar = new Oyun[] {oyun1, oyun2, oyun3 };

            foreach (var oyun in oyunlar) {
                Console.WriteLine(oyun.OyunAdi + " " + oyun.OyuncuSayisi);
            }
        }
    }

    class Oyun
    {
        public string OyunAdi { get; set; }

        public int OyuncuSayisi { get; set; }

        public string Dagitici { get; set; }
    }
}
