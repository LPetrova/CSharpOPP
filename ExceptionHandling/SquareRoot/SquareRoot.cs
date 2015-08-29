using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Square root for negative numbers is undefined.");
            }

            return Math.Sqrt(value);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer to calculate its square root: ");
            string number = Console.ReadLine();

            try
            {
                int n = Int32.Parse(number);

                double sqrt = Sqrt(n);

                Console.WriteLine("The square root of {0} is {1:N4}.", n, sqrt);
            }

            catch (FormatException a)
            {

                Console.WriteLine(a.Message);
            }
            catch (OverflowException b)
            {
                Console.WriteLine(b.Message);
            }
            catch (ArgumentOutOfRangeException c)
            {
                Console.WriteLine(c.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
