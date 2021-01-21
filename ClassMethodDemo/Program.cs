using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Kosova",
                AccountNumber = "456879731",
                TC = "19245698764"
            };
            
            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Kendall",
                LastName = "Jenner",
                AccountNumber = "456687978",
                TC = "Not TC citizen"
            };
            
            Customer customer3 = new Customer
            {
                Id = 3,
                FirstName = "Cem",
                LastName = "Yılmaz",
                AccountNumber = "442719332",
                TC = "65478932125"
            };
            
            Customer customer4 = new Customer
            {
                Id = 4,
                FirstName = "Abel",
                LastName = "Tesfaye",
                AccountNumber = "78214658",
                TC = "Not TC citizen"
            };

            CustomerManager customerManager = new CustomerManager();

            customerManager.ListCustomers();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customer4);
            Console.WriteLine();
            
            customerManager.ListCustomers();

            Console.WriteLine();
            customerManager.DeleteCustomer(38);
            Console.WriteLine();

            customerManager.ListCustomers();
        }
    }
}
