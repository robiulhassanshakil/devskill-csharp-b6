using System;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The factor number is :");

            for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {

                    Console.Write(i+" ");
                       
                    }
                }

           


        }
    }
}
