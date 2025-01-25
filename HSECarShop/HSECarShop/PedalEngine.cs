using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class PedalEngine: IEngine
    {     
        public int Size { get; init; }

        public PedalEngine(int size) => Size = size;
        
        public bool CheckCompatibility(Customer customer)
        {
            return customer.LegStrength > 5;
        }

        public override string ToString()
        {
            return "pedal";
        }
    }
}
