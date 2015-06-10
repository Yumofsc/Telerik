namespace PracticeStudentsAndWorkers
{
    using System;
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }


        public double Grade 
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentException("The grade must be betwen 2 and 6");
                }
                this.grade = value;
            }
        }
        public override string ToString()
        {
            return string.Format("First Name: {0}, Last Name: {1}, Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
