using PokeApiNet;
using System.Text;

namespace Pokedex
{
    internal static class PokemonManager
    {
        private static PokeApiClient _pokeApiClient;
        private static List<Pokemon> _currentPage;

        internal static PokemonInfo SelectedPokemonInfo { get; private set; }

        static PokemonManager()
        {
            _pokeApiClient = new();
            _currentPage = new(6);
        }

        internal static async Task GetPage(int pageLimit, int offset)
        {
            if (_currentPage.Count != 0) _currentPage.Clear();

            for (var i = offset; i < offset + pageLimit; ++i)
            {
                var currentPokemon = await _pokeApiClient.GetResourceAsync<Pokemon>(i);
                _currentPage.Add(currentPokemon);
            }
        }

        internal static Pokemon GetPokemonFromPage(int id) => _currentPage[id];

        internal static async Task GetPokemonInfo(int id)
        {
            var pokemonSpecies = await _pokeApiClient.GetResourceAsync<PokemonSpecies>(GetPokemonFromPage(id).Id);

            SelectedPokemonInfo = new PokemonInfo
            {
                Name = _currentPage[id].Name.ToUpper(),
                ImageUrl = _currentPage[id].Sprites.Other.Home.FrontDefault,
                About = pokemonSpecies.FlavorTextEntries.Where(lang => lang.Language.Name == "en").First().FlavorText,
                HP = _currentPage[id].Stats.Where(stat => stat.Stat.Name == "hp").First().BaseStat,
                Attack = _currentPage[id].Stats.Where(stat => stat.Stat.Name == "attack").First().BaseStat,
                Defense = _currentPage[id].Stats.Where(stat => stat.Stat.Name == "defense").First().BaseStat
            };
        }

        internal static string GetBaseStats()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"HP: {SelectedPokemonInfo.HP}\n");
            stringBuilder.Append($"Attack: {SelectedPokemonInfo.Attack}\n");
            stringBuilder.Append($"Defense: {SelectedPokemonInfo.Defense}\n");

            return stringBuilder.ToString();
        }
    }
}
