using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteMVC2.Models
{

    public static class DataManager
    {
        static int counter = 1;
        private static List<Customer> customers = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            customer.Id = counter++;
            customers.Add(customer);
        }

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }
    }
}
