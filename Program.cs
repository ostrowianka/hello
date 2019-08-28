using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum;
            Console.WriteLine("enter a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            b = double.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine($"sum result= {sum}");

            var result = Devide(a, b);
            Console.WriteLine(result);
        }   
        public static double Devide(double a, double b)
        {
            if (b!=0)
            {          
            var result = a/b;
            return result;
            }
            throw  new DivideByZeroException();
        }
    }

}
