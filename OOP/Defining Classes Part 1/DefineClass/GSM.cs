namespace GSMMain
{
    using System;
    using System.Collections.Generic;
    // Define a class that holds information about a mobile phone device: model, manufacturer, price, owner
    public class GSM
    {
        public const double pricePerMinute = 0.27;

        private static GSM iPhone4S;

        private string gsmModel;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHisory = new List<Call>();

        public GSM(string gsmModel, string gsmManufacturer)
        {
            this.GsmModel = gsmModel;
            this.Manufacturer = gsmManufacturer;
        }

        public GSM(string gsmModel, string gsmManufacturer, double gsmPrice, string gsmOwner)
            : this(gsmModel, gsmManufacturer)
        {
            this.price = (decimal)gsmPrice;
            this.owner = gsmOwner;
        }
        public GSM(string gsmModel, string gsmManufacturer, double gsmPrice, string gsmOwner, Battery gsmBattery, Display gsmDisplay)
            : this(gsmModel, gsmManufacturer, gsmPrice, gsmOwner)
        {
            
            
            this.battery = gsmBattery;
            this.display = gsmDisplay;
        }

        public string GsmModel
        {
            get { return this.gsmModel; }
            set { this.gsmModel = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (price < 0)
                {
                    throw new IndexOutOfRangeException("The number of colors must not be negative");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery GSMBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display GSMDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }
        

        public List<Call> CallHisory
        {
            get 
            { 
                return this.callHisory; 
            }
           
        }
        public void AddCall(Call call)
        {
            this.callHisory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.callHisory.Remove(call);
        }
        public void ClearHisory(Call call)
        {
            this.callHisory.Clear();
        }
        public decimal CalculatesPrice(double gsmPrice)
        {
            int sumOfSeconds = 0;
            foreach (var item in CallHisory)
            {
                sumOfSeconds += item.Duration;
                
            }
            decimal totalPrice = (sumOfSeconds / 60) * (decimal)pricePerMinute;
            return totalPrice;
        }

        public static GSM IPhone4S
        {
            get 
            {
                return iPhone4S = new GSM("iPhone4S", "Apple", 1000, "Antoan");
            }
            
        }

        public override string ToString()
        {
            return this.gsmModel + " " + this.manufacturer + " " + this.price + " " + this.owner + " " + this.battery + " " + this.display;
        }    
                                                                                          
    }
}
