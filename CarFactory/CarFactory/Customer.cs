using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class Customer
    {
        public required string FIO { get; set; }

        public Car? Car { get; set; }

        public override string ToString()
        {
            return $"Name: {FIO}";
        }
    }
}
