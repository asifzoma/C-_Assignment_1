using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Car object with dummy data
        Car myCar = new Car("Toyota", "Corolla", "ABC1234", 2018, 12000.00);

        // Print car's details using ToString
        Console.WriteLine(myCar.ToString());

        // Optionally, demonstrate the other methods
        Console.WriteLine("Current Value: " + myCar.GetCurrentValue());
        Console.WriteLine("Year: " + myCar.GetYear());
    }
} 