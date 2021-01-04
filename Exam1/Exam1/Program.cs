using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String for remove a spacail charecter:");
            string input = Console.ReadLine();
            string input1="";
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]=='@'|| input[i] == '#' || input[i] == '$' || input[i] == '%' || input[i] == '^' || input[i] == '&' || input[i] == '*')
                {

                }

                else
                {
                    input1=input1+input[i];
                }
            }
            Console.WriteLine("After remove a spacail charecter:");
            Console.WriteLine(input1);



        }
    }
}
