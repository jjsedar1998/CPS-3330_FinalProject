using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeFinal.Models
{
    public class Square
    {
        public int Number { get; }  // A read-only property to store the number of the square.

        public MarkEnum? Mark { get; set; }  // A property to store the mark of the square. It can be null if the square is not marked yet.

        public Square(int number)  // A constructor that initializes the `Number` property with the given number.
        {
            Number = number;
        }
    }
}