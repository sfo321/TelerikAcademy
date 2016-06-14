namespace DefiningClasses1
{
    using System;
    using System.Text;

    public class Display
    {
        private decimal size;
        private long? colors;

        public Display(decimal size, long? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public Display(decimal size)
        {
            this.Size = size;
        }

        public decimal Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                this.size = value;
            }
        }

        public long? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                this.colors = value;
            }
        }
        public override string ToString()
        {
            var dispinfo = new StringBuilder();
          
            dispinfo.AppendFormat("Size: {0}", this.size);          

            if (this.colors != null)
            {
                dispinfo.AppendFormat(", Colors: {0}", this.colors);
            }

            return dispinfo.ToString();
        }
    }
}
