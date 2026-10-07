public class Bok
{
    public string title = "";
    public string author = "";
}

internal class Program
{
    private static void Main(string[] args)
    {
        Bok bok = new Bok();

        bok.title = "The Great Gatsby";
        bok.author = "F. Scott Fitzgerald";

        Console.WriteLine(bok.title);
        Console.WriteLine(bok.author);
    }
}