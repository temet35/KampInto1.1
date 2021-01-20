using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Phyton";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdı + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + ":" + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }


    }
}
