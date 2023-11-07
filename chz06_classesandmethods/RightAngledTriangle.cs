using System;

namespace chz06_classesandmethods
{
    /// <summary>
    /// C# class that will be used to create a  RightAngled triangle objects.
    /// </summary>
    class RightAngledTriangle
    {
        //Instance variables/fields
        private byte height;
        private byte @base;
        private byte hypotenuse;

        //Constructors
        public RightAngledTriangle() { }
        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)Math.Sqrt(Math.Pow(height, 2) + Math.Pow(@base, 2));
        }

        public int CalcArea()
        {
            return (int)(0.5 * @base * height);
        }
        public int CalcPerimeter()
        {
            return this.@base + this.height + this.hypotenuse;
        }

        public byte GetHypotenuse()
        {
            return this.hypotenuse;
        }
    }
}
