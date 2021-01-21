using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Id + " id ye sahip müşteri kaydedildi.");
        }

        public void ListCustomers()
        {
            bool isEmpty = !customers.Any();
            if (isEmpty)
            {
                Console.WriteLine("Kayıtlı müşteri bulunmamaktadır.");
            }
            else
            {

                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.TC + " " + customer.AccountNumber);
                }
            }
        }

        public void DeleteCustomer(int customerId)
        {
            bool found = false;
            foreach (Customer customer in customers)
            {
                if (customer.Id == customerId)
                {
                    customers.Remove(customer);
                    Console.WriteLine(customerId + " id li müşteri silindi.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine(customerId + " id ye sahip bir müşteri bulunmamaktadır.");
            }
        }
    }
}
