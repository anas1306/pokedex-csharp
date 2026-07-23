namespace Pokedex.Models;
using System.Collections.Generic;

public class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<PokemonType>? Types { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public Sprites? Sprites { get; set; }
}

public class Sprites
{
    public string? front_default { get; set; }
}

public class TypeInfo
{
    public string? Name { get; set; }
    public string? Url { get; set; }
}

public class PokemonType
{
    public int Slot { get; set; }
    public TypeInfo? Type { get; set; }
}
