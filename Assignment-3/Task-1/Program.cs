using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_1
{
    class Program
    {
        public delegate void Printsomething(int x, int y);

        public static void Test(Printsomething a)
        {
            a(5, 5);
        }
        static void Main(string[] args)
        {
            Test(doprint);
            
        }

        public static void doprint(int x, int y)
        {
            var v = x + y;
            Console.WriteLine(v);
        }
    }
}
