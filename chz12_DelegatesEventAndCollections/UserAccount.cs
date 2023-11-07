using System;

namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# class that will used to create UserAccount objects. These
    /// account objects will be used to simulate user authentication for social media, POS and
    /// other system that require authentication
    /// </summary>
    public class UserAccount
    {
        private static long initialID = 1324L;
        public long UserID { get; }
        public String Username { get; set; }
        public String Password { get; set; }

        public UserAccount(string username, string password)
        {
            this.UserID = initialID++;
            this.Username = username;
            this.Password = password;
        }

        public override string ToString()
        {
            return ($"User Account Details: " + 
                    $"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                    $"User ID: {this.UserID}" +
                    $"User Name: {this.Username}" +
                    $"User Pasword: {this.Password.Remove(1,this.Password.Length - 2).Insert(1,"^^^^^^^^^")}" +
                    $"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
