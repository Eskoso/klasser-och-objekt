public class Car                    
{
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla");
        Car car2 = new Car("Honda", "Civic");
        Console.WriteLine($"Märke: {car.Brand}");
        Console.WriteLine($"Modell: {car.Model}");
        Console.WriteLine($"Märke: {car2.Brand}");
        Console.WriteLine($"Modell: {car2.Model}");
    }
}

