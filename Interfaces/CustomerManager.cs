using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Ekleme Kodları

            Console.WriteLine("Müşteri Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
}
