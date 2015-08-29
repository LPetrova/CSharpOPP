namespace CompanyHierarchy.Interfaces
{
    using System;

    public enum Department
    {
        Production,
        Accounting,
        Sales,
        Marketing
    }

    interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}