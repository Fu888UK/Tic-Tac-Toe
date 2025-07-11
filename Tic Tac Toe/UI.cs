using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public static class UI_Method
    {
        public static void DisplayWelcomeMessage() 
        {
            Console.WriteLine("Hello, welcome to the world of TIC TAC TOE");
            Console.WriteLine("This a game where you take turns against the computer using a symbol X or O to fill in a 3x3 grid");
            Console.WriteLine("The wwinner of the game is the first one to get 3 symbols in a row");
            Console.WriteLine("Select the symbol you wish to play with, press 1 for X or 2 for O");

            string userSelection = Console.ReadLine();

            Console.WriteLine($"You have chosen to play with {userSelection} ");

        }
        

    }
}
