using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class EmployCustom
    {
        static void Main()
        {
            Employ employ1 = new Employ(); 
            Employ employ2 = new Employ();
            Console.WriteLine("Enter first Employee data like empno,employee name, employee basic: ");
            employ1.empno=Convert.ToInt32(Console.ReadLine());
            employ1.name=Console.ReadLine();
            employ1.basic=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second Employee data like empno,employee name, employee basic: ");
            employ2.empno = Convert.ToInt32(Console.ReadLine());
            employ2.name = Console.ReadLine();
            employ2.basic = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Employee number : " + employ1.empno);
            Console.WriteLine(" Employee name: " + employ1.name);
            Console.WriteLine(" Employee basic: "+ employ1.basic);
            Console.WriteLine();

            Console.WriteLine(" Employee number : " + employ2.empno);
            Console.WriteLine(" Employee name: " + employ2.name);
            Console.WriteLine(" Employee basic: " + employ2.basic);


        }
    }
}
