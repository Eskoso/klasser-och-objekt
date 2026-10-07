public class Kurs
{
    public string Kursnamn { get; set; }
    public string Kurskod { get; set; }
    public Kurs(string kursnamn, int kurskod)
    {
        Kursnamn = kursnamn;
        Kurskod = kurskod.ToString();
    }

    public Kurs(string kursnamn)
    {
        Kursnamn = kursnamn;
        Kurskod = "TBD";
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Kurs kurs1 = new Kurs("Matematik", 101);
        Kurs kurs2 = new Kurs("Fysik");
        Console.WriteLine($"Kursnamn: {kurs1.Kursnamn}, Kurskod: {kurs1.Kurskod}");
        Console.WriteLine($"Kursnamn: {kurs2.Kursnamn}, Kurskod: {kurs2.Kurskod}");
    }
}