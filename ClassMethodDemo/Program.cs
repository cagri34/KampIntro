using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "Gökay";
            customer1.CustomerSurname = "Sarı";
            customer1.CustomerLocation = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Engin";
            customer2.CustomerSurname = "Demir";
            customer2.CustomerLocation = "Ankara";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();

            foreach (Customer customer in customers)
            {
                customerManager.Ekle(customer);
            }

            foreach (Customer customer in customers)
            {
                customerManager.Listele(customer);
            }

            foreach (Customer customer in customers)
            {
                customerManager.Sil(customer);
            }
            
        }
    }
}
