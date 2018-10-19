using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RouletteGame.Interface
{
    public interface IStartGame
    {
        ICommand Play { get; set; }
        int RandomizeNumber(int numberOne, int numberTwo);
        string RandomizeColor(int red, int black);
    }
}