
namespace SchoolClasses
{
    using System;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;
        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        //public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment)
        //    : this(name, numberOfLectures, numberOfExercises)
        //{
        //    this.Comment = comment;
        //}
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
                    throw new ArgumentNullException("The name can not be null or empty");
                }
                this.name = value;
            }

        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures can't be negative number");
                }
                this.numberOfLectures = value;
            }

        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises can't be negative number");
                }
                this.numberOfLectures = value;
            }
        }
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public override string ToString()
        {
            return string.Format("Discipline name = {0}, Number of Lecutre = {1}, Number of Exercises = {2}", this.name, this.numberOfLectures, this.numberOfExercises);
        }

        
    }
}
