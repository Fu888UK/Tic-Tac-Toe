using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tic_Tac_Toe
{
    public static class UI_Method
    {
        public static void DisplayWelcomeMessage() 
        {           
            Console.WriteLine("Hello, welcome to the world of TIC TAC TOE");
            Console.WriteLine("This a game where you take turns against the computer using a symbol X or O to fill in a 3x3 grid");
            Console.WriteLine("The winner of the game is the first one to get 3 symbols in a row");
            //Console.WriteLine("Select the symbol you wish to play with, press 1 for X or 2 for O");
            
        }
        public static void DisplayGrid(string[,]grid) 
        {

            //for (int i = 0; i < Constants.ROWS; i++)      //fill grid with BLANK
            //{
            //    for (int j = 0; j < Constants.COLS; j++)
            //    {                    
            //        grid[i, j] = Constants.BLANK.ToString();                    
            //    }
            //}
            //Console.WriteLine("\nGrid for Tic Tac Toe:");

            for (int i = 0; i < Constants.ROWS; i++)        //display grid
            {
                for (int j = 0; j < Constants.COLS; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < Constants.ROWS; i++)                                //outer loop i goes through each row 
            {
                for (int j = 0; j < Constants.COLS; j++)                            // inner loop j goes through eacj col 
                {
                    grid[i, j] = "_";                                           //checks if i and j are even 
                }
            }

            Console.Write("+");

            for (int j = 0; j < Constants.COLS; j++)              //top border 
            {
                Console.Write("-+");                                 
            }
            Console.WriteLine("");

            for (int i = 0; i < Constants.ROWS; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Constants.COLS; j++)
                {
                    Console.Write(grid[i, j] + "|");    //replaced space with|
                }
                Console.WriteLine("");

            }

            Console.Write("+");
            for (int j = 0; j < Constants.COLS; j++)  //bottom border 
            {
                Console.Write("-+");       //added a +
            }
            Console.WriteLine("");




        }
        public static string AskUserInput()
        {
            Console.WriteLine("Select the symbol you wish to play with, press 1 for X or 2 for O");
            //string playerSelection = Console.ReadLine();
            //Console.WriteLine($"You have chosen {playerSelection}");
            return Console.ReadLine();
                                                                            //?????? why asking for input twice 
            
        }
        public static string GetPlayerSymbol()     //populating
        {
            while (true) 
            {
                string selection = AskUserInput();
                if (selection == "1")
                {
                    Console.WriteLine("You chosen the symbol O");
                    return Constants.SYMBOL1.ToString();
                }
                else if (selection == "2")
                {
                    Console.WriteLine("You chosen the symbol X");
                    return Constants.SYMBOL2.ToString();

                }
                else
                {
                    Console.WriteLine("Invalid selection, please seleect 1 for X or 2 for O");
                }

            }           


        }
        //public static string PlayTheeGame()
            //get location from user
            //make sure it is a valid one 
            //update grid, mark symbol 
            //check for win (3 in a row)
            //maybe display number in the grid for the user to select location 
            //then select a random valid location for the computer to pick

            //refer to slot machines project 

    }
}




//string userSelection = Console.ReadLine();

//Console.WriteLine($"You have chosen to play with {userSelection} ");

////char[,] grid = new char[ROWS, COLS];

//Random rnd = new Random();              //array

//for (int i = 0; i < ROWS; i++)      //fill grid with blank
//{
//    for (int j = 0; j < COLS; j++)
//    {
//        grid[i, j] = BLANK;
//    }
//}

//Console.WriteLine("\nGrid for Tic Tac Toe:");
//for (int i = 0; i < ROWS; i++)
//{
//    for (int j = 0; j < COLS; j++)
//    {
//        Console.Write(grid[i, j] + " ");
//    }
//    Console.WriteLine();
//}






//int[,] grid = [ROW, COL];//new char[int.Parse(ROW), int.Parse(userCol)];

//static char[,] CreateGrid(Row,COL)

//int rows = int.Parse(userRow);
//int cols = int.Parse(userCol);

//Random rnd = new Random();
//static int[,] CreateGrid(ROW, COL) 
//{
//    char[,] grid = new char[ROW, COL];

//    for (int i = 0; i < ROW; i++)
//    {
//        for (int j = 0; j < COL; j++)
//        {
//            grid[i, j] = '_';//((i + j) % 2 == 0) ? SYM1 : SYM2;

//        }

//    }
//    return grid;
//}
//static void DisplayGrid(char[,] grid) 
//{


//}



//char[,] grid = new char[ROW, COL];

//for (int i = 0; i < ROW; i++)
//{
//    for (int j = 0; j < COL; j++)
//    {
//        grid[i, j] = '_';//((i + j) % 2 == 0) ? SYM1 : SYM2;

//    }

//}
//return grid;


//Console.Write("+");

//for (int j = 0; j < COL; j++)
//{
//    Console.Write("-+");
//}
//Console.WriteLine("");

//for (int i = 0; i < ROW; i++)
//{
//    Console.Write("|");
//    for (int j = 0; j < COL; j++)
//    {
//        Console.Write(grid[i, j] + "|");
//    }
//    Console.WriteLine("");
//}
//Console.Write("+");
//for (int j = 0; j < COL; j++)
//{
//    Console.Write("-+");
//}
//Console.WriteLine("");