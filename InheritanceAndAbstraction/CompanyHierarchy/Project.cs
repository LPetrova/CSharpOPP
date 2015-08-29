namespace CompanyHierarchy
{
    using System;

    public enum State
    {
        Open,
        Closed
    }

    class Project
    {
        public Project(string name, DateTime projectStartDate, State state)
        {
            this.Name = name;
            this.ProjectStartDate = projectStartDate;
            this.State = state;
        }

        private string name;
        private DateTime projectStartDate;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Utilities.ValidateString(value, "Name");
                this.name = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Project start date cannot be null");
                }
                this.projectStartDate = value;
            }
        }

        public State State { get; set; }

        public override string ToString()
        {
            string info = String.Format("Project name: {0}, Project start date: {1}, State: {2}",
                this.ProjectStartDate, this.ProjectStartDate, this.State);
            return info;
        }
    }
}
