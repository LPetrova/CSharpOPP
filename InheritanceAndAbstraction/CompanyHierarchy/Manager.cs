namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CompanyHierarchy.Interfaces;

    class Manager : Employee, IManager
    {
        public Manager(string id, string firstName, string lastName
            , decimal salary, Department department, List<Employee> employeesUnderControl)
            : base(id, firstName, lastName, salary, department)
        {
            this.EmployeesUnderControl = employeesUnderControl;
        }
        private List<Employee> employeesUnderControl;

        public List<Employee> EmployeesUnderControl
        {
            get
            {
                return this.employeesUnderControl;
            }
            set
            {
                Utilities.ValidateList(value, "Employees under control");
                this.employeesUnderControl = value;
            }
        }

        public override string ToString()
        {
            string employees = string.Join(", ", this.EmployeesUnderControl
                .Select(e => e.FirstName + " " + e.LastName));
            string info = String.Format(
                "ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}, Employees under control: {5}\n------\n",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department, employees);
            return info;
        }
    }
}
