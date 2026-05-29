Console.WriteLine("Hello, World!");
internal abstract class Pokemon
{
    public int Levens { get; init; }
    public int AanvalsPunten { get; init; }
    public string Type { get; init; }

    protected Pokemon(int levens, int aanvalsPunten, string type)
    {
        Levens = levens;
        AanvalsPunten = aanvalsPunten;
        Type = type;
    }

    public abstract string Geluid();
}
