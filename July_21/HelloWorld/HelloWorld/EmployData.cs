using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class EmployData
    {
        static void Main()
        {
            Employ employ1=new Employ();
            employ1.empno = 1;
            employ1.name= "Neshat";
            employ1.basic = 10000;

            Employ employ2=new Employ();
            employ2.empno = 2;
            employ2.name = "Sreeja";
            employ2.basic = 11000;


            Console.WriteLine("First Employ data is: ");
            Console.WriteLine(employ1.name);
            Console.WriteLine(employ1.basic);

            Console.WriteLine("Second Employ data is: ");
            Console.WriteLine(employ2.name);
            Console.WriteLine(employ2.basic);

        }
    }
}
