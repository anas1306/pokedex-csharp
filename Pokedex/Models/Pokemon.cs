namespace Pokedex.Models;
using System.Collections.Generic;

public class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<TypeInfo>? Types { get; set; }
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
    public string? name { get; set; }
    public string? url { get; set; }
}

public class PokemonType
{
    public int slot { get; set; }
    public TypeInfo? type { get; set; }
}
