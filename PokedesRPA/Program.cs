using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PokedesRPA.com.pokedex;
using PokedesRPA.com.automatitation;
using PokedesRPA.com.facade;

// Aplicacion para la automatizacion de la busqueda de pokemon's
namespace PokedesRPA
{
    class Program
    {
        static void Main(string[] args)
        {

            PokemonAdministrator pkAdmin = new PokemonAdministrator();
            string pokemonToSearch = pkAdmin.pokedex().open();
            if(pkAdmin.pokemonSearcher().downloadImage(pkAdmin.pokemonSearcher().searchImage(pokemonToSearch), pokemonToSearch))
            {
                Console.WriteLine("Descarga exitosa");
            }
            else
            {
                Console.WriteLine("Ocurrio un problema al descargar la imagen");
            }

        }
    }
}
