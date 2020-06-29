using System;

namespace calisma02
{
    class Program
    {
        static int Fibonacci(int a)
        {
            if (a == 0)
                return 0;
            if (a == 1)
                return 1;
            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }

        static double[] KarekokBul(params double[] sayilar)
        {
            double[] kokler = new double[sayilar.Length];
            for (int i = 0; i < sayilar.Length; ++i)
            {
                kokler[i] = Math.Sqrt(sayilar[i]);
            }
            return kokler;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Değişken sayıda girilen (100, 6, 45, 49, 4, 72, 81, 25) sayıların köklerini bize döndüren program.
            double[] kokler = KarekokBul(100, 6, 45, 49, 4, 72, 81, 25);
            foreach (double i in kokler)
                Console.WriteLine("--> {0}", i);
            // double[] kokleri = { 100, 6, 45, 49, 4, 72, 81, 25 };
            // double[] kokBul = KarekokBul(kokleri);
            // foreach (double i in kokBul)
            //     Console.WriteLine("> {0}", i);

            Console.Write("Köklerinin bulunulmasını istediğiniz sayıların adetini giriniz :");
            int counter = Convert.ToInt32(Console.ReadLine());
            double[] sayilar = new double[counter];
            for (int i = 0; i < counter; ++i)
            {
                sayilar.SetValue(Convert.ToDouble(Console.ReadLine()), i);

            }
            double[] kokleriBul = KarekokBul(sayilar);
            foreach (double y in kokleriBul)
                Console.WriteLine("=> {0}", y);




            // 0' dan 10'a kadar olan sayıların tek tek fibonacci değerini verir. 
            for (int i = 0; i <= 10; ++i)
            {
                Console.WriteLine(Fibonacci(i));
            }

            // Klavyeden girilen bir sayının fibonacci değerini verir.
            Console.Write("Fibonacci değerini istediğiniz sayıyı giriniz : ");
            int fibo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İstediğiniz sayının Fibonacci değeri : {0}", Fibonacci(fibo));


        }
    }
}
