using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class PedalCarFactory: ICarFactory<PedalEngineParams>
    {
        public Car CreateCar(PedalEngineParams param, int number)
        {
            return new Car(new PedalEngine(param.Size), number);
        }
    }
}
