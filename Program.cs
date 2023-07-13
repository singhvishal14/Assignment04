using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_04_Assignment__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter the Number: ");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                if(num > 0)
                {
                    Console.WriteLine("The Number is Positive");
                }
                else
                {
                    Console.WriteLine("The Number is Zero");
                }
            }
            string number = num % 2 == 0 ? "even" : "odd";
            Console.WriteLine("Entred Number is "+ number);
            Console.ReadKey();
        }
    }
}
