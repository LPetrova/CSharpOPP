using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class PersonMain
    {
        static void Main()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter email: (optional)");
            string email = Console.ReadLine();

            if (email == "")
            {
                email = null;
            }

            Person person = new Person(name, email, age);
            Console.WriteLine(person);
        }
    }
}
