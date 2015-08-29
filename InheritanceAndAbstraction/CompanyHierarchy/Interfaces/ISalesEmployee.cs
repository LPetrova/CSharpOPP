namespace CompanyHierarchy.Interfaces
{
     using System;
     using System.Collections.Generic;

    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; } 
    }
}