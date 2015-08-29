namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Animals;

    class AnimalTestMain
    {
        private static void Main()
        {

            Dog barry = new Dog("Barry", 13, Gender.Male);
            Dog jessica = new Dog("Jessica", 6, Gender.Female);
            Dog milo = new Dog("Milo", 17, Gender.Male);

            Kitten dona = new Kitten("Dona", 6);
            Kitten sweety = new Kitten("Sweety", 0);
            Kitten sisi = new Kitten("Sisi", 4);

            Tomcat zorro = new Tomcat("Zorro", 7);
            Tomcat lucky = new Tomcat("Lucky", 7);
            Tomcat tom = new Tomcat("Tom", 7);

            Frog randy = new Frog("Randy", 3, Gender.Male);
            Frog bob = new Frog("Bob", 6, Gender.Male);
            Frog sw = new Frog("Sw", 2, Gender.Male);

            IList<Animal> allAnimal = new List<Animal>();
            allAnimal.Add(barry);
            allAnimal.Add(jessica);
            allAnimal.Add(milo);
            allAnimal.Add(dona);
            allAnimal.Add(sweety);
            allAnimal.Add(sisi);
            allAnimal.Add(zorro);
            allAnimal.Add(lucky);
            allAnimal.Add(tom);
            allAnimal.Add(randy);
            allAnimal.Add(bob);
            allAnimal.Add(sw);

            foreach (var kind in allAnimal.GroupBy(x => x.GetType().Name))
            {
                double averageAge = kind.Select(x => x.Age).Average();
                Console.WriteLine("Animal : {0}, average age are: {1:F2}", kind.Key, averageAge);
            }
        }
    }
}
