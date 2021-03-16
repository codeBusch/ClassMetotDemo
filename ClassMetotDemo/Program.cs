using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            CustomerManager customerManager = new CustomerManager();
            customer1.Id = 52;
            customer1.Name = "Melih";
            customer1.Surname = "Sivri";
            customerManager.AddCustomer(customer1);
            customerManager.ShowCustomers();

            
        }
    }
}
