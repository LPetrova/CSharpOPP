﻿namespace StringDisperser
{
    using System;
    using System.Collections.Generic;

    public class StringDisperserMain
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "maria");

            StringDisperser stringDisperser2 = new StringDisperser("joro", "mitko", "penko");

            Console.WriteLine(stringDisperser2 == stringDisperser);
            Console.WriteLine(stringDisperser2 != stringDisperser);
            Console.WriteLine(stringDisperser.Equals(stringDisperser2));
            Console.WriteLine(stringDisperser);

            var stringDisperser3 = stringDisperser.Clone() as StringDisperser;
            stringDisperser3.Strings.Add("Mlechko");
            Console.WriteLine(stringDisperser3);
            Console.WriteLine(stringDisperser);

            Console.WriteLine();
            var stringDespersers = new List<StringDisperser> { stringDisperser, stringDisperser2, stringDisperser3 };
            stringDespersers.Sort();
            Console.WriteLine(string.Join("\n", stringDespersers));

            Console.WriteLine();
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
