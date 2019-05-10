using System;

namespace StudentExercises{

    class Instructor : Person {

        public void AssignExercise(Exercise exerciseToAssign, Student studentToAssign){
            studentToAssign.Exercises.Add(exerciseToAssign);

            Console.WriteLine($"{FirstName} just assigned {exerciseToAssign.Name} to {studentToAssign.FirstName}.");
        }
    }
}