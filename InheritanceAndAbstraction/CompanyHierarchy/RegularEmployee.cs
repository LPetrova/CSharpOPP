namespace CompanyHierarchy
{
    using System;
    using CompanyHierarchy.Interfaces;

    abstract class RegularEmployee : Employee, IRegularEmployee
    {
        protected RegularEmployee(string id, string firstName, string lastName
            , decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public override string ToString()
        {
            string info = String.Format("ID: {0}, Name: {1} {2}\n------\n",
                this.ID, this.FirstName, this.LastName);
            return info;
        }
    }
}