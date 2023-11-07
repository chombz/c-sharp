using System;

namespace chz09_properties_and_indexes
{
    /// <summary>
    /// C# program to demonstrate write-only property 
    /// </summary>
    class WriteOnlyProp
    {
        private string _password;

        public string Password
        {
            set
            {
                _password = (value == "") ? "" : value;
            }
        }
        public string UserName { get; set; }


        //Method to display user's details
        public void DisplayUserDetails()
        {
            Console.WriteLine($"UserName: {this.UserName}" +
                              $"\nPassword: {this._password}");
        }

        //Main method begins with a program excution
        static void Main(string[] args)
        {
            //Declare and instantiate a SimplePerson object
            WriteOnlyProp user1 = new WriteOnlyProp();
            //Prompt the user for the SimplerPerson's details
            Console.WriteLine($"Please enter your your\'s name -> ");
            user1.UserName = Console.ReadLine();

            Console.WriteLine($"Please enter your your\'s password -> ");
            user1.Password = Console.ReadLine();


            //Display user's credentials
            user1.DisplayUserDetails();
        }
    }
}
