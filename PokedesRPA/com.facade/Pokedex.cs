using PokedesRPA.com.models;
using System;
using System.Collections.Generic;
using System.Text;


namespace PokedesRPA.com.facade
{
    class Pokedex
    {
        private List<Pokemon> listPokemons = new List<Pokemon>();
    
  
        public Pokedex()
        {
            
        }

        public void getAll()
        {
            foreach(object pk in this.listPokemons)
            {
                Console.WriteLine(pk);
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
