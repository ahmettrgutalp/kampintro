using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ahmet";
            int yas = 18;

            kurs kurs1;
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.Izlenmeorani = 68;

            kurs kurs2;
            kurs2.kursAdi = "java";
            kurs2.egitmen = "herhangi biri";
            kurs2.Izlenmeorani = 100;



            kurs kurs3;
            kurs3.kursAdi = "python";
            kurs3.egitmen = "herhangibiri";
            kurs3.Izlenmeorani = 70;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmen);


            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmen);
            }

        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int Izlenmeorani { get; set; }
    } 
}
