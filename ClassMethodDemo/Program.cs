using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.ListCustomers();
            Console.WriteLine();

            customerManager.AddCustomer(new Customer
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Kosova",
                AccountNumber = "456879731",
                TC = "19245698764"
            });

            customerManager.AddCustomer(new Customer
            {
                Id = 2,
                FirstName = "Kendall",
                LastName = "Jenner",
                AccountNumber = "456687978",
                TC = "Not TC citizen"
            });

            customerManager.AddCustomer(new Customer
            {
                Id = 3,
                FirstName = "Cem",
                LastName = "Yılmaz",
                AccountNumber = "442719332",
                TC = "65478932125"
            });

            customerManager.AddCustomer(new Customer
            {
                Id = 4,
                FirstName = "Abel",
                LastName = "Tesfaye",
                AccountNumber = "78214658",
                TC = "Not TC citizen"
            });
            Console.WriteLine();

            customerManager.ListCustomers();
            Console.WriteLine();

            customerManager.DeleteCustomer(38);
            Console.WriteLine();

            customerManager.ListCustomers();
        }
    }
}
