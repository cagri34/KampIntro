using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici yedi.");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Yönetici çalıştı.");
        }
    }
}
