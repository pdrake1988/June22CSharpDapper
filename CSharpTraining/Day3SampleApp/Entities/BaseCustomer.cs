using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp.Entities
{
    public abstract class BaseCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void LogInformation();
    }
}
