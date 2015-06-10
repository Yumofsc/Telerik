namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
   public  class Teacher : ITeacher
    {
       private string name;
       private ICollection<ICourse> courses;
       public Teacher(string name)
       {
           this.Name = name;
           this.courses = new List<ICourse>();
       }

        public string Name
        {
           get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teacher name can not be null or empty");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }

        //Teacher: Name=(teacher name); Courses=[(course names – comma separated)]
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Teacher: Name={0}", this.Name);
            if (courses.Count > 0)
            {
                sb.AppendFormat("; Courses=[{0}]", string.Join(", ", this.courses.Select(c => c.Name)));
            }

            return sb.ToString();

        }
    }
}
