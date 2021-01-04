using System;

namespace qus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Palindrome:");

            string normal = Console.ReadLine();

            string revers = "";
            int l = normal.Length-1;
          while(l>=0)
            {
                revers = revers + normal[l];
                l--;
               
            }

            if (revers == normal)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        } 
    }
}
