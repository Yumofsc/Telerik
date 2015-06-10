using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Person : IComment
    {
        private string name;
        private string comment;
        public Person(string name, string comment = null)
        {
            this.Name = name;
            this.Comment = comment;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The name can not haver null value");
                }
                this.name = value;
            }
        }


        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
