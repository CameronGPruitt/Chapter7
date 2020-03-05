using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class Cohort
    {
        //        Cohort
        //You must define a type for representing a cohort in code.

        //The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
        //make a constructor that accepts the cohorts name
        //The collection of students in the cohort.Hint: a List of<Student>
        //The collection of instructors in the cohort. Hint: a List of<Instructor>

        public string CohortName { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }

        public Cohort (string cohortName)
        {
            CohortName = cohortName;
            Students = new List<Student>();
            Instructors = new List<Instructor>();

        }

        public void AddStudent(Student newStudent)
        {
            newStudent.Cohort = this;
            Students.Add(newStudent);
        }

        public void AddInstructor(Instructor instructor)
        {
            instructor.Cohort = this;
            Instructors.Add(instructor);
        }
    }
}
