using System;

namespace ConsoleAppFactRec
{
    class Recursive
    {
        internal int Fact(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Fact(n - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Recursive obj = new Recursive();
            int num=obj.Fact(n);
            Console.WriteLine("Factorial of given number is " + n + "! = " + num);

        }
    }
}
