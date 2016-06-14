namespace DefiningClasses1
{
    using System;
    using System.Text;

    public class Call
    {
        private string date;
        private string time;
        private string dialedNumber;
        private int callDuration; 

        public Call(DateTime datetime, string dialedNumber, int callDuration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedNumber = dialedNumber;
            this.CallDuration = callDuration;
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            internal set
            {
                this.date = DateTime.Now.ToShortDateString();
            }
        }
        
        public string Time
        {
            get
            {
                return this.time;
            }
            internal set
            {
                this.time = DateTime.Now.ToShortTimeString();
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Number dialled cannot be empty!");
                }
                this.dialedNumber = value;
            }
        }

        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("The call duration cannot be less than 1 second!");
                }
                this.callDuration = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("Call date: {0}\n", this.Date);
            result.AppendFormat("Call time: {0}\n", this.Time);
            result.AppendFormat("Dialled number: {0}\n", this.DialedNumber);
            result.AppendFormat("Call duration: {0}seconds\n", this.CallDuration);

            return result.ToString();
        }
    }
}
