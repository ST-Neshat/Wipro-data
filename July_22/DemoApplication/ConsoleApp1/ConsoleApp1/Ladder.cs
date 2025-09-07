using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Ladder
    {
        public void Show(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Hi I am Rajesh...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi I am Anusha...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hi I am Neshat...");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            Ladder obj = new Ladder();
            obj.Show(choice);
        }
    }
}
