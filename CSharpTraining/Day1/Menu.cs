using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Menu
    {
        public void Run()
        {
            Console.WriteLine( "Please enter a input: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Parameters p = new Parameters();
            p.AddTwo(10, 20);
        }
    }
}
