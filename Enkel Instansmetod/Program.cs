public class Dog
{
    public string Name { get; set; } = "";
    public void Bark()
    {
        Console.WriteLine($"{Name} säger voff voff!");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "Fido";

        dog.Bark();
    }
}