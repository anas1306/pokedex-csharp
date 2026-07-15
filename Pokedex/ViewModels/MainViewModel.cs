using Pokedex.Services;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Pokedex.Models;

namespace Pokedex.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Welcome to Pokedex!";
    public MainViewModel()
    {
        _ = LoadPokemon();
    }

    private async Task LoadPokemon() 
    {
        Pokemon? pokemon = await new PokeApiService().GetPokemon("pikachu");
        Greeting = pokemon?.Name ?? "Name not found.";
    }
}
