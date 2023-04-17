using System;

namespace Properties_OMalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a car variable
            Car car = new Car();

            // Assigns a make and a model value to car
            car.Make = "Ford";
            car.Model = "Mustang";

            // Prints the values of car's make and model
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");
            
            // Creates a car2 variable
            Car car2 = new Car();

            // Assigns a make and a model value to car2
            car2.Make = "Chevy";
            car2.Model = "Camero";

            // Prints the values of car2's make and model
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");
        }
    }
}
