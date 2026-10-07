public class User
{
    public string Username { get; set; } = "";
    public string Epost { get; set; } = "";
}

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User();
        user.Username = "JohnDoe67";
        user.Epost = "john.doe@example.com";
        Console.WriteLine($"Användarnamn: {user.Username}");
        Console.WriteLine($"E-post: {user.Epost}");
    }
}
