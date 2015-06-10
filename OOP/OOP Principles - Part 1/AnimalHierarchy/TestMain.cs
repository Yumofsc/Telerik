﻿using System;
using System.Collections.Generic;

namespace AnimalHierarchy
{
    /*Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
     */
    public class TestMain
    {
        static void Main()
        {
            Dog[] dogsArray = 
            {
                new Dog ("Doggy", 7, Gender.Male, "German shepard"),
                new Dog ("Moggy", 5, Gender.Female, "German shepard"),
                new Dog ("Zoggy", 3, Gender.Female, "Not german shepard"),
                new Dog ("Foggy", 5, Gender.Male, "I dont' know many dog breeds...")
            };

            Frog[] frogsArray = 
            {
                new Frog ("Chumba", 2, Gender.Male, "Wood frog"),
                new Frog ("Zumba", 6, Gender.Male, "Tree frog")
            };

            Cat[] cats = 
            {
                new Cat("Tiger", 2, Gender.Male, "Ragdoll"),
                new Cat("Lionese", 8, Gender.Female, "Ulichna prevuzhodna")
            };

            Kitten[] pussyArray = 
            {
                new Kitten ("QUEEN OF THE HUMAN RACE", 12, "Siamese"),
                new Kitten ("Destoyer of mice", 6, "British shorthair"),
                new Kitten ("Kitkat", 10, "Ragdoll")
            };

            Tomcat[] tomcatsArray = 
            {
                new Tomcat ("KING OF THE HUMAN RACE", 11, "Siamese"),
                new Tomcat ("Burgerz", 7, "Turkish angora"),
                new Tomcat ("Fuggles", 3, "Siberian cat")
            };

            Animal[][] animals = 
            {
                dogsArray,
                frogsArray,
                cats,
                pussyArray,
                tomcatsArray
            };

            Console.WriteLine("Animal sounds below: \n");
            foreach (var animalArray in animals)
            {
                Console.WriteLine("> {0}", GetTypeName(animalArray));
                foreach (var animal in animalArray)
                {
                    Console.Write("   -");
                    animal.ProduceSound();
                }
            }

            Console.WriteLine("\nAverage age of animals:\n");
            foreach (var animalArray in animals)
            {
                Console.WriteLine("{0}: {1:F2} years", GetTypeName(animalArray), Animal.AverageAge(animalArray));
            }
        }

        private static string GetTypeName(Animal[] animalArray)
        {
            return animalArray.GetType().Name.Trim(new char[] { '[', ']' });
        }
    }
}