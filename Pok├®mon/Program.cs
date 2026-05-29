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

    public string VuurAanval(Pokemon target)
    {
        if (target == null)
        {
            return "Geen doelwit om aan te vallen.";
        }

        var schade = AanvalsPunten;
        var nieuwLevens = Math.Max(0, target.Levens - schade);
        return $"Charmander valt {target.Type}-pokemon aan voor {schade} schade. Levens van doelwit: {target.Levens} -> {nieuwLevens}.";
    }
}

