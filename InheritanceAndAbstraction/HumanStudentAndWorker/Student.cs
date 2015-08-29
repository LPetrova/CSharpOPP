namespace HumanStudentAndWorker
{
    using System;
    using System.Text.RegularExpressions;

    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Faculty number cannot be null or empty");
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    throw new ArgumentException("Faculty number must contain 5-10 digits / letters");
                }
                this.facultyNumber = value;
            }
        }
    }
}
