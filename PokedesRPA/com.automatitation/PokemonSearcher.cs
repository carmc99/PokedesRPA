using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Net;
using System.ComponentModel;
using System.Drawing;

namespace PokedesRPA.com.automatitation
{
    class PokemonSearcher
    {
        IWebDriver driver;
        WebClient webClient;
        public PokemonSearcher()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Size = new Size(1, 1);
            driver.Manage().Window.Position = new Point(-10000,0);
            webClient = new WebClient();
        }

        public bool validIfExist(string name)
        {
            driver.Navigate().GoToUrl(@"https://pokemon.fandom.com/es/" + name);
            if (driver.FindElement(By.ClassName("mw-headline")).Text.Contains("no se ha encontrado"))
            {
                return false;
            }
            return true;
        }
        public string searchImage(string name)
        {
            if (this.validIfExist(name))
            {
                IWebElement image = driver.FindElement(By.XPath("//img[@data-image-key='" + name + ".png']"));
                return image.GetAttribute("src");
            }
            return null;
        }

        public bool downloadImage(string url, string name)
        {
            try
            {
                webClient.DownloadFile(url, (@"..\..\..\images\" + name + ".png"));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Dictionary<string, object> searchPokemon(string name)
        {
            
            if (this.validIfExist(name))
            {
                Dictionary<string, object> pokemonData = new Dictionary<string, object>();
                pokemonData.Add("id", 25);
                pokemonData.Add("name", (driver.FindElement(By.Id("nombrepokemon"))).Text);
                pokemonData.Add("type1", "Tipo eléctrico");
                pokemonData.Add("type2", "");
                pokemonData.Add("group1", "Campo");
                pokemonData.Add("group2", "Hada");
                pokemonData.Add("imagePath", this.searchImage(name));
                return pokemonData;
            }
            return null;
        }

    }
}
