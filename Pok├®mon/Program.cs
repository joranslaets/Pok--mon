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

internal sealed class Pikachu : Pokemon
{
    public Pikachu() : base(35, 55, "Electric") { }

    public override string Geluid() => "Pika pika!";
}

internal sealed class Charmander : Pokemon
{
    public Charmander() : base(39, 52, "Fire") { }

    public override string Geluid() => "Char!";
}
