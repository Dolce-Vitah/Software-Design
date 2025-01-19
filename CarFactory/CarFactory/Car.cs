using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class Car
    {
        public int Number { get; init; }

        public Engine Engine { get; init; }

        public Car(int number, int pedalSize)
        {
            Engine = new Engine { Size = pedalSize };
            Number = number;
        }

        public override string ToString()
        {
            return $"Number: {Number}";
        }
    }
}
