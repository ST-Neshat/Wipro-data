using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to input a sentence, identify the palindrome words in the sentence, and display them.

namespace DemoApplication
{
    internal class MileStoneEx3
    {
        public bool IsPalindrome(string s)
        {
            char[] chars = s.ToCharArray();
            string rev = "";
            for (int i =chars.Length - 1; i >=0; i--)
            {
                rev = rev + chars[i];
            }
            if (rev.Equals(s))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Show(string s)
        {
            string[] words= s.Split(' ');
            foreach(string word in words) {
                if (IsPalindrome(word)==true)
                {
                    Console.WriteLine(word);
                }
        }
    }
    static void Main()
        {
            Console.WriteLine("Enter the sentence...");
            string s=Console.ReadLine();
            MileStoneEx3 obj = new MileStoneEx3();
            obj.Show(s);
        }
    }
}
