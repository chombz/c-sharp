using System;

namespace chz09_properties_and_indexes
{
    /// <summary>
    /// C# class that will be used to create Person objects using 
    /// auto- implemented properties
    /// </summary>
    public class SimplerPerson
    {
        //Object properties
        public string Names { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }

        public SimplerPerson()
        {
            this.Names = "";
            this.BirthDate = DateTime.Now;
            this.Gender = 'M';
            this.Nationality = "Kenyan";
        }

        public SimplerPerson(string names, DateTime dob, 
                             char gender, string nationality)
        {
            this.Names = names;
            this.BirthDate = dob;
            this.Gender = gender;
            this.Nationality = nationality;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Person\'s Details" +
                              $"\n----------------------------" +
                              $"\nName: {this.Names}" +
                              $"\nDate of birth:{this.BirthDate: d}" +
                              $"\nGender : {((this.Gender == 'M'|| this.Gender == 'm')?"Male":"Female")}" +
                              $"\nNationality: {this.Nationality}" +
                              $"\n---------------------------------------");
        }

        //override the ToString method for same output as above
        public override string ToString()
        {
            return  $"Person\'s Details" +
                    $"\n----------------------------" +
                    $"\nName: {this.Names}" +
                    $"\nDate of birth:{this.BirthDate: d}" +
                    $"\nGender : {((this.Gender == 'M' || this.Gender == 'm') ? "Male" : "Female")}" +
                    $"\nNationality: {this.Nationality}" +
                    $"\n---------------------------------------";
        }
    }




    public class DemoSimplePerson
    {
        //Main method begins with a program execution
        static void Main(string[] args)
        {
            //Declare and instantiate a SimplePerson object
            SimplerPerson myFriend;
            //Prompt the user for the SimplerPerson's details
            Console.WriteLine($"Please ender your Friend\'s name -> ");
            string names = Console.ReadLine();

            Console.WriteLine($"Please enter your Friend\'s date of birth -> ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Please enter your Friend\'s gender -> ");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter ypur Friend\'s nationality -> ");
            string nationality = Console.ReadLine();

            //Insatntiate the SimplePerson object
            myFriend = new SimplerPerson(names, dob, gender, nationality);

            //Display the Friends Details
            Console.WriteLine(myFriend.ToString());
        } 
    }
}
