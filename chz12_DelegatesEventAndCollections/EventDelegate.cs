using System;


namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# program to demonstrate how to work with delegates and events 
    /// </summary>
    /// 

    //Define the Delgate for event outside the class
    public delegate void MyEventHandler(string value);
    public class EventDelegate
    {
        //class method to handle the event of a user typing in a new string
        static void UserStringChanged(string newInputString)
        {
            Console.WriteLine($"The user has typed \"{newInputString}\".\n");
        }



        //main method begins program execution
        static void Main(string[] args)
        {
            //Declare and instantiate an EventPublisher object
            EventPublisher evtPub = new EventPublisher();
            //Assign the event publisher object to the UserStringChanged method
            evtPub.valueChanged += UserStringChanged;
            //String variable to hold the string/input from the user
            string userString;
            do
            {
                //Prompt the user for a string
                Console.WriteLine($"Please enter some text/string or type \"Exit\"" +
                    $" to end/quit the program -> ");
                userString = Console.ReadLine();
                //Display the string if it's not exit
                if (!userString.ToUpper().Equals("EXIT"))
                    evtPub.Val = userString;
            } while (!userString.ToLower().Equals("exit"));
            Console.WriteLine($"Goodbye!!!");
        }
    }





    /// <summary>
    /// Class to publish events
    /// </summary>
    internal class EventPublisher
    {
        private string theVal;
        //Declare the event
        public event MyEventHandler valueChanged;
        public string Val
        {
            set
            {
                //Set the private string to the value of the string passed in
                this.theVal = value;
                //When the value changes, fire/trigger the event
                this.valueChanged(theVal);
            }
        }
    }
}
