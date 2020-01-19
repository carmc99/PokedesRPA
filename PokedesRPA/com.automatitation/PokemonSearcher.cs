using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace PokedesRPA.com.automatitation
{
    class PokemonSearcher
    {
        IWebDriver driver;

        public PokemonSearcher()
        {
            driver = new ChromeDriver(".");
        }
        public string searchImage()
        {
            return "";
        }

        public Dictionary<string, object> searchPokemon(string name)
        {
            driver.Navigate().GoToUrl("https://pokemon.fandom.com/es/wiki/Lista_de_Pokémon");
            Thread.Sleep(200);
            IWebElement principalNode = driver.FindElement(By.TagName("tbody"));
            IList<IWebElement> elements = principalNode.FindElements(By.TagName("tr"));
            foreach (IWebElement e in elements)
            {
                System.Console.WriteLine(e.Text);
            }

            Dictionary<string, object> pokemonData = new Dictionary<string, object>();

            return pokemonData;
        }

    }
}
