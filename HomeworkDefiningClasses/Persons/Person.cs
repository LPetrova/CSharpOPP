using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        private int age;
        private string name;
        private string email;

        public Person(string name, string email, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get { return this.name; }
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new ArgumentException("Name cannot be null or empty.");

                }

                this.name = value;
             }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Age must be in the range [1 ... 100]");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (value != null )
                {
                    if (!value.Contains("@"))
                    {
                        throw new ArgumentException(@"Email must has ""@"" !");
                    }   
                }
                this.email = value;
            }

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Name: {0}\nAge: {1}", this.Name, this.Age));

            if (!string.IsNullOrEmpty(email))
            {
                result.AppendLine("Email: " + this.Email);
            }

           return result.ToString();
        }
    }
}
