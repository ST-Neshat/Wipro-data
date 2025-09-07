using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    
    internal class Data
    {
        //static void Main(string[] args)
        //{
        //    Data obj = new Data();
        //    obj.Greeting();
        //    obj.Company();
        //    //obj.Trainer();
        //}

        public void Greeting()
        {
            Console.WriteLine("Welcome to Dotnet Trainiing...");
        }
        internal void Company()
        {
            Console.WriteLine("Company is Wipro...");
        }
        private void Trainer()
        {
            Console.WriteLine("Trainer is Prasanna Pappu...");
        }
    }
}
    
    

