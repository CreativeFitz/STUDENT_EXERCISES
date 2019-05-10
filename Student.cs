using System;
using System.Collections.Generic;

namespace StudentExercises{
    class Student : Person {

        public List<Exercise> Exercises {get;set;} = new List<Exercise>();

        public Exercise getExerciseById (int id){
            return Exercises[id];
        }
    }
}