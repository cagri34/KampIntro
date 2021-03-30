using System;

namespace Inheritance
{
    // Interface 'lerde base yapı bir anlam ifade etmezken class da base yapı anlam ifade eder.
    // Çoklu kalıtım yapılamaz. (Bir classın tek bir ebeveyni olabilir.)

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{ FirstName = "Engin"},
                new Student{ FirstName = "Derin"},
                new Person{ FirstName = "Salih"}
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
}
