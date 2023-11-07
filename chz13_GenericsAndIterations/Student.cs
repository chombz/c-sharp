using System;

namespace chz13_GenericsAndIterations
{
    /// <summary>
    /// class that will be used to create Student objects.
    /// </summary>
    public class Student : Person
    {
        //Properties unique to Student class
        public string StudentNo { get; set; }
        public string Course { get; set; }
        public uint CurrentSem { get; set; }

        public Student(string names, DateTime dob, char gender, string nationality,
                     string StudentNo, string Course, uint CurrentSem)
                    : base(names, dob, gender, nationality)
        {
            this.StudentNo = StudentNo;
            this.Course = Course;
            this.CurrentSem = CurrentSem;
        }

        //override the ToString method for same output as above
        public override string ToString()
        {
            return $"Person\'s Details" +
                    $"\n---------------------------------------" +
                    $"\nName: {this.Names}" +
                    $"\nStaff ID: {this.StudentNo}" +
                    $"\nDate of birth:{this.BirthDate: d}" +
                    $"\nGender : {((this.Gender == 'M' || this.Gender == 'm') ? "Male" : "Female")}" +
                    $"\nEmployee Date: {this.Course}" +
                    $"\nDesignation: {this.CurrentSem}" +
                    $"\nNationality: {this.Nationality}" +
                    $"\n---------------------------------------\n";
        }
    }
}
