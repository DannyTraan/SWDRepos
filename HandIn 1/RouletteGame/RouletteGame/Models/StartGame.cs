using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RouletteGame.Interface;

namespace RouletteGame.Models
{
    public class StartGame : IStartGame
    {
        public void Play()
        {
            throw new NotImplementedException();
        }

        public int RandomizeNumber { get; set; }
        public string RandomizeColor { get; set; }
    }
}