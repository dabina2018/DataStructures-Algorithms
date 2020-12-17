using System;

namespace SimpleClass
{
    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Make = "mercedes";
            myCar.Model = "AMG G63";
            myCar.Year = 2020;
            myCar.Color = "White";

            
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
        }

        class Car
        {
            //creates new Class, Car datatype
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public decimal DetermineMarketValue()
            {
                decimal carValue;
                if (Year > 1990)
                {
                    carValue = 10000;
                }
                else
                    carValue = 30000;
                return carValue;
            }
        }

        

        class Truck
        {
            //propfull
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }

        }
    }
}
