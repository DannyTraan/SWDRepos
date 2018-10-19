using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using RouletteGame.Interface;

namespace RouletteGame.Models
{
    public class StartGame : IStartGame
    {
        public ICommand Play { get; set; }

        public int RandomizeNumber(int numberOne = 1, int numberTwo = 36)
        {
            var random = new Random();

            return random.Next(numberOne, numberTwo);
        }

        public string RandomizeColor(int red, int black)
        {
            var random = new Random();
           
            return random.Next(red, black) == 0 ? "Red" : "Black";
        }
    }
}