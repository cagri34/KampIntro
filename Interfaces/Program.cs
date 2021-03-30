using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface temel anlamda şablon oluşturmak için kullanılır.
            // Interface new 'lenemez.
            // Interfaceler kendisini implemente eden classın referans numarasını tutabilirler.

            //IPersonManager personManager = new IPersonManager();
            //personManager.Add();

            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
        }
    }
}
