public class Car
{
    public bool broken = true;
}

public class Mechanic
{
    public void Repair(Car car)
    {
        car.broken = false;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        Mechanic mechanic = new Mechanic();
        Console.WriteLine($"Is the car broken? {car.broken}");
        mechanic.Repair(car);
        Console.WriteLine($"Is the car broken? {car.broken}");
    }
}