using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        //private readonly Battery baterryDescr ;
        private decimal price;
        private Battery batteryDescr;


        public Battery BatteryDescr { get; set; }


        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.batteryDescr = battery;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop description:  ");
            result.AppendLine("Model: " + this.model);

            if (manufacturer != null)
            {
                result.AppendLine("Manufacturer: " + this.manufacturer);
            }
            if (processor != null)
            {
                result.AppendLine("Processor: " + this.processor);
            }
            if (ram > 0)
            {
                result.AppendLine("RAM: " + this.ram + "GB");
            }
            if (graphicsCard != null)
            {
                result.AppendLine("Graphics card " + this.graphicsCard);
            }
            if (hdd > 0)
            {
                result.AppendLine("HDD: " + this.hdd);
            }
            if (screen != null)
            {
                result.AppendLine("Screen: " + this.screen);
            }
            if (batteryDescr.BatteryModel != null)
            {
                result.AppendLine("Battery model: " + this.batteryDescr.BatteryModel);
            }
            if (batteryDescr.BatteryLife > 0)
            {
                result.AppendLine("Battery: " + this.batteryDescr.BatteryLife + "hour");
            }

            result.AppendLine("Price is: " + this.price + "lv.");
            return result.ToString();

        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model value cannot be empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer value cannot be empty!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor value cannot be empty!");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ram must be > 0");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphics card value cannot be empty!");
                }
                this.graphicsCard = value;
            }
        }

        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hdd must be > 0");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen card value cannot be empty!");
                }
                this.screen = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative number!");
                }
                this.price = value;
            }
        }

    }
}
