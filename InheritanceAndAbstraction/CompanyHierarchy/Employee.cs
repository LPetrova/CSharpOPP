namespace CompanyHierarchy
{
    using System;
    using CompanyHierarchy.Interfaces;

    abstract class Employee : Person, IEmployee
    {
        protected Employee(string id, string firstName, string lastName
            , decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        private decimal salary;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                Utilities.ValidateNumber(value, "Salary");
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            string info = String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}\n------\n",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);
            return info;
        }
    }
}
