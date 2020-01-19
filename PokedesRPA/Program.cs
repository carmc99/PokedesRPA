using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PokedesRPA.com.facade;


// Aplicacion para la automatizacion de la busqueda de pokemon's
namespace PokedesRPA
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, object> pokemonData = new Dictionary<string, object>();
            pokemonData.Add("id", 1);
            pokemonData.Add("name", "Pikachu");
            pokemonData.Add("type1", "");
            pokemonData.Add("type2", "");
            pokemonData.Add("group1", "");
            pokemonData.Add("group2", "");
            pokemonData.Add("imagePath", "");
            Pokedex pk = new Pokedex();
            pk.register(pokemonData);

            pk.getAll();
           

        }
    }
}
