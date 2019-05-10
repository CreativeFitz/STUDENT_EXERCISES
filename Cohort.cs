using System;
using System.Collections.Generic;

namespace StudentExercises {

    class Cohort {
        public int id {get; set;}

        public string name {get; set;}

        public List<Student> StudentList {get;set;} = new List<Student>();

        public List<Instructor> InstructorList {get;set;} = new List<Instructor>();
    }
}