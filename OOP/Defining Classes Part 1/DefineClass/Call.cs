namespace GSMMain
{
    using System;
    using System.Collections.Generic;


    public class Call
    {
        private DateTime date;
        private string dialledPhone;
        private int duration;

        public Call(DateTime date, string dialledPhone, int duration)
        {
            this.Date = date;
            this.DialledPhone = dialledPhone;
            this.Duration = duration; //in seconds
        }


        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string DialledPhone
        {
            get { return this.dialledPhone; }
            set 
            {
                if (value[0] == '+')
                {
                    this.dialledPhone = value;
                }
                else
                {
                    throw new FormatException("the first sign of the phone number must be \"+\"");
                }
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set 
            {
                if (duration < 0)
                {
                    throw new IndexOutOfRangeException("Duration can not be negative");
                }
                else
                {
                    this.duration = value;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("Date: {0}\n" + "Time: {1}\n" + "Dialed phone: {2}\n" + "Duration: {3} seconds\n", this.date.ToString("dd/MM/yy"), this.date.ToString("HH:mm:ss"), this.dialledPhone, this.duration);
        }


    }
}
