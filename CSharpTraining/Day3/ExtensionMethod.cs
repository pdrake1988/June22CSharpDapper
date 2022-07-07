using StaticFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public static class ExtensionMethod
    {
        /*
         The class containing extention methods must be a static class.
        The Extension method must also be a static method
        First Parameter must be of a type which is being executed
        and must be written after "This" keyword
         */
       public static bool IsEven(this int x)
       {
            return x % 2 == 0;
       }
    }
}
