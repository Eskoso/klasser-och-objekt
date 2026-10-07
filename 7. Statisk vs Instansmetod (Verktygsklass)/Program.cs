public class TextVerktyg
{
    public static string RensaText(string text)
    {
        return text.Trim().ToLower();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        string text = "   Hej världen!   ";

        string rensadText = TextVerktyg.RensaText(text);

        Console.WriteLine($"Rensad text: '{rensadText}'");
    }
}