namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy.Interfaces;

    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string id, string firstName, string lastName
            , decimal salary, Department department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        private List<Sale> sales;

        public List<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Sales cannot be null");
                }
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string sales = string.Join("\n", this.Sales);
            string info = String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}, Sales:\n{5}\n------\n",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department, sales);
            return info;
        }
    }
}