using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your first number");
            float firstnumber = int.Parse(Console.ReadLine());


            Console.WriteLine("enter your second number");
            long secondnumber = int.Parse(Console.ReadLine());


            while (firstnumber < secondnumber)
            {

                int count = 0;


                for (int i = 2; i < firstnumber; i++)
                {


                    if (firstnumber % i == 0)
                    {

                        count++;
                    }


                }



                if (firstnumber < 2)
                {

                }

                else if (count == 0)
                {

                    Console.WriteLine(firstnumber);
                }


                else if (count > 0)
                {

                }

                firstnumber++;

            }


            System.Console.ReadKey();

        }
    }
}
