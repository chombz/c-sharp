using System;
using System.Collections.Generic;


namespace chz13_GenericsAndIterations
{
    /// <summary>
    /// C# class that demonstrates how to create a Generic class with a class constraint. This 
    /// class will accept a type parameter of type person or its dirived classes.
    /// </summary>
    /// <typeparam name="T">Type parameter of the Person class or its derived classes</typeparam>
    public class GenericWithConstraint<T> where T : Person
    {
        public List<T> genericPerson = new List<T>();
    }

    class DemoGenericWithConstraint
    {
        static void Main(string[] args)
        {
            //Declare and instantiate generic person classes
            GenericWithConstraint<Student> adseStudents = new GenericWithConstraint<Student>();
            GenericWithConstraint<Staff> adseStaff = new GenericWithConstraint<Staff>();


            //prompt user for number of students in the class
            Console.WriteLine("How many students are in the class? ");
            int e, numofStudents = int.Parse(Console.ReadLine());

            try
            {
                //Read in the details of the students
                for (e = 0; e < numofStudents; e++)
                {
                    //Read in the details of individual students
                    Console.WriteLine($"Please enter the name of student {e + 1}");
                    string studName = Console.ReadLine();
                    Console.WriteLine($"Please enter {studName}\'s student Number -> ");
                    string studNo = Console.ReadLine();
                    Console.WriteLine($"Please enter {studName}\'s date of birth -> ");
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"Please enter {studName}\'s gender -> ");
                    char gender = char.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {studName}\'s course -> ");
                    string course = Console.ReadLine();
                    Console.WriteLine($"Please enter {studName}\'s current semester -> ");
                    uint currSem = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine($"Please enter {studName}\'s Nationality -> ");
                    string nationality = Console.ReadLine();

                    //Add the above details to the Student list
                    adseStudents.genericPerson.Add(
                     new Student(studName, dob, gender, nationality, studNo, course, currSem));
                }
                  
                //Display the student details
                foreach (Student student in adseStudents.genericPerson)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex.GetType().ToString().Replace("System.", "")}  occurred.");
            }




            ///
            //Assignment: Due wed 16th june 2022
            ///
            int c;
            int numofStaff = int.Parse(Console.ReadLine());

            //Read in the details of the staff members
            try
            {
                //Read in and display the details of at least 3 staff members
                for (c = 0; c < numofStaff; c++)
                {
                    Console.WriteLine($"Name of staff ->");
                     string staffname = Console.ReadLine();

                    Console.WriteLine($"Name of staff ID ->");
                    string staffId = Console.ReadLine();

                    Console.WriteLine($"Name of Staff Email ->");
                    string email = Console.ReadLine();
                }

                foreach (Staff staff in adseStaff.genericPerson)
                {
                    Console.WriteLine(staff.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex.GetType().ToString().Replace("System.", "")}  occurred.");
            }
        }

        
    }
}
