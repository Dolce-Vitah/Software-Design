using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class CarService: ICarProvider
    {
        private static readonly Random random = new Random();

        private List<Car> _cars;

        public CarService() => _cars = new();

        public Car? FindCar(Customer customer)
        {
            Car? suitableCar = null;

            foreach (var car in _cars)
            {
                if (car.CheckCompatibility(customer))
                {
                    suitableCar = car;
                    _cars.Remove(car);
                    break;
                }
            }

            return suitableCar;
        }

        public void AddCar<TParams>(ICarFactory<TParams> carParam, TParams engineParam)
        {
            int carNumber = random.Next(100, 1000);
            var newCar = carParam.CreateCar(engineParam, carNumber);
            _cars.Add(newCar);
        }
    }
}
