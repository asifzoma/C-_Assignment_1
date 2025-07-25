public class Car
{
    // Fields to store car information
    private string make;
    private string model;
    private string registration;
    private int year;
    private double currentValue;

    // Constructor to initialise all fields
    public Car(string make, string model, string registration, int year, double currentValue)
    {
        this.make = make;
        this.model = model;
        this.registration = registration;
        this.year = year;
        this.currentValue = currentValue;
    }

    // Method to return the current value of the car
    public double GetCurrentValue()
    {
        return currentValue;
    }

    // Method to return the year of the car
    public int GetYear()
    {
        return year;
    }

    // Override ToString to return full information about the car
    public override string ToString()
    {
        return $"Make: {make}, Model: {model}, Registration: {registration}, Year: {year}, Current Value: {currentValue:C}";
    }
} 