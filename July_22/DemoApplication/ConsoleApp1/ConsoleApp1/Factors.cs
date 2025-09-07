using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Factors
    {
        public void Fact(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + "  ");
                }
                else
                    continue;
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter the number...");
            int n = Convert.ToInt32(Console.ReadLine());
            Factors obj = new Factors();
            obj.Fact(n);
        }
    }
}