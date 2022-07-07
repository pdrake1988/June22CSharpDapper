using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    // Inferfaces vs Abstract Classes:
    // Interfaces supports multiple inhertance but abstract classes cannot
    // Interfaces can not have instanced Constructors but abstract classes can (theortically)
    // Interfaces has by default all members to be considered "abstract" and public, but abstracted classes
    // can have both abstract and contrete members
    // Interfaces can not have fields but abstract classes can have fields
    public interface ILearn<T> where T : struct
    {
        public int Add(T a, T b);
        public int Subtract(T a, T b);
        public int Multiply(T a, T b);
    }
}
