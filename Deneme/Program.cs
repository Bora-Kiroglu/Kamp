using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Urun urun1 = new Urun();
        urun1.UrununAdi = "Tişört";
        urun1.UrununFiyati = 50;
        urun1.UrununBedeni = "S"
  

  }
}

class Urun
{
    public string UrununAdi { get; set; }

    public int UrununFiyati { get; set; }

    public string UrununBedeni { get; set; }
}