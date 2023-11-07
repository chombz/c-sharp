namespace chz06_classesandmethods
{
    /// <summary>
    /// C# class used to create Rectangle objects
    /// </summary>
   public class Rect
    {
        //Variables
        private int length;
        //Variables
        private int width;

        //Constructors
        public Rect() { }
        public Rect(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int getLength()
        {
            return length;
        }

        /**
         * @param length the length to set
         */
        public void setLength(int length)
        {
            this.length = length;
        }

        /**
         * @return the width
         */
        public int getWidth()
        {
            return width;
        }
        /**
     * @param width the width to set
     */
        public void setWidth(int width)
        {
            this.width = width;
        }

        public int calcArea()
        {
            return this.width * this.length;
        }

        public int calcPerimeter()
        {
            return 2 * (this.width + this.length);
        }

        public void displayDimensions()
        {
            System.Console.WriteLine($"\nRectangle\'s Dimensions"
                             + "\n--------------------------"
                             + $"\nWidth: {this.getWidth():00} cm"
                             + $"\nLength: {this.getLength():00} cm"
                             + $"\nArea: {this.calcArea():00} cm."
                             + $"\nPerimeter:{this.calcPerimeter():00} cm"
                             + "\n--------------------\n");
        }
    }
}