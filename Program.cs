using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, wynik;
            Console.WriteLine("podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = double.Parse(Console.ReadLine());
            wynik = a + b;
            Console.WriteLine("wynik =" + wynik);
        }
    }

}
