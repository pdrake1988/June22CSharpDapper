using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Person
    {
        public string Name;
        public int Id;
        static Person()
        {
            Console.WriteLine("Me First");
        }
        public Person()
        {
            Console.WriteLine("Default");
        }
        public Person(int id)
        {
            Id = id;
            Console.WriteLine("Id only");
        }
        public Person(int id, string Name) : this()
        {
            Id = id;
            this.Name = Name;
            Console.WriteLine("Id and string");
        }

        //shorthand of properties
        public int PropId { get; set; }

        //long version of properties
        private int _LongpropId;
      
        public int LongPorpId
        {
            get
            {
                return _LongpropId;
            }
            set
            {
                if(value < 10) { _LongpropId = value; }
            }
        }

        public void Yell()
        {
            Console.WriteLine("HI");
        }
    }
}
