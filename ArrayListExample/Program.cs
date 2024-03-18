using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList koleksiyon = new ArrayList();

            koleksiyon.Add("Enes");
            koleksiyon.Add("Ali");
            koleksiyon.Add("Yusuf");
            koleksiyon.Add("Mehmet");

            koleksiyon.Remove("Mehmet");
            koleksiyon.Insert(3, "Sercan");
            koleksiyon.Reverse();

            foreach (var a in koleksiyon)
            {
                Console.WriteLine(a);
            }

            int count = koleksiyon.Count;
            Console.WriteLine("Dizinin eleman sayısı: " + count);
            // koleksiyon.Clear();
            bool kontrol = koleksiyon.Contains("Yusuf");
            Console.WriteLine("'Yusuf' dizide var mı? " + kontrol);
            Console.WriteLine("'Enes' dizide var mı? " + koleksiyon.Contains("Enes"));
            Console.WriteLine("İndex numarası: " + koleksiyon.IndexOf("Ali"));
            
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(1);
            rakamlar.Add(100);
            rakamlar.Add(2);

            rakamlar.Sort();

            foreach (var a in rakamlar)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
