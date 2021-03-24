using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!! Müşteri Adı: " + musteri.FirstName);
        }

        public void CustomerDelete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!! Müşteri Adı: " + musteri.FirstName);
        
        }

        public void CustomerList(Musteri musteriler)
        {
            Console.WriteLine("Müşteri: " + musteriler.FirstName + " " + musteriler.LastName);
        }

        public void CustomerList(Musteri[]customers)
        {
            foreach (var musteri in customers)
            {
                Console.WriteLine("Müşteri: " + musteri.FirstName + " " + musteri.LastName);
            }
        }

    }
}
