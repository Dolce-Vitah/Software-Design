using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class Car
    {
        public int? Number { get; init; }

        public IEngine Engine { get; init; }

        public Car(IEngine engine, int number)
        {
            Engine = engine;
            Number = number;
        }

        public bool CheckCompatibility(Customer customer)
        {
            return Engine.CheckCompatibility(customer);
        }

        public override string ToString()
        {
            return $"Number: {(Number == null ? "none" : Number)}, Engine: {(Engine == null ? "none" : Engine)}";
        }
    }
}
