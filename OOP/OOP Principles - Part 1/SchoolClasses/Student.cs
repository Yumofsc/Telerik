using System;
using System.Collections.Generic;
using System.Linq;


namespace SchoolClasses
{
    public class Student : Person
    {
        private Guid classNumber; // Guid is used for generating UNIQUE 128bit values
        public Student(string name, Guid classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }
        public Guid ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, ClassNumber: {1}", this.Name, this.ClassNumber);
        }
    }
}


