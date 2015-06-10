namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Classes : IComment
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private Guid uniqueId; // Guid is used for generating UNIQUE 128bit values
        private string comment;

        public Classes(Guid uniqueId)
        {
            this.UniqueId = uniqueId;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public Guid UniqueId
        {
            get
            {
                return this.uniqueId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Cannot be null or empty!");
                }
                this.uniqueId = value;
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
        public void AddTeachers(List<Teacher> teachers)
        {
            this.teachers.AddRange(teachers);
        }
        public void AddStudents(List<Student> students)
        {
            this.students.AddRange(students);
        }
        public List<Teacher> GetTeachers()
        {
            return this.teachers.ToList();
        }

        public List<Student> GetStudents()
        {
            return this.students.ToList();
        }

        public override string ToString()
        {
            return this.UniqueId.ToString();
        }
    }

}
