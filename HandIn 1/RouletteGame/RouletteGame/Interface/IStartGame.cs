using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame.Interface
{
    public interface IStartGame
    {
        void Play();
        int RandomizeNumber { get; set; }
        string RandomizeColor { get; set; }
    }
}