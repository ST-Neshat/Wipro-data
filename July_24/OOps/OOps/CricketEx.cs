using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class CricketEx
    {
        static int score;
        public vlid Increment(int x)
        {
            score += x;
        }
        static void Main()
        {
            CricketEx fb=new CricketEx();
            CricketEx sb=new CricketEx();
            CricketEx ext=new CricketEx();
            fb.Increment(14);
            sb.Increment(9);
            ext.Increment(11);
            Console.WriteLine();
        }
    }
}
