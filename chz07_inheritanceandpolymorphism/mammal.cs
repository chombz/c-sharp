using System;

namespace chz07_inheritanceandpolymorphism
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Mammal:Animal
    {
        //instance field
        protected string habitat;

        //instance methods
        public abstract void Eat(string diet);

        public void MultiplyMammal(string name)
        {
            Console.WriteLine($"{name} gives birth");
        }
    }
}
