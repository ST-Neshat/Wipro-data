using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Voting
    {
        public void Check(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Person is Eligible for Voting...");
            }
            else
            {
                Console.WriteLine("Person is not Eligible for voting...");
            }
        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter age...");
            age = Convert.ToInt32(Console.ReadLine());
            Voting obj= new Voting();
            obj.Check(age);
        }
    }
}
