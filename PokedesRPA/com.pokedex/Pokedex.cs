using PokedesRPA.com.models;
using System;
using System.Collections.Generic;
using System.Text;


namespace PokedesRPA.com.pokedex
{
    class Pokedex
    {
        private List<Pokemon> listPokemons = new List<Pokemon>();
    
  
        public Pokedex()
        {
            
        }

        public void getAll()
        {
            foreach(var pk in this.listPokemons)
            {
                Console.WriteLine("=================");
                Console.WriteLine("ID: " + pk.Id);
                Console.WriteLine("NAME: " + pk.Name);
                Console.WriteLine("TYPE_1: " + pk.Type1);
                Console.WriteLine("TYPE_2: " + pk.Type2);
                Console.WriteLine("GROUP_1: " + pk.Group1);
                Console.WriteLine("GROUP_2: " + pk.Group2);
                Console.WriteLine("IMAGE_PATH: " + pk.ImagePath);
                Console.WriteLine("=================");
            }
        }
        public void show(int id)
        {

        }

        public void register(Dictionary<string, object> pokemonData)
        {
            Pokemon pokemon = new Pokemon(pokemonData);
            listPokemons.Add(pokemon);
        }

        public void update(int id)
        {

        }

        public void delete(int id)
        {

        }
    }
}
