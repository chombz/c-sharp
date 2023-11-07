using System;

namespace chz11_exception
{
    /// <summary>
    /// C# program to demonstrate ArrrayMissmatchException
    /// </summary>
    class ArrrayMissmatchException
    {
        //Main method begins program excution
        static void Main(string[] args)
        {
            //Declare and initalise an array of student names
            string[] studentNames = {"Edwin", "Frankline", "Micheal", "Veronica", "Farhiya"};

            //Declare and initalise an array of student ids
            uint[] studentIDs = {1001, 1002, 1003, 1004, 1005, 1006};

            //Declare and initalise an array of tution fees
            double[] tutionFees = {5000.5, 4500.5, 5500.45, 4200.3, 3450.5, 5720.55};

            //Declare and initalise float array of tution fees
            float[] cautionFee = new float[6];

            try
            {
                //Set the caution amount equal to the semester's fee
                for (int e = 0; e < tutionFees.Length; e++)
                {
                    tutionFees.CopyTo(cautionFee, e);//will cause an exeeception
                }
            }
            catch (ArrayTypeMismatchException atme)
            {
                Console.WriteLine($"Message: {atme.Message}" +
                                  $"\nError: {atme}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The exception " +
                                  $"{ex.GetType().ToString()}" +
                                  $" occured!");
            }
        }
    }
}
