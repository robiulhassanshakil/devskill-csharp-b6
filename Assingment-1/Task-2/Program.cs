using System;

namespace task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1) || (string.IsNullOrEmpty(number2)))
                    break;

                var result = new int[number1.Length + number2.Length];
                var i = number1.Length - 1;

                var p_n1 = 0;
                var p_n2 = 0;



                while (i >= 0)
                {

                    int Carry = 0;

                    p_n2 = 0;
                    var j = number2.Length - 1;
                    while (j >= 0)
                    {

                        int sum = (number1[i] - '0') * (number2[j] - '0') + result[p_n1 + p_n2] + Carry;

                        Carry = sum / 10;

                        result[p_n1 + p_n2] = sum % 10;

                        j--;
                        p_n2++;
                    }

                    if (Carry > 0)
                    {
                        result[p_n1 + p_n2] += Carry;
                    }
                    i--;
                    p_n1++;


                }
                var x = result.Length - 1;
                while (x >= 0)
                {
                    Console.Write(result[x]);
                    x--;
                }
                Console.Read();
            }


        }

    }




}


