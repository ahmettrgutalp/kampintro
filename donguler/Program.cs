using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {


           //string bir metni tutmaya yarar

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs","java","phython","c#" };



            for (int i = 0; i<kurslar.Length; i++) //0 dan başlayıp kursları 1 1 sırala demek
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) // kursları dolaş demek
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
