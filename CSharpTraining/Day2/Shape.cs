using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //abstraction: the ability to hide the implementation of the class. This can be done with either Abstract or
    //Interfaces
    //Abstract methods: is a method that can only be used in an abstract class. This does not have a body,
    //as a body is provided by derived class
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract string GetName();

        public int GetId()
        {
            return Id;
        }
    }
    public class Square : Shape
    {
        public override string GetName()
        {
            return Name;
        }
    }
}
