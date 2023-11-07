using System;
using System.Collections;
using System.Collections.Generic;

namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# program that demonstrates how to work with the Sorted List class.
    /// </summary>
    public class SortedAccountList
    {
        static void Main(string[] args)
        {
            SortedList accountDetails = new SortedList();
            accountDetails.Add(22, new UserAccount("Mark", "abcD5441#"));
            accountDetails.Add(41, new UserAccount("Ian", "Care@123!"));
            accountDetails.Add(10, new UserAccount("James56", "Password32&"));
            accountDetails.Add(8, new UserAccount("Nanchos29", "Secret127*3"));
            accountDetails.Add(17, new UserAccount("Light45", "Discreet_y1"));
            accountDetails.Add(4, new UserAccount("Tesfai48", "Hidden@123"));
            accountDetails.Add(30, new UserAccount("Kyalo41", "Mustard_34#"));
            accountDetails.Add(12, new UserAccount("Chandni89", "Ihaven01d3@"));

            //Display the account details keys
            Console.WriteLine($"Keys in the accountDetails collection area: ");
            foreach (int key in accountDetails.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
