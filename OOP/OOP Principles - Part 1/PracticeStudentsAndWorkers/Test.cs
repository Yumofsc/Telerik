namespace PracticeStudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Brus", "Wane", 5.50));
            students.Add(new Student("Antony", "Hopkins", 3.75));
            students.Add(new Student("David", "Beckham", 4.33));
            students.Add(new Student("Kaloqn", "Ivanov", 6.00));
            students.Add(new Student("Petur", "Grigorov", 3.25));
            students.Add(new Student("Andrey", "Lqpchev", 5.12));
            students.Add(new Student("Grigor", "Dimitrov", 4.25));
            students.Add(new Student("Ivailo", "Petev", 5.75));
            students.Add(new Student("Hristo", "Georgiev", 3.50));
            students.Add(new Student("Hristofor", "Kolumb", 5.00));

            students.OrderBy(x => x.Grade).ToList();
            Console.WriteLine("The students order by grade are:\n");
            Console.WriteLine(String.Join("\n",students));

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Dragan", "Cankov", 150, 8));
            workers.Add(new Worker("Pencho", "Stoqnov", 200, 12));
            workers.Add(new Worker("Stanka", "Zlateva", 300, 7));
            workers.Add(new Worker("Ivan", "Popov", 235, 8));
            workers.Add(new Worker("Vladislav", "Valeriev", 643, 8));
            workers.Add(new Worker("Gospodin", "Peichev", 100, 2));
            workers.Add(new Worker("Goran", "Blagoev", 200, 7));
            workers.Add(new Worker("Iveta", "Gaidarova", 333, 8));
            workers.Add(new Worker("Krasimir", "Petrov", 345, 7));
            workers.Add(new Worker("Viktor", "Ivanov",500 , 8));

            workers.OrderBy(x => x.MoneyPerHour()).ToList();
            Console.WriteLine("The workers order by Money per hour\n");
            Console.WriteLine(String.Join("\n",workers));
        }
    }
}
