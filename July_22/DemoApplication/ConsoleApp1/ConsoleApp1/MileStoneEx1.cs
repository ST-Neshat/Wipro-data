using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Program to count number of vowels in the entered string.

namespace DemoApplication
{
    internal class MileStoneEx1
    {
        public void show(string s)
        {
            int count = 0;
            char[] chars = s.ToCharArray();
            foreach(char c in chars)
            {
                if(c =='a' || c =='e' || c =='i' || c =='o' || c == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("The number of vowels is: " + count);
        }
        static void Main()
        {
            Console.WriteLine("Enter the string..");
            string s= Console.ReadLine();
            MileStoneEx1 obj = new MileStoneEx1();
            obj.show(s);

        }
    }
}
