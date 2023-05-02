using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Henderson_Bobby
{
    abstract class Game
    {

        public string Esrb { get; set; }

        public string Title { get; set; }

        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }
        /// <summary>
        /// Prints the tilte and says it is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        public abstract string Describe();
    }
}
