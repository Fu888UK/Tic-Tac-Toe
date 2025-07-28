using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Net.Sockets;
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
        }
                    
        public static void DisplayGrid(string[,] grid)
        {
            Console.WriteLine("Below is a grid with numbers in it, you will use these numbers to select a location to fill in");
                        
            int counter = 1;

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
                    grid[i, j] = counter++.ToString();                                           //checks if i and j are even 
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
            Console.WriteLine("Select the symbol you wish to play with, press 1 for O or 2 for X");
            
            return Console.ReadLine();            
        }

        public static string GetPlayerSymbol()     //populating
        {
            while (true)
            {
                string selection = AskUserInput();
                if (selection == "1")//Constants.SYMBOL1.ToString());
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
                    Console.WriteLine($"Invalid selection, please seleect 1 for {Constants.SYMBOL1} or 2 for {Constants.SYMBOL2}");
                }
            }
        }

        public static string GetPlayerPosition()
        {
            Console.WriteLine(' ');                               

            while (true)
            {
                Console.WriteLine("Now you have chosen the symbol you wish to play with, now choose the positon between 1-9 of the grid you wish to place your symbol ");
                string input = Console.ReadLine();


                //var gridMapping = new Dictionary <int, (int, int) >();
                //gridMapping.Add(1, (0, 0));
                //gridMapping.Add(2, (0, 1));
                //gridMapping.Add(3, (0, 2));
                //gridMapping.Add(4, (1, 0));
                //gridMapping.Add(5, (1, 1));
                //gridMapping.Add(6, (1, 2));
                //gridMapping.Add(7, (2, 0));
                //gridMapping.Add(8, (2, 1));
                //gridMapping.Add(9, (2, 2));             // need to refer to previous project(s) to write this better 

                var gridMapping = new Dictionary<int, (int, int)>();

                for (int Constants.ROWS = 0; Constants.ROWS < 0; Constants.ROWS++) // create mapping dynamically 
                {
                    for (int Constants.COLS = 0; Constants.COLS < 0; Constants.COLS++)
                    {

                    }

                }

                return Console.ReadLine();
                
                // 'if' for invalid selection 
                Console.WriteLine("Invalid selection, please try again");

                //int number = gridMapping[(Constants.ROWS, Constants.COLS)];
            }
            


        }


               



    }
    //TO DO

    //get location from user
    //make sure it is a valid one
    //update grid, mark symbol
    //check for win(3 in a row)
    //maybe display number in the grid for the user to select location
    //then select a random valid location for the computer to pick

    //refer to slot machines project

}




//for (int i = 0; i < Constants.ROWS; i++)      //fill grid with BLANK
//{
//    for (int j = 0; j < Constants.COLS; j++)
//    {                    
//        grid[i, j] = Constants.BLANK.ToString();                    
//    }
//}
//Console.WriteLine("\nGrid for Tic Tac Toe:");

//string playerSelection = Console.ReadLine();
//Console.WriteLine($"You have chosen {playerSelection}");





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