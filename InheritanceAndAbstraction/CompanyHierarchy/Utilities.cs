namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    static class Utilities
    {
        public static void ValidateString(string input, string propertyName)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("{0} cannot be null or empty");
            }
        }

        public static void ValidateNumber(object input, string propertyName)
        {
            if (input as int? < 0)
            {
                throw new ArgumentException("{0} cannot be negative");
            }
        }

        public static void ValidateList<T>(List<T> list, string propertyName)
        {
            if (list == null)
            {
                throw new ArgumentNullException("{0} cannot be null", propertyName);
            }
        }
    }
}
