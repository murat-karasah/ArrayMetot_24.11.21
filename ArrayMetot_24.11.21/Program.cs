using System;
using System.Linq;

namespace ArrayMetot_24._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dizinin Metotları:
            > Length    => Dizinin Eleman Sayısı,
            > Count     => Adet,
            > first     => İlk elemanı,
            > last      => Son elemanı,
            > Min       => En küçük Elemanı,
            > Max       => En büyük Elemanı,
            > sum       => Elemanların toplamı,
            > indexOf   => eleman hangi indexte,
            */
            int i = 0;
            int[] dizi = new int[5] { 3, 5, 9, 34, 23 };
            foreach (int item in dizi)
            {
                Console.WriteLine(">>>" +  i++ + ".Elemanı :" + item);
            }
            Console.WriteLine("#################################");
            Console.WriteLine(">>>Eleman Sayısı : {0}\n>>>Eleman Adeti: {1} \n>>>Dizini İlk Elemanı : {2} \n>>>Dizinin Son Elemanı {3} \n>>>Dizinin En Küçük elemanı: {4} \n>>>Dizinin En Büyük elemanı: {5} \n>>>Dizinin Toplamı: {6} ", dizi.Length,dizi.Count(),dizi.First(),dizi.Last(),dizi.Min(),dizi.Max(),dizi.Sum());
        }

    }
}
