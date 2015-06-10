using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define a class that holds information about a battery characteristics (model, hours idle and hours talk).

namespace GSMMain
{
    public class Battery
    {
        private BatteryType model;
        private double hoursIdle;
        private double hoursTalk;

        public Battery(BatteryType batteryModel, double batteryHoursIdle, double batteryHoursTalk)
        {
            this.Model = batteryModel;
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
        }
        public BatteryType Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (hoursIdle < 0)
                {
                    throw new IndexOutOfRangeException("Hours must not be negative");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (hoursIdle < 0)
                {
                    throw new IndexOutOfRangeException("Hours must not be negative");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public override string ToString()
        {
            return this.model + " " + this.hoursIdle + " " + this.hoursTalk;
        }
    }
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
    }
}
