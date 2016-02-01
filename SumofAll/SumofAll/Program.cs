using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int  min = 0;
            int  max = 1;
            int sum = 0;
            int mx = 100;
            for(int i =1;i<mx;i++)
            {
                sum = min + max;
                if (sum % 2 == 0)
                {
                    Console.WriteLine(sum);
                }
                min = max;
                max = sum;
               
                if (sum>400000)
                {
                    break;
                }

            }
           
            
        }
    }
}
