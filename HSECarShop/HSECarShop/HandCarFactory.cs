using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class HandCarFactory: ICarFactory<EmptyEngineParams>
    {
        public Car CreateCar(EmptyEngineParams param, int number)
        {
            return new Car(new HandEngine(), number);
        }
    }
}
