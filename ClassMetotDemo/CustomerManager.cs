using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void ShowCustomers ()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri ID:" +customer.Id);
                Console.WriteLine("Müşteri adı ve soy adı:" + customer.Name+""+ customer.Surname);
                
            }
           
        }
            
        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        } 
    }
}
