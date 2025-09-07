using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class LowerString
    {
        static void Main()
        {
            //Console.WriteLine("Enter any string...");
            //string[] s = new string; Console.ReadLine();
            string s =  " My name is Mohammad Neshat Kausar" ;
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Trim());
            Console.WriteLine(s.Contains("ame"));
            Console.WriteLine(s.Replace('a','@'));
            Console.WriteLine(s.ToCharArray());
        }
    }
}
