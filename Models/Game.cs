// Importing necessary libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Defining namespace
namespace TicTacToeFinal.Models
{
    // Defining class "Game"
    public class Game
    {
        // List of all possible winning combinations
        public List<WinningCombination> WinningCombinations = new List<WinningCombination>
        {
            new WinningCombination(1, 2, 3),
            new WinningCombination(4, 5, 6),
            new WinningCombination(7, 8, 9),
            new WinningCombination(1, 4, 7),
            new WinningCombination(2, 5, 8),
            new WinningCombination(3, 6, 9),
            new WinningCombination(1, 5, 9),
            new WinningCombination(3, 5, 7)
        };

        // Counter for number of times O wins
        public int OWinner { get; set; }

        // Counter for number of times X wins
        public int XWinner { get; set; }

        // List of all squares on the board
        public List<Square> Squares { get; protected set; }

        // Enum defining which player's turn it is next
        public MarkEnum NextTurn { get; set; }

        // Nullable enum to represent the winner
        public MarkEnum? Winner { get; set; }

        // Constructor method to initialize the game
        public Game()
        {
            ResetGame();
        }

        // Method to determine next player turn and check for a winner
        public void Next()
        {
            // Check each winning combination
            foreach (var winningCombination in WinningCombinations)
            {
                // If all three squares in a combination are marked by O, then O wins
                if (Squares[winningCombination.Square1 - 1].Mark == MarkEnum.O && Squares[winningCombination.Square2 - 1].Mark == MarkEnum.O && Squares[winningCombination.Square3 - 1].Mark == MarkEnum.O)
                {
                    Winner = MarkEnum.O;
                }
                // If all three squares in a combination are marked by X, then X wins
                else if (Squares[winningCombination.Square1 - 1].Mark == MarkEnum.X && Squares[winningCombination.Square2 - 1].Mark == MarkEnum.X && Squares[winningCombination.Square3 - 1].Mark == MarkEnum.X)
                {
                    Winner = MarkEnum.X;
                }

            }
            // If there is a winner
            if (Winner.HasValue)
            {
                // Increment the winner's counter
                if (Winner == MarkEnum.O)
                {
                    OWinner += 1;
                }
                if (Winner == MarkEnum.X)
                {
                    XWinner += 1;
                }

                // Set NextTurn to the winner's mark
                NextTurn = Winner.Value;
            }
            // If there is no winner
            else
            {
                // Set NextTurn to the other player's mark
                if (NextTurn == MarkEnum.O)
                {
                    NextTurn = MarkEnum.X;
                }
                else
                {
                    NextTurn = MarkEnum.O;
                }
            }
        }

        // Method to reset the game
        public void ResetGame()
        {
            // Initialize Squares to a new empty list
            Squares = new List<Square>();
            // Set NextTurn to the winner's mark, or X if there is no winner
            NextTurn = (Winner.HasValue ? Winner.Value : (NextTurn == MarkEnum.O ? MarkEnum.X : MarkEnum.O));
            Winner = null;

            for (var tt=1;tt<=9;tt++)
            {
                Squares.Add(new Square(tt));
            }
        }
    }
    }