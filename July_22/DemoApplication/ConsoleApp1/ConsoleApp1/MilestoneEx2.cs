using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to separate string after space and add to array.

namespace DemoApplication
{
    internal class MilestoneEx2
    {
        static void Main()
        {
            Console.WriteLine("Enter the string...");
            string s=Console.ReadLine();
            string[] names=s.Split(' ');
            foreach (string name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
