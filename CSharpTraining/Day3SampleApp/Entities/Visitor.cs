using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp.Entities
{
    public class Visitor : BaseCustomer
    {
        public string Reason { get; set; }

        public override void LogInformation()
        {
            Console.Write("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Reason to leave without Purchase? ");
            Reason = Console.ReadLine();
            Console.WriteLine(Reason); 
        }
    }
}
