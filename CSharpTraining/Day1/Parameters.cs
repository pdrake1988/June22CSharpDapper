using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public enum DaysOfWeek //can hold Roles or positions
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class Parameters
    {
        public int PassByValue(int a, int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Inside the funciton");
            return a + b;
        }

        public int PassByRef(ref int a, ref int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Inside the funciton");
            return a + b;
        }

        public void AreaOfCircle(double radius, double pi = 3.14)
        {
            Console.WriteLine($"Area of Cirle = {radius * radius * pi}");
        }

        public bool Author(string uname, string pass, out string msg)
        {
            msg = "";
            if(uname == "bob" && pass == "smith")
            {
                msg = "verified";
                return true;
            } else if (uname != "bob")
            {
                msg = "username wrong";
            }else if(pass != "smith")
            {
                msg = "password wrong";
            }
            return false;
        }

        public int AddTwo(int a, int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b}");
            return a + b;
        }
        public int AddThree(int a, int b, int c)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b}");
            return a + b;
        }

        public int AddNumbers(string str, params int[] arr)
        {
            int sum = 0;
            foreach(var i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
