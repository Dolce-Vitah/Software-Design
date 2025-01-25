using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class HseCarService
    {
        private ICarProvider _carProvider;

        private ICustomersProvider _customersProvider;

        public HseCarService(ICarProvider cars, ICustomersProvider customers)
        {
            _carProvider = cars;
            _customersProvider = customers;
        }

        public void SellCars()
        {
            List<Customer> customers = _customersProvider.GetCustomers();

            foreach (Customer customer in customers)
            {
                if (customer.Car == null)
                {
                    var car = _carProvider.FindCar(customer);

                    if (car != null)
                    {
                        customer.Car = car;
                    }
                }
            }
        }
    }
}
