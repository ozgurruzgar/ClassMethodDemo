using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.CustomerName} {customer.CustomerSurName} İsimli Müşteri Sisteme Eklendi.");
        }        
        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.CustomerName} {customer.CustomerSurName} İsimli Müşteri Sistemden Silindi.");
        }        
        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer.CustomerName} {customer.CustomerSurName} İsimli Müşteri Güncellendi.");
        }        
        public void Select(Customer customer)
        {
            Console.WriteLine($"Müşteri Bilgileri {customer.Id} {customer.CustomerName} {customer.CustomerSurName} ");
        }
    }
}
