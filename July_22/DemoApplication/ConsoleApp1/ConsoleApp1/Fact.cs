using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Fact
    {
        public void Calc(int n)
        {
            int i = 1, f = 1;
            while (i <= n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine(f);
        }
        static void Main()
        {
            Console.WriteLine("Enter the number...");
            int n=Convert.ToInt32(Console.ReadLine());
            Fact obj=new Fact();
            obj.Calc(n);
        }
    }
}
