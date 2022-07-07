using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFolder

{
    public static class Helper
    {
        public static int five = 5;
        public static int AddTen(this int a)
        {
            return a + 10;
        }
    }

    public class Help
    {
        public static int PI = 3;
        public int AnyInt { get; set; } = 10;
    }
}
