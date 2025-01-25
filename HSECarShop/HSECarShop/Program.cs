namespace HSECarShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService();
            CustomerStorage customerStorage = new CustomerStorage();
            HseCarService HseService = new HseCarService(carService, customerStorage);
            PedalCarFactory pedalCarFactory = new PedalCarFactory();
            HandCarFactory handCarFactory = new HandCarFactory();


            customerStorage.AddCustomer(new Customer { FIO = "Keiran Culkin", LegStrength = 6, ArmStrength = 4 });
            customerStorage.AddCustomer(new Customer { FIO = "Guy Pierce", LegStrength = 4, ArmStrength = 6 });
            customerStorage.AddCustomer(new Customer { FIO = "Yura Borisov", LegStrength = 6, ArmStrength = 6 });
            customerStorage.AddCustomer(new Customer { FIO = "Edward Norton", LegStrength = 4, ArmStrength = 4 });


            carService.AddCar(pedalCarFactory, new PedalEngineParams(10));
            carService.AddCar(pedalCarFactory, new PedalEngineParams(12));
            carService.AddCar(handCarFactory, new EmptyEngineParams());
            carService.AddCar(handCarFactory, new EmptyEngineParams());


            foreach (var customer in customerStorage.GetCustomers())
            {
                Console.WriteLine(customer);
            }


            HseService.SellCars();


            Console.WriteLine(Environment.NewLine);
            foreach (var customer in customerStorage.GetCustomers())
            {
                Console.WriteLine(customer);
            }
        }
    }
}
