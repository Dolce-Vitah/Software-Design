namespace CarFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> customers = new Queue<Customer>();
            customers.Enqueue(new Customer { FIO = "Dominic Toretto" });
            customers.Enqueue(new Customer { FIO = "Lightning McQueen" });
            customers.Enqueue(new Customer { FIO = "Doc Hudson" });
            customers.Enqueue(new Customer { FIO = "Mater" });

            FactoryAF factory = new FactoryAF(customers);
            factory.AddCar();
            factory.AddCar();
            factory.AddCar();

            foreach (var car in factory.Cars)
            {
                Console.WriteLine(car);
                Console.WriteLine(Environment.NewLine);
            }

            var customersWithCars = factory.SellCar();

            foreach (var customer in customersWithCars)
            {
                Console.WriteLine(customer);
                Console.WriteLine(Environment.NewLine);
            }

            foreach (var customer in factory.Customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
