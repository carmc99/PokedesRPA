using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PokedesRPA.com.pokedex;
using PokedesRPA.com.automatitation;

// Aplicacion para la automatizacion de la busqueda de pokemon's
namespace PokedesRPA
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, object> pokemonData = new Dictionary<string, object>();
            pokemonData.Add("id", 25);
            pokemonData.Add("name", "Pikachu");
            pokemonData.Add("type1", "Tipo eléctrico");
            pokemonData.Add("type2", "");
            pokemonData.Add("group1", "Campo");
            pokemonData.Add("group2", "Hada");
            pokemonData.Add("imagePath", "");
            Pokedex pk = new Pokedex();
            pk.register(pokemonData);

            //pk.getAll();

            PokemonSearcher pkSearcher = new PokemonSearcher();
            pkSearcher.searchPokemon("pikachu");
           

        }
    }
}
