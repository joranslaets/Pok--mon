using System;

Console.WriteLine("Het gevecht begint!");

Pikachu pika = new Pikachu();
Charmander charmy = new Charmander();

// Pikachu valt aan!
pika.ValAan(charmy);

// Status check
Console.WriteLine($"Charmander heeft nog {charmy.Levens} HP over.");

internal abstract class Pokemon
{
    // Veranderd naar 'private set' zodat we de HP kunnen verlagen tijdens een aanval
    public int Levens { get; protected set; } 
    public int AanvalsPunten { get; init; }
    public string Type { get; init; }

    protected Pokemon(int levens, int aanvalsPunten, string type)
    {
        Levens = levens;
        AanvalsPunten = aanvalsPunten;
        Type = type;
    }

    public abstract string Geluid();

    // De aanvalsmethode
    public void ValAan(Pokemon doelwit)
    {
        Console.WriteLine($"{this.GetType().Name} valt {doelwit.GetType().Name} aan!");
        Console.WriteLine(this.Geluid());
        
        doelwit.OntvangSchade(this.AanvalsPunten);
    }

    public void OntvangSchade(int schade)
    {
        Levens -= schade;
        if (Levens < 0) Levens = 0;
        Console.WriteLine($"{this.GetType().Name} verliest {schade} HP!");
    }
}

internal sealed class Pikachu : Pokemon
{
    public Pikachu() : base(35, 55, "Electric") { }

    public override string Geluid() => "Pika pika! ⚡";
}

internal sealed class Charmander : Pokemon
{
    public Charmander() : base(39, 52, "Fire") { }

    public override string Geluid() => "Char! 🔥";
}