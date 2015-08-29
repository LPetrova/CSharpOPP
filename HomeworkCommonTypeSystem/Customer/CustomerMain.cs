namespace Customer
{
    using System;
    using System.Collections.Generic;

    public class CustomerMain
    {
        public static void Main()
        {
            var payFollow = new Payment("Desyatka", 10);

            var lusi = new Customer(
                "Lusi",
                "Sharapova",
                9502128796,
                088815500,
                "lusi@abv.bg",
                CustomerType.OneTime,
                payFollow);

            var doncho = lusi.Clone() as Customer;
            doncho.FirstName = "Doncho";
            doncho.LastName = "Petrov";

            Console.WriteLine(doncho);
            Console.WriteLine(lusi);

            var teodosi = new Customer(
                "teodosi",
                "Tyrnovski",
                85998838,
                0899339949,
                "teodosi@gmail.com",
                CustomerType.Diamond);

            var toncho = teodosi.Clone() as Customer;
            toncho.Id = 8234353535;
            toncho.LastName = "Karamazov";

            var customers = new List<Customer> { lusi, doncho, teodosi, toncho };
            customers.Sort();

            Console.WriteLine(string.Join(", ", customers));

        }
    }
}
