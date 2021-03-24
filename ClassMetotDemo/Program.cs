using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.FirstName = "Hakan";
            customer1.LastName = "Türkoğlu";
            customer1.TcNo = "100000000000";
            customer1.Password = "hakan54";
            customer1.CustomerNumber = "5454544568796";

            Musteri customer2 = new Musteri();
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer1.TcNo = "100754879785";
            customer2.Password = "engin_91";
            customer2.CustomerNumber = "779851469545646";

            Musteri customer3 = new Musteri();
            customer3.FirstName = "Bora";
            customer3.LastName = "Süzgün";
            customer3.TcNo = "100754879785";
            customer3.Password = "engin_91";
            customer3.CustomerNumber = "779851469545646";

            Musteri[] customers = new Musteri[] {customer1,customer2, customer3};

            CustomerManager customerManager = new CustomerManager();

            //customerManager.CustomerAdd(customer1);
            //customerManager.CustomerDelete(customer2);

            //foreach (Musteri musteri in customers)
            //{
            //    customerManager.CustomerList(musteri);
            //}

            customerManager.CustomerList(customers);

        }
    }
}
