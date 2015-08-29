namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy.Interfaces;

    class TestCompany
    {
        static void Main()
        {
            Sale phone = new Sale("XTC Galaxy One X mini Z X Y 2", new DateTime(2014, 12, 02), 850);
            Sale laptop = new Sale("Toshicer", new DateTime(2013, 03, 04), 1250);
            Sale graphicsCard = new Sale("nAti", new DateTime(2014, 11, 11), 450);
            Sale bike = new Sale("BMCross", new DateTime(2014, 12, 12), 650);
            Sale dumbbells = new Sale("Smart bells", new DateTime(2011, 05, 27), 50);

            List<Sale> electronics = new List<Sale>();
            electronics.Add(phone);
            electronics.Add(laptop);
            electronics.Add(graphicsCard);

            List<Sale> sports = new List<Sale>();
            sports.Add(bike);
            sports.Add(dumbbells);

            SalesEmployee maria = new SalesEmployee("012", "Maria", "Crow", 3400, Department.Accounting, electronics);
            SalesEmployee david = new SalesEmployee("013", "David", "Stevens", 3900, Department.Sales, sports);

            List<Employee> salesExperts = new List<Employee>();
            salesExperts.Add(maria);
            salesExperts.Add(david);

            Manager george = new Manager("005", "George", "Simmons", 5000, Department.Marketing, salesExperts);

            Project companyMobileApp = new Project("Company Mobile App", new DateTime(2014, 04, 03), State.Closed);
            Project antiHackingTool = new Project("Anti Hacking Tool", new DateTime(2014, 12, 03), State.Open);

            List<Project> importantProjects = new List<Project>();
            importantProjects.Add(antiHackingTool);
            importantProjects.Add(companyMobileApp);


            Developer mikey = new Developer("004", "Mikey", "Peters", 7000, Department.Production, importantProjects);

            List<Employee> employees = new List<Employee>();
            employees.Add(maria);
            employees.Add(david);
            employees.Add(george);
            employees.Add(mikey);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        
    }
}
