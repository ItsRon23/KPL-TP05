// See https://aka.ms/new-console-template for more 

internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Aaron Joseph")
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}", X);
    }
}

