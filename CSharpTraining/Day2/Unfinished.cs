using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Unfinished
    {
        public void Example()
        {
            //Strings are immutable
            //strings are arrays of characters
            string ex = "hello"; //version 1 of ex
            Console.WriteLine( ex[0]);
            // ex[0] = 'f';

            //strings are an array, it has a set size.
            //for security, its important that the string is immutable because things like
            //Connection strings should not be mutable.
            //makes strings thread safe. 

            ex = "hello there"; //new version of ex

            //value types: will directly hold the value in the stack memory.
            //reference types: Uses a reference that points towards the address where the content is stored in
            //heap memory

            string nullstr= null;

            //boxing and unboxing:ability to convert a value type to a reference type and vice versa
            int box = 10;
            object obj = box;
            int unbox = (int)obj;

            //introducing Upcasting
        }
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //Different number of parameters
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b+ c);
        }
        //Different Data types
        public void Add(string a, int b)
        {
            Console.WriteLine(a + b);
        }
        //Changing the order
        public void Add(int a, string b)
        {
            Console.WriteLine(a + b);
        }
        //If changing the return type, needs to implement on of the three above.
    }
}
