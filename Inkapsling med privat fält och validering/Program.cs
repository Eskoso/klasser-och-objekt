public class Konto
{
    private string _epost;
    public Konto()
    {
        _epost = "Ingen e-postadress angiven";
    }

    public string Epost
    {
        get { return _epost; }
        set
        {
            if (value.Contains("@"))
            {
                _epost = value;
            }
            else
            {
                _epost = "Ogiltig e-postadress";
            }
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Konto k1 = new Konto();
        k1.Epost = "test@domain.se";
        Console.WriteLine(k1.Epost);

        Konto k2 = new Konto();
        k2.Epost = "lisa@domain.se";
        Console.WriteLine(k2.Epost);

        Konto k3 = new Konto();
        k3.Epost = "kalle@domain.se";
        Console.WriteLine(k3.Epost);

        Konto k4 = new Konto();
        k4.Epost = "testdomain.se";
        Console.WriteLine(k4.Epost);
    }
}