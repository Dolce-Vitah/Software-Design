using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    internal class HandEngine: IEngine
    {
        public bool CheckCompatibility(Customer customer)
        {
            return customer.ArmStrength > 5;
        }

        public override string ToString()
        {
            return "hand";
        }
    }
}
