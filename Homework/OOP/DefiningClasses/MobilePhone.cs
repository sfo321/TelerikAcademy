namespace DefiningClasses1
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class MobilePhone
    {
        private const decimal PricePM = 0.37M;
        private static readonly MobilePhone iPhone4S = new MobilePhone("IPhone4S", "Apple", 600, "John Smith",
            new Battery(BatteryType.LiIon, 12, 4), new Display(5, 1600000));

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        public Battery battery;
        public Display display;

        public MobilePhone(string model, string manufacturer)
        {
            CallHistory = new List<Call>();
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public MobilePhone(string model, string manufacturer, decimal? price) : this(model, manufacturer)
        {
            this.Price = price;
        }

        public MobilePhone(string model, string manufacturer, decimal? price, string owner) : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public MobilePhone(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Must enter model!");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Must enter manufacturer!");
                }
                this.manufacturer = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be positive!");
                }
                this.price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static MobilePhone IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory { get; set; }

        public override string ToString()
        {
            var allinfo = new StringBuilder();
            
            allinfo.AppendFormat("Phone Model: {0}\n", this.model);
            allinfo.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            if (this.owner != null)
            {
                allinfo.AppendFormat("Owner: {0}\n", this.owner);
            }
            allinfo.AppendFormat("Price: {0}\n", this.price);
            allinfo.AppendFormat("Battery {0}\n", this.battery);
            allinfo.AppendFormat("Display {0}\n", this.display);

            return allinfo.ToString();
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public void CallInfo()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Console.WriteLine(CallHistory[i]);
            }
        }

        public void CallPrice()
        {
            decimal sum = 0;
            foreach (Call call in CallHistory)
            {
                sum += ((call.CallDuration / 60) * PricePM);
            }
            Console.WriteLine("{0} BGN", sum);
        }

        public void RemoveLongestCall()
        {
            Call longestCall = CallHistory[0];
            for (int i = 1; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].CallDuration > longestCall.CallDuration)
                {
                    longestCall = CallHistory[i];
                }
            }
            DeleteCall(longestCall);
        }
    }
}
