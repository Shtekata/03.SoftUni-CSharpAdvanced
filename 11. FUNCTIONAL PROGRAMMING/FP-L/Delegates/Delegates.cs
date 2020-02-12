
namespace Delegates
{
    using System;
    public class Program
    {
        public delegate string alaBala(int x, int y);
        public static void Main()
        {
            Func<int, int, string> v = Plus;
            alaBala m = Plus;
            Console.WriteLine(Bram(4, 5, v));
            Console.WriteLine(ChiChi(7, 8, m));
            Console.WriteLine(ChiChi(7, 8, (x, y) => ((double)x / y).ToString()));
            Console.WriteLine(Bram(10, 20, (x, y) => (x - y * 100).ToString()));
            Console.WriteLine(ChiChi(4, 7, BamBam));
            Console.WriteLine(Bram(3, 2, BamBam));
        }

        public static string BamBam(int h, int g) => (h * 6 + g + 8).ToString();

        public static string ChiChi(int d, int k, alaBala p)
        {
            return p(d, k);
        }

        public static string Bram(int x, int y, Func<int, int, string> km)
        {
            return km(x, y);
        }

        public static string Plus(int j, int k)
        {
            return (j + k * 3).ToString();
        }
    }
}
