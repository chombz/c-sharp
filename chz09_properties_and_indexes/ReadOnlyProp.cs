using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chz09_properties_and_indexes
{
    /// <summary>
    /// C# program to demonstrate read-only property 
    /// </summary>
    class ReadOnlyProp
    {
        private DateTime _currentTime = DateTime.Now;

        //Read only property
        public DateTime CurrentTime
        {
            get { return _currentTime; }
        }

        //Main method begins prograam execution
        static void Main(string[] args)
        {
            Console.WriteLine($"The current Time is {new ReadOnlyProp().CurrentTime}");
        }
    }
}
