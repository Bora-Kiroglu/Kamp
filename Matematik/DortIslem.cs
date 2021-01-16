using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("İşlemin sonucu : " + toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int toplam = sayi1 - sayi2;
            Console.WriteLine("İşlemin sonucu : " + toplam);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int toplam = sayi1 * sayi2;
            Console.WriteLine("İşlemin sonucu : " + toplam);
        }

        public void Bol(int sayi1, int sayi2)
        {
            int toplam = sayi1 / sayi2;
            Console.WriteLine("İşlemin sonucu : " + toplam);
        }



    }
}
