using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Comparer<T> where T : class
    {
        //public bool CheckEquality(int a, int b)
        //{
        //    return a == b;
        //}
        //public bool CheckEquality(float a, float b)
        //{
        //    return a.Equals(b);
        //}

        //unsafe typing because it check for all datatypes against each other
        //public bool CheckEquality(object o, object p)
        //{
        //    return o.Equals(p);
        //}
        public bool CheckEquality( T a, T b)
        {
            return a.Equals(b);
        }
    }
}
