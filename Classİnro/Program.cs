using System;

namespace Classİnro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ahmet";
            int yas = 18;

            kurs kurs1=new kurs();
            kurs1.kursadi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeorani = 100;


            kurs kurs2 = new kurs();
            kurs2.kursadi = "python";
            kurs2.egitmen = "Harun";
            kurs2.izlenmeorani = 50;

            kurs kurs3 = new kurs();
            kurs3.kursadi = "java";
            kurs3.egitmen = "Ahmet";
            kurs3.izlenmeorani = 68;




            //Console.WriteLine(kurs1.kursadi + "  "+kurs1.egitmen)

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }




            Console.WriteLine("Hello World!");
        }

    }
}

namespace Classİnro
{
    public string KursAdi { get; set; }
    public string Kursunegitmeni { get; set; }
    public int İzlenmeorani { get; set; }


}
