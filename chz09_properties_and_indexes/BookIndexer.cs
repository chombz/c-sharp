using System;

namespace chz09_properties_and_indexes
{
    /// <summary>
    /// C# program demonstrating the use of indexers to access object instances
    /// </summary>
    public class BookIndexer
    {
        //Create an array of Programming Books
        private Book[] programmingBooks = new Book[]
        {
            new Book(578,"C# How to Program","Deitel & Deitel",54.55f),
            new Book(579,"C# Notes for Professionals","Et al",0.0f),
            new Book(580,"Java The Complete Reference","Oracle Inc.",89.99f),
            new Book(581,"Python Programming","Python Author",25.59f)
        };

        //Set up the Book Index
        public Book this[uint bookID]
        {
            get { return programmingBooks[bookID]; }
        }

        //Main method begins program execution
        static void Main(string[] args)
        {
            foreach (Book book in new BookIndexer().programmingBooks)
            {
                book.DisplayDetails();
            }
        }
    }
}
