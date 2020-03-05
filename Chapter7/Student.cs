using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class Student
    {
        //        Student
        //You must define a type for representing a student in code.A student can only be in one cohort at a time.A student can be working on many exercises at a time.

        //Properties
        //First name of type string
        //Last name of type string
        //Slack handle of type string
        //The student's cohort of type Cohort(the next custom class you will create in this assignment)
        //The collection of exercises that the student is currently working on.Hint: A List of type Exercise


        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Assignments = new List<Exercise>();
        }

        private string FirstName { get; }
        private string LastName { get; }
        private string SlackHandle { get; set; }
        public Cohort Cohort { get; set;}
        public List<Exercise> Assignments { get; set; }
    }
}
