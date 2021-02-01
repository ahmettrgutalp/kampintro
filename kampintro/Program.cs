using System;

namespace kampintro
{
    class Program          //string'i döngü sağlar bir şeyi tekrar tekrar yazmak yerine bi kereden yazmak.
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "kategori";

            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemegirisyapmismi = true; //şart bloğu
            double dolardun = 7.60;
            double dolarbugun = 7.60;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolardun < dolarbugun) //buda bir şart bloğu if devreye girmediğinde girer devreye
            {
                Console.WriteLine("Artış Butonu");
            }
            else //bu ise her ikiside devreye girmediğinde girer devreye
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemegirisyapmismi == true) //o şartı sağlıyosa devreye girer
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");//if butonunun devreye girmediği yerde else devreye girer
            }


            Console.WriteLine(kategorietiketi);
        }
    }
}
