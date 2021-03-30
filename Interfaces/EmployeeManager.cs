using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Çalışan Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Çalışan Güncellendi.");
        }
    }
}
