using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RouletteGame.Interface;

namespace RouletteGame.Models
{
    public class ChooseColor : IChooseColor
    {
        public string SpecificColor(string c)
        {
            var Color_Black = 0;
            var Color_Red = 1;
            //var Color_Green = 2;

            //If user chooses red, select "1" and return to "spinwheel"

            return 0.ToString();
        }
    }
}