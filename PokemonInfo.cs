namespace Pokedex
{
    internal record PokemonInfo
    {
        internal string Name { get; set; }
        internal string ImageUrl { get; set; }
        internal string About { get; set; }
        internal int HP { get; set; }
        internal int Attack { get; set; }
        internal int Defense { get; set; }
    }
}
