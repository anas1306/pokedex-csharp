using Pokedex.Services;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Pokedex.Models;
using Avalonia.Media.Imaging;
using System.Net.Http;
using System.IO;

namespace Pokedex.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial Pokemon? SelectedPokemon { get; set; }
    [ObservableProperty]
    public partial Bitmap? SpriteImage { get; set; }
    public MainViewModel()
    {
        _ = LoadPokemon();
    }

    private async Task LoadPokemon() 
    {
        Pokemon? pokemon = await new PokeApiService().GetPokemon("pikachu");
        SelectedPokemon = pokemon;
        if (pokemon?.Sprites?.front_default != null) {
            byte[] imageBytes = await new HttpClient().GetByteArrayAsync(pokemon.Sprites.front_default);
            using var stream = new MemoryStream(imageBytes);
            SpriteImage = new Bitmap(stream);
        }   
    }
}
