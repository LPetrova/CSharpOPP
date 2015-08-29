namespace CompanyHierarchy.Interfaces
{
    using System;

    interface IPerson
    {
        string ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}