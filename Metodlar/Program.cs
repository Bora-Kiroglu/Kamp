using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun oyun1 = new Urun();
            oyun1.Adi = "Stardew Valley";
            oyun1.Fiyati = 32;
            oyun1.Aciklama = "Çiftlik oyunu";

            Urun oyun2 = new Urun();
            oyun2.Adi = "Superliminal";
            oyun2.Fiyati = 25;
            oyun2.Aciklama = ":D";

            Urun[] oyunlar = new Urun[] {oyun1, oyun2 };

            foreach (Urun oyun in oyunlar)
            {
                Console.WriteLine(oyun.Adi);
                Console.WriteLine(oyun.Fiyati);
                Console.WriteLine(oyun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-----------Metotlar------------");
            // instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(oyun1);

            sepetManager.Ekle(oyun2);

            sepetManager.Ekle2("Baldi", "Gerilim", 0);
            sepetManager.Ekle2("Wow", "Evet", 17);
            sepetManager.Ekle2("Stick Rpg", "RPG", 19.99);





        }
    }
}
