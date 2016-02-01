using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter the number");
            long num = Convert.ToInt64(Console.ReadLine());
            long large = 0;
            for(int i = 1; i < num; i++)
            {
                if(num%i == 0)
                {
                    large = i;
                }

            }
            Console.WriteLine(large);
            Console.Read();

        }
    }
}
