using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Mücahit Alanyurt";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "Bayram Alanyurt";
            kurs2.IzlenmeOranı = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "Veli Alart";
            kurs3.IzlenmeOranı = 61;

            //   Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3,
            };

            foreach (var k in kurslar)
            {
                Console.WriteLine(k.KursAdi + "/"+ k.Egitmen + "/" + k.IzlenmeOranı);
            }
            








        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }

}


