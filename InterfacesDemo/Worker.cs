using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    // Bir Class birden fazla implement edebilir.

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("İşçi yedi.");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("İşçi çalıştı.");
        }
    }
}
