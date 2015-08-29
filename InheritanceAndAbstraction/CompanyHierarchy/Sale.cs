namespace CompanyHierarchy
{
    using System;

    class Sale
    {
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        private string productName;
        private DateTime date;
        decimal price;

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                Utilities.ValidateString(value, "Product Name");
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Date cannot be null");
                }
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            string info = String.Format("Product Name: {0}, Date: {1}, Price: {2}",
                this.ProductName, this.Date.ToShortDateString(), this.Price);
            return info;
        }
    }
}