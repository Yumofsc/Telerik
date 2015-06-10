
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string schoolName;
        private List<Classes> classes;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.classes = new List<Classes>();
        }

        public string SchoolName 
        {
            get
            {
                return this.schoolName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of the school can not have null value");
                }
                this.schoolName = value;
            }
        }
        public List<Classes> Classes
        {
            get
            {
                return this.classes;
            }
        }

        public void AddClasses(Classes currentClass)
        {
            this.Classes.Add(currentClass);
        }

        public override string ToString()
        {
            return this.schoolName;
        }
    }
}
