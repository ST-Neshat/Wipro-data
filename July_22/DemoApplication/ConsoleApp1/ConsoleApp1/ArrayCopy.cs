using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class ArrayCopy
    {
        public void Show()
        {
            int[]a= { 1, 2, 3 ,4,5};
            int[] b = a;
            foreach(int i in b)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
           ArrayCopy obj=new ArrayCopy();
            obj.Show();
        }
    }
}
