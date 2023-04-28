using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeFinal.Models
{
    public class WinningCombination
    {
        public int Square1 { get; } // The first square in the winning combination
        public int Square2 { get; } // The second square in the winning combination
        public int Square3 { get; } // The third square in the winning combination

        public WinningCombination(int square1, int square2, int square3)
        {
            Square1 = square1; // Set the first square
            Square2 = square2; // Set the second square
            Square3 = square3; // Set the third square
        }
    }
}