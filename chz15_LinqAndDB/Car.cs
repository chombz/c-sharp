namespace chz15_LinqAndDB
{
    /// <summary>
    /// class that will be used to create car objects
    /// </summary>
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public uint UnitsSold { get; set; }
        public float Price { get; set; }

        public Car()
        {
        }

        public Car(string make, string model, uint unitsSold)
        {
            this.Make = make;
            this.Model = model;
            this.UnitsSold = unitsSold;
        }

        public Car(string make, string model, uint unitsSold, float price)
        {
            this.Make = make;
            this.Model = model;
            this.UnitsSold = unitsSold;
            this.Price = price;
        }

        //override the Tostring to display the car details
        public override string ToString()
        {
            return $"Car Details \n" +
                 $"-------------------------------" +
                 $"\nCar Make: {this.Make}" +
                 $"\nCar Model: {this.Model}" +
                 $"\nUnits Sold: {this.UnitsSold}" +
                 $"\n------------------------------";
        }
    }
}
