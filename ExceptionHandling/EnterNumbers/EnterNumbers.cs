namespace EnterNumbers
{
    using System;

    class EnterNumbers
    {

        private static int ReadNumber(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentException("Specified values do not represent a valid range.");
            }

            Console.Write("Enter an integer in the range {0}, {1}:  ", start, end);
            string inputValue = Console.ReadLine();

            int number = int.Parse(inputValue);

            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException("Input value was out of the range of valid values.");
   
            }

            return number;
        }

        static void Main()
        {
            int start = 1;
            int end = 100;
            int numCount = 10;

            for (int i = 0; i < numCount; i++)
            {
                try
                {
                    int number = ReadNumber(start, end);
                    start = number;
                }
                catch (ArgumentException a)
                {
                    i--;
                    Console.WriteLine(a.Message);
                }
                catch (FormatException b)
                {
                    i--;
                    Console.WriteLine(b.Message);
                }
                catch (OverflowException c)
                {
                    i--;
                    Console.WriteLine(c.Message);
                }
            }
        }
    }
}
