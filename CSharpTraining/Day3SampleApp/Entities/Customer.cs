using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp.Entities
{
    public class Customer : BaseCustomer
    {
        public int Spent { get; set; }
        public int ItemNum { get; set; }
        public Customer()
        { 
        }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override void LogInformation()
        {
            Console.Write("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Money Spent? ");
            Spent = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many items? ");
            ItemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Avg Item Price = {(double)Spent / ItemNum}");
        }
    }
}
