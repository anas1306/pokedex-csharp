using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Services;

public class PokeApiService
{
    private readonly HttpClient _client = new HttpClient();
    public async Task<Pokemon?> GetPokemon(string name) {
        string response = await _client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + name);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        Pokemon? pokemon = JsonSerializer.Deserialize<Pokemon>(response, options);
        return pokemon;
    }
}
