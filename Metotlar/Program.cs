using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elması";

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] Urunler = new Urun[] { Urun1, Urun2 };

            foreach (Urun urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");


            }

            Console.WriteLine("*-*-*-*-*-*Metotlar*---*-*-*---");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);
           

        }
    }
}

