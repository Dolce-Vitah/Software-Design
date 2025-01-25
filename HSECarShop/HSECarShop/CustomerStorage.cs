using HSECarShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSECarShop
{
    public class CustomerStorage: ICustomersProvider
    {
        private List<Customer> _customers = new();

        public List<Customer> GetCustomers() => _customers;

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
