using System.Net.Http;
using System.Threading.Tasks;

namespace Pokedex.Services;

public class PokeApiService
{
    private readonly HttpClient _client = new HttpClient();
    public async Task<string> GetPokemon(string name) {
        string response = await _client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + name);
        return response;
    }
}
