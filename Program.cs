using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise nutshell = new Exercise {
                Name = "Nutshell",
                Language = "Javascript"
            };
            Exercise nashville = new Exercise {
                Name = "Welcome to Nashville",
                Language = "Javascript"
            };
            Exercise studentEx = new Exercise {
                Name = "Student Exercises",
                Language = "C#"
            };
            Exercise boogers = new Exercise {
                Name = "Boogers",
                Language = "Javascript"
            };
            Cohort CohortOne = new Cohort {
                name = "Cohort 1"
            };
            Cohort CohortTwo = new Cohort {
                name = "Cohort 2"
            };
            Cohort CohortThree = new Cohort {
                name = "Cohort 3"
            };
            Student Bobby = new Student {
                FirstName = "Bobby",
                LastName = "Fitzpatrick",
                SlackHandle = "@BobFitz",
                CurrentCohort = CohortOne
            };
            Student Russ = new Student {
                FirstName = "Russ",
                LastName = "Miller",
                SlackHandle = "@RussMill",
                CurrentCohort = CohortOne
            };
            Student Matt = new Student {
                FirstName = "Matt",
                LastName = "Rowe",
                SlackHandle = "@DaRowe",
                CurrentCohort = CohortOne
            };
            Instructor Kim = new Instructor {
                FirstName = "Kim",
                LastName = "Preece",
                SlackHandle = "@KimP",
                CurrentCohort = CohortOne
            };
            Instructor Josh = new Instructor {
                FirstName = "Josh",
                LastName = "Joseph",
                SlackHandle = "@JoeJ",
                CurrentCohort = CohortOne
            };
            Instructor Jordan = new Instructor {
                FirstName = "Jordan",
                LastName = "Castelloe",
                SlackHandle = "@JordC",
                CurrentCohort = CohortOne
            };
            Kim.AssignExercise(nutshell, Bobby);
            Josh.AssignExercise(nashville, Russ);
            Jordan.AssignExercise(boogers, Matt);
        }
    }
}
