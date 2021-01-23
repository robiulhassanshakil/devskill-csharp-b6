using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1) || (string.IsNullOrEmpty(number2)))
                    break;

                if (number1.Length < number2.Length)
                {
                    var temp = number1;
                    number1 = number2;
                    number2 = temp;
                }

                var result = new int[number1.Length];
                var i = number1.Length - 1;
                var j = number2.Length - 1;
                int Carry = 0;

                while (i >= 0)
                {
                    var sub = 0;

                    if (j >= 0)
                        sub = (number1[i] - '0') - (number2[j] - '0') - Carry;
                    else
                        sub = (number1[i] - '0') - Carry + result[i];

                    if (i == 0)
                    {
                        result[i] = sub;
                    }
                    else
                    {
                        if (sub< 0)
                        {
                            sub = sub + 10;
                            Carry= 1;

                        }
                        else
                            Carry = 0;
                    }
                    result[i] = sub;
                    i--;
                    j--;
                }

                for (var x = 0; x < result.Length; x++)
                {
                    Console.Write(result[x]);
                }
               
            }

        }
    }
}

