using DoubleParse;
using System;

namespace Traducere
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1100.22;
            Console.WriteLine("Start....");
            Console.WriteLine();
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 31433200.222;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 113222100.12;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 1100323222.122;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 1100.22;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 346789;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 9999991.29;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 1999991.29;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();
            num = 1922.23;
            Console.WriteLine($"|{num} | {num.NumRomaninanMonneyWords()}|");
            Console.WriteLine();

            //Console.Write("Enter a number to convert to words: ");
            //Double n = Double.Parse(Console.ReadLine());
            //Console.WriteLine("{0}", n.NumRomaninanMonneyWords());

        }
    }
}
