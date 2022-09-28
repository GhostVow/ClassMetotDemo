using System;

namespace ConsoleUI
{
    internal class Program
    {
        static CustomerManager _customerManager;

        static void Main(string[] args)
        {
            while (true)
            {
                _customerManager = new CustomerManager();

                int choice;
                string choiceScreenText = "[1] - Müşteri Ekle \n[2] - Müşteri Sil \n[3] - Müşterileri Listele \n[4] - Exit";

                Console.WriteLine(choiceScreenText);
                Console.Write("İşlem: ");
                choice = int.Parse(Console.ReadLine());

                SelectRouting(choice);
                Console.ReadLine();
                Console.Clear();
            }
            

        }

        static void SelectRouting(int choice)
        {
            switch (choice)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Delete();
                    break;
                case 3:
                    GetList();
                    break;
                case 4:
                    Exit();
                    break;
                default:
                    break;
            }
        }

        private static void Exit()
        {
            Environment.Exit(-1);
        }

        static void Add()
        {
            Customer customer = new Customer();

            customer.Id = CreateId();
            Console.Write("Müşteri İsim: ");
            customer.FirstName = Console.ReadLine();

            Console.Write("Müşteri Soyisim: ");
            customer.LastName = Console.ReadLine();

            Console.Write("Müşteri Email: ");
            customer.Email = Console.ReadLine();


            _customerManager.Add(customer);


        }

        static void Delete()
        {
            Customer customer = new Customer();

            Console.Write("Müşteri Id: ");
            customer.Id = int.Parse(Console.ReadLine());

            _customerManager.Delete(customer);
        }

        static void GetList()
        {

            _customerManager.GetList();
        }

        static int CreateId()
        {
            int id = 0;
            return id;
        }

    }
}
