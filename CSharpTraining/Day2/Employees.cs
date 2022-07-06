using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Employees
    {
        public Employees()
        {
            Console.WriteLine("Employee Constructor");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Hour { get; set; } = 0;
        public virtual void Work()
        {
            Console.WriteLine("Im working as an Emp");
        }
        public void SpecialWork()
        {
            Console.WriteLine("Im doing special work as an employee");
        }
    }

    public class FullTime : Employees
    {
        static FullTime()
        {
            Console.WriteLine("Static Fulltime ctor");
        }
        public FullTime()
        {
            Console.WriteLine("From FullTime Ctor");
        }
        public FullTime(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public override void Work()
        {
            Console.WriteLine("Im working as a Full Emp");
        }
        public new void SpecialWork()
        {
            Console.WriteLine("Im doing special work as a full employee");
        }
    }
    public class PartTime : Employees
    {
        public PartTime()
        {

        }
        public PartTime(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public override void Work()
        {
            Console.WriteLine("Im working as a Parttime Emp");
        }

    }
    public class Selector
    {
        public Employees Deduct(Employees anyEmp, int deduct)
        {
            anyEmp.Hour -= 1;
            return anyEmp;
        }
    }
}
