
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class SchoolMain
    {
        static void Main()
        {
            Guid uniqueId = new Guid();
            Guid classNumber = new Guid();

            //Create a School
            School mySchool = new School("Comics");

            //Create Students and List of them
            Student batman = new Student("Batman", classNumber = Guid.NewGuid());
            Student robin = new Student("Robin", classNumber = Guid.NewGuid());
            Student spinderman = new Student("Spinderman", classNumber = Guid.NewGuid());

            List<Student> students = new List<Student>();
            students.Add(batman);
            students.Add(robin);
            students.Add(spinderman);

            //Create Disciplines
            Discipline flying = new Discipline("Flying", 10, 8);
            Discipline fighting = new Discipline("Fighting Bad Guys", 100, 150, "It hurts first 30 exercices");
            Discipline survive = new Discipline("Survie", 40, 56);

            //Create Teachers

            Teacher alfred = new Teacher("Alfred");
            Teacher bruslee = new Teacher("Brus Lee");
            Teacher dumbledore = new Teacher("Dumbledore");

            //Add disciplines to them
            alfred.AddDisciplines(flying);
            bruslee.AddDisciplines(fighting);
            dumbledore.AddDisciplines(survive);

            //Creating a List of Teachers
            List<Teacher> teachers = new List<Teacher>() { alfred, bruslee, dumbledore };

            //Generate a Class
            Classes superheroesClass = new Classes(uniqueId = Guid.NewGuid());
            superheroesClass.AddStudents(students);
            superheroesClass.AddTeachers(teachers);

            //Add a comment
            superheroesClass.Comment = "We are Awesome";

            //Add class to School
            mySchool.AddClasses(superheroesClass);

            PrintResult(mySchool);
        }

        private static void PrintResult(School school)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(school.SchoolName);

            foreach (var currentClass in school.Classes)
            {
                result.AppendLine(" #Class unique identifier: " + currentClass.UniqueId);

                foreach (var teacher in currentClass.GetTeachers())
                {
                    result.Append(" #Teacher");
                    result.AppendLine(" - " + teacher);

                    foreach (var discipline in teacher.GetDisciplines())
                    {
                        result.AppendLine("     > " + discipline);
                    }
                }

                result.AppendLine(" #Students");
                foreach (var student in currentClass.GetStudents())
                {
                    result.AppendLine("     > " + student);
                }
            }

            Console.WriteLine(result.ToString());

            
        }


    }
}

