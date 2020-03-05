using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class Instructor
    {
        //        Instructor
        //You must define a type for representing an instructor in code.

        //First name
        //Last name
        //Slack handle
        //The instructor's cohort
        //The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
        //A method to assign an exercise to a student

        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName; 
            
        }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Assignments.Add(exercise);
        }

        private string FirstName { get; }
        private string LastName { get; }
        private string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }



    }
}
