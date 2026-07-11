using Pokedex.Services;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

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
        Greeting = await new PokeApiService().GetPokemon("pikachu");
    }
}
