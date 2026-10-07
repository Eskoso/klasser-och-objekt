public class Medlem
{
    public static int AntalMedlemmar = 0;
    public Medlem()
    {
        AntalMedlemmar++;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Medlem> medlemmar = new List<Medlem>
        {
            new Medlem(),
            new Medlem(),
            new Medlem(),
            new Medlem()
        };
        Console.WriteLine($"Antal medlemmar: {Medlem.AntalMedlemmar}");
    }
}