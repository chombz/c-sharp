using System;

namespace chz13_GenericsAndIterations
{
    /// <summary>
    /// C# program that will be used to create Person object using
    /// and/or inherited to create specilised
    /// </summary>
    public class Person
    {
        //Object properties
        public string Names { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }

        /// <summary>
        /// Create a Peron object with the details passed in as parameters
        /// </summary>
        /// <param name="names"></param>//String value
        /// <param name="dob"></param>DateTime calue
        /// <param name="gender"></param>char value
        /// <param name="nationality"></param>String value

        public Person(string names, DateTime dob, char gender, string nationality)
        {
            this.Names = names;
            this.BirthDate = dob;
            this.Gender = gender;
            this.Nationality = nationality;
        }

        //override the ToString method for same output as above
        public override string ToString()
        {
            return $"Person\'s Details" +
                    $"\n----------------------------------------" +
                    $"\nName: {this.Names}" +
                    $"\nDate of birth:{this.BirthDate: d}" +
                    $"\nGender : {((this.Gender == 'M' || this.Gender == 'm') ? "Male" : "Female")}" +
                    $"\nNationality: {this.Nationality}" +
                    $"\n----------------------------------------\n";
        }
    }
}
