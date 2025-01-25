using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class Customer
    {
        public required int LegStrength { get; set; }

        public required int ArmStrength { get; set; }

        public required string FIO { get; set; }

        public Car? Car { get; set; }

        public override string ToString()
        {
            return $"Name: {FIO}, Leg strength: {LegStrength}, Arm strength: {ArmStrength}, Car: {Car}";
        }
    }
}
