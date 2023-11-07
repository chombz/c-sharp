using System;

namespace sess06_classesandmethods
{
    /// <summary>
    /// C# class that will be used to create Persom objects and later inherited  from to create specialised classes
    /// </summary>
    internal class SimplePerson
    {
        //Protected class field
        protected string names;
        protected DateTime birthdate;
        protected string gender;
        protected string nationality;

        //Write code for the getters and setters for the above fields
        public string Names { get => names; set => names = value; }
        public DateTime BirthDate { get => birthdate; set => birthdate = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Nationality { get => nationality; set => nationality = value; }


        public SimplePerson()
        {
            this.Names = "";
            this.BirthDate = DateTime.Now;
            this.Gender = 'M';
            this.Nationality = "Kenyan";
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Person\'s Details" +
                              $"\n----------------------------" +
                              $"\nName: {this.Names}" +
                              $"\nDate of birth:{this.BirthDate: d}" +
                              $"\nGender : {((this.Gender == 'M' || this.Gender == 'm') ? "Male" : "Female")}" +
                              $"\nNationality: {this.Nationality}" +
                              $"\n---------------------------------------");
        }

        //override the ToString method for same output as above
        public override string ToString()
        {
            return $"Person\'s Details" +
                    $"\n----------------------------" +
                    $"\nName: {this.Names}" +
                    $"\nDate of birth:{this.BirthDate: d}" +
                    $"\nGender : {((this.Gender == 'M' || this.Gender == 'm') ? "Male" : "Female")}" +
                    $"\nNationality: {this.Nationality}" +
                    $"\n---------------------------------------";
        }

    }
}
