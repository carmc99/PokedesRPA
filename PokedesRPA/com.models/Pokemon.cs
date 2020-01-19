using System;
using System.Collections.Generic;
using System.Text;

namespace PokedesRPA.com.models
{
    class Pokemon
    {
        private int id;
        private string name;
        private string type1;
        private string type2;
        private string nameJapane;
        private string group1;
        private string group2;
        private string imagePath;

        public Pokemon(Dictionary<string, object> pokemonData)
        {
            this.id = (int) pokemonData["id"];
            this.name = (string) pokemonData["name"];
            this.type1 = (string) pokemonData["type1"];
            this.type2 = (string) pokemonData["type2"];
            this.group1 = (string)pokemonData["group1"];
            this.group2 = (string) pokemonData["group2"];
            this.imagePath = (string) pokemonData["imagePath"];
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Type1
        {
            get { return type1; }
            set { type1 = value; }
        }
        public string Type2
        {
            get { return type2; }
            set { type2 = value; }
        }
        public string Group1
        {
            get { return group1; }
            set { group1 = value; }
        }
        public string Group2
        {
            get { return group2; }
            set { group2 = value; }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
    }
}
