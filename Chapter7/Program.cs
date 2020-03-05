using System;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 4, or more, exercises.
            Exercise Exercise1 = new Exercise()
            {
                exercise = "Hello World",
                language = "C#"
            };
            Exercise Exercise2 = new Exercise()
            {
                exercise = "Planets",
                language = "C++"
            };
            Exercise Exercise3 = new Exercise()
            {
                exercise = "Dictionaries",
                language = "C#"
            };
            Exercise Exercise4 = new Exercise()
            {
                exercise = "Numbers",
                language = "C++"
            };

            //Create 3, or more, cohorts.
            Cohort Cohort1 = new Cohort("Morning Cohort 1");
            Cohort Cohort2 = new Cohort("Evening Cohort 1");
            Cohort Cohort3 = new Cohort("Evening Cohort 2");

            //Create 4, or more, students and assign them to one of the cohorts.
            Student A1 = new Student("Cameron", "Pruitt");
            Student A2 = new Student("Ben", "King");
            Student A3 = new Student("David", "King");
            Student A4 = new Student("Ronald", "Riner");

            Cohort1.AddStudent(A1);
            Cohort1.AddStudent(A2);
            Cohort2.AddStudent(A3);
            Cohort3.AddStudent(A4);

            //Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor B1 = new Instructor("Russel", "Miller");
            Instructor B2 = new Instructor("Cory", "Brown");
            Instructor B3 = new Instructor("Josh", "Joseph");

            Cohort1.AddInstructor(B1);
            Cohort2.AddInstructor(B2);
            Cohort3.AddInstructor(B3);

            //Have each instructor assign 2 exercises to each of the students.
            B1.AssignExercise(A1, Exercise1);
            B1.AssignExercise(A1, Exercise2);

            B1.AssignExercise(A2, Exercise1);
            B1.AssignExercise(A2, Exercise2);

            B2.AssignExercise(A3, Exercise3);
            B2.AssignExercise(A3, Exercise4);

            B2.AssignExercise(A4, Exercise3);
            B2.AssignExercise(A4, Exercise4);



            Console.WriteLine("Done");
        }
    }
}
