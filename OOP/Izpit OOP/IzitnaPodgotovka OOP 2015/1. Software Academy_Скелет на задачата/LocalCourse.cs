namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public class LocalCourse : Course, ILocalCourse, ICourse
    {
       private string lab;

       public LocalCourse(string name, ITeacher teacher, string lab)
           : base(name, teacher)
       {
           this.Lab = lab;
       }
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException("Lab can not be null or empty!");
                }
                this.lab = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendFormat("; Labs=[{0}]", this.Lab);

            return sb.ToString();
        }
    }
}
