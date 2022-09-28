using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Müşteri eklendi. Müşteri ID: {customer.Id}");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi.");
        }

        public void GetList()
        {
            Console.WriteLine("Müşteri Listelendi.");
        }

    }
}
