namespace DefiningClasses1
{
    using System;
    using System.Text;

    public class Battery
    {
        private int? hrsIdle;
        private int? hrsTalk;

        public Battery(BatteryType type, int? hrsIdle, int? hrsTalk)
        {
            this.Type = type;
            this.HrsIdle = hrsIdle;
            this.HrsTalk = hrsTalk;
        }

        public Battery(BatteryType type)
        {
            this.Type = type;
        }

        public BatteryType Type { get; set; }

        public int? HrsIdle
        {
            get
            {
                return this.hrsIdle;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }

                this.hrsIdle = value;
            }
        }
        
        public int? HrsTalk
        {
            get
            {
                return this.hrsTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }

                this.hrsTalk = value;
            }
        }
        
        public override string ToString()
        {
            var battinfo = new StringBuilder();

            battinfo.AppendFormat("Type: {0}", this.Type);

            if(this.hrsIdle != null)
            {
                battinfo.AppendFormat(", Hours Idle: {0}", this.hrsIdle);
            }

            if (this.hrsTalk != null)
            {
                battinfo.AppendFormat(", Hours Talk: {0}", this.hrsTalk);
            }

            return battinfo.ToString();
        }
    }
}
