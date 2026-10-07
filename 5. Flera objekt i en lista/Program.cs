public class Produkt
{
    public string Namn { get; set; } = "";
    public decimal Pris { get; set; } = 0.0m;

    public Produkt(string namn, decimal pris)
    {
        Namn = namn;
        Pris = pris;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Produkt> produkter = new List<Produkt>();

        produkter.Add(new Produkt("Äpple", 5.99m));
        produkter.Add(new Produkt("Banan", 3.39m));
        produkter.Add(new Produkt("Apelsin", 4.25m));

        Console.WriteLine("Fin varukorg innehåller: ");
        foreach (var p in produkter)
        {
            Console.WriteLine($"- {p.Namn} {p.Pris} kr");
        }
    }
}