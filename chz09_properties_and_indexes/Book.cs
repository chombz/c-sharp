using System;

namespace chz09_properties_and_indexes
{
    /// <summary>
    /// C# class that will be used to create Book objects
    /// </summary>
    public class Book
    {
        //properties
        public uint BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }


        public Book()
        {
            this.BookID = 0;
            this.Title = "";
            this.Author = "";
            this.Price = 0.0f;
        }

        public Book(uint bookID, string title, string author, float price)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }



        public void DisplayDetails()
        {
            Console.WriteLine($"Book Details" +
                              $"\n---------------------------" +
                              $"\nBook ID: {this.BookID}" +
                              $"\nBook Title: {this.Title}" +
                              $"\nBook Author: {this.Author}" +
                              $"\nBook Price: {this.Price}" +
                              $"\n--------------------------------------" );
        }


        public override string ToString()
        {
            return ($"Book Details" +
                    $"\n---------------------------" +
                    $"\nBook ID: {this.BookID}" +
                    $"\nBook Title: {this.Title}" +
                    $"\nBook Author: {this.Author}" +
                    $"\nBook Price: {this.Price}" +
                    $"\n--------------------------------------");
        }
    }
}
