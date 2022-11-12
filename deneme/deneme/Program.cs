using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci oyuncunun adını giriniz: ");
            string isim1=Console.ReadLine();
            Console.WriteLine("İkinci oyuncunun adını giriniz: ");
            string isim2=Console.ReadLine();
            Console.WriteLine("Birinci oyuncunun adı: "+isim1);
            Console.WriteLine("İkinci oyuncunun adı: "+isim2);
            int sonuc1 = 0;
            int sonuc2 = 0;
            Random rand = new Random();
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("{0} zar atmak için enter tuşuna basınız.",isim1);
                Console.ReadLine();
                int sayi1=rand.Next(1,6);
                Console.WriteLine(sayi1);
                Console.WriteLine("{0} zar atmak için enter tuşuna basınız.",isim2);
                Console.ReadLine();
                int sayi2=rand.Next(1,6);
                Console.WriteLine(sayi2);
                sonuc1 += sayi1;
                sonuc2 += sayi2;

            }
            Console.WriteLine("{0} oyuncusunun skoru:{1} ",isim1,sonuc1);
            Console.WriteLine("{0} oyuncusunun skoru:{1} ", isim2,sonuc2);
            if (sonuc1 > sonuc2)
            {
                Console.WriteLine("{0} oyuncusu kazandı.", isim1);

            }
            else if (sonuc1 < sonuc2)
            {
                Console.WriteLine("{0} oyuncusu kazandı.", isim2);
            }
            else
            {
                Console.WriteLine("Berabere bitti. Kaznan yok.");
            }
            Console.ReadLine();
        }
    }
}
