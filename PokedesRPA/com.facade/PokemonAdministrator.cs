using PokedesRPA.com.automatitation;
using PokedesRPA.com.pokedex;
using System;
using System.Collections.Generic;
using System.Text;


namespace PokedesRPA.com.facade
{

    class PokemonAdministrator
    {
        private PokemonSearcher pkSearcher;
        private Pokedex pk;

        public PokemonAdministrator()
        {
            
        }

        public Pokedex pokedex()
        {
            return new Pokedex();
        }

        public PokemonSearcher pokemonSearcher()
        {
            return new PokemonSearcher();
        }


    }
}
