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

    //abstract vs virtual
    //abstract method does not provide an implentation and forces the derived class to override the method
    //virtual: can have implementation and provides the OPTION of overriding.


    //Abstract vs classes:
    //Abstract class cannot be instantiated but concrete classes can
    //As long as a single abstract method exists, the class must be abstract
    //abstract classes can contain concrete methods as well as abstract methods
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract string GetName();

        public virtual int GetId()
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
