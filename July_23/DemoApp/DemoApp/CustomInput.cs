using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class CustomInput
    {
        public static void Main()
        {
            int i, j;
            int[,] a = new int[2, 3];
            Console.WriteLine("Enter Array Elements (Total 6) ");
            for(i=0; i<a.GetLength(0); i++)
            {
                for(j=0; j<a.GetLength(1); j++)
                {
                    a[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The entered array is...");            for(i=0; i<a.GetLength(0); i++)
            {
                for(j=0;j<a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
