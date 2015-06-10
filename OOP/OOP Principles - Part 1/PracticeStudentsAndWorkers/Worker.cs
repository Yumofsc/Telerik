namespace PracticeStudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHouresPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("The salary can not be less than zero");
                }
                this.weekSalary = value;
            }

        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0 || value > 12 )
                {
                    throw new ArgumentException("The work hours must been between 1 and 8");
                }

                this.workHoursPerDay = value;
            }

        }
        public double MoneyPerHour()
        {
            
            double moneyPerHour = (weekSalary / 5) / workHoursPerDay;
            return moneyPerHour;
        }
        public override string ToString()
        {
            return string.Format("First Name: {0}, Last Name: {1}, Week Salary: {2}, Work hours per day: {3}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
