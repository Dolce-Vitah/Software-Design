using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    internal class FactoryAF
    {
        private static readonly Random Random = new Random();

        public Queue<Customer> Customers { get; set; }

        public Queue<Car> Cars { get; set; }

        public FactoryAF(Queue<Customer> customers)
        {
            Customers = customers;
            Cars = new Queue<Car>();
        }

        public Queue<Customer> SellCar()
        {
            Queue<Customer> customersWithCars = new Queue<Customer>();

            while (Customers.Count() != 0 && Cars.Count() != 0)
            {
                var customer = Customers.Dequeue();
                var car = Cars.Dequeue();
                customer.Car = car;
                customersWithCars.Enqueue(customer);
            }

            Cars.Clear();
            return customersWithCars;
        }

        public void AddCar()
        {
            int pedalSize = Random.Next(15, 40);
            int number = Random.Next(100, 999);
            var car = new Car(number, pedalSize);
            Cars.Enqueue(car);
        }
    }
}
