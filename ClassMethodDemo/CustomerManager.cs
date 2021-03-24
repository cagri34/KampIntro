using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine(customer.Id + " .ci " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerLocation + " ndan sisteme eklendi.");
        }

        public void Listele(Customer customer)
        {
            Console.WriteLine("Id : " + customer.Id);
            Console.WriteLine("Müşteri Adı : " + customer.CustomerName);
            Console.WriteLine("Müşteri Soyadı : " + customer.CustomerSurname);
            Console.WriteLine("Müşteri Lokasyon : " + customer.CustomerLocation);
            Console.WriteLine("------------------------------------------------------------");
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.Id + " .ci " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerLocation + " ndan sistemenden silindi.");
        }
    }
}
