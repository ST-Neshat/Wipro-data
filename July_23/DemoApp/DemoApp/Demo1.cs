using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Demo1
    {
        public static void Main()
        {
            int[,] a = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
                Console.WriteLine("----------------------------------------------------------");
            }
        }
    }
}


