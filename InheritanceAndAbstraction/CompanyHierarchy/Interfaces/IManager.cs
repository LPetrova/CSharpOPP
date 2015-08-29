namespace CompanyHierarchy.Interfaces
{
    using System;
    using System.Collections.Generic;

    interface IManager
    {
        List<Employee> EmployeesUnderControl { get; set; }
    }
}