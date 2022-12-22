using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your first number");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter your second number");
            double n2 = double.Parse(Console.ReadLine());

            double sum = 0;

            while (n1 < n2)
            {
                sum = 0;

                int i;

                for (i = 1; i < n1; i++)
                {

                    if (n1 % i == 0)
                    {

                        sum = sum + i;

                    }

                }


                if (sum == n1)
                {
                    Console.WriteLine(n1);
                }

                n1++;
            }

            Console.ReadKey();

        }
    }
}
