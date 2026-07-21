using Pokedex.Services;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Pokedex.Models;

namespace Pokedex.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial Pokemon? SelectedPokemon { get; set; }
    public MainViewModel()
    {
        _ = LoadPokemon();
    }

    private async Task LoadPokemon() 
    {
        Pokemon? pokemon = await new PokeApiService().GetPokemon("pikachu");
        SelectedPokemon = pokemon;
    }
}
