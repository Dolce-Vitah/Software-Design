﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop.Interfaces
{
    public interface IEngine
    {
        bool CheckCompatibility(Customer customer);
    }
}
