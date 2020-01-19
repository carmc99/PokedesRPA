using System;
using System.Collections.Generic;
using System.Text;

namespace PokedesRPA.com.models
{
    class Pokemon
    {
        private int id { set; get; }
        private string name { set; get; }
        private string type1 { set; get; }
        private string type2 { set; get; }
        private string nameJapane { set; get; }
        private string group1 { set; get; }
        private string group2 { set; get; }
        private string imagePath { set; get; }

        public Pokemon(Dictionary<string, object> pokemonData)
        {
            this.id = (int) pokemonData["id"];
            this.name = (string) pokemonData["name"];
            this.type1 = (string) pokemonData["type1"];
            this.type2 = (string) pokemonData["type2"];
            this.group1 = (string) pokemonData["group1"];
            this.group2 = (string) pokemonData["group2"];
            this.imagePath = (string) pokemonData["imagePath"];
        }
    }
}
