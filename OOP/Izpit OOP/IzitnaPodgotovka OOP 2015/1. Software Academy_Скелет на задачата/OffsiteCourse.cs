namespace SoftwareAcademy
{
    using System;
    using System.Text;
    public class OffsiteCourse: Course, ICourse, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
           : base(name, teacher)
        {
            this.Town = town;
        }
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Town can not be null or empty!");
                }
                this.town = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendFormat("; Town={0}", this.Town);

            return sb.ToString();
        }
    }
}
