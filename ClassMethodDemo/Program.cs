using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.CustomerName = "Özgür";
            customer.CustomerSurName = "Rüzgar";    
            
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Engin";
            customer2.CustomerSurName = "Demiroğ";    
            
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerName = "Mert";
            customer3.CustomerSurName = "Aktaş";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer2);
            customerManager.Delete(customer3);
            customerManager.Select(customer3);
        }
    }
}
