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
            Console.WriteLine($"This a game where you take turns against the computer using a symbol {Constants.SYMBOL1} or {Constants.SYMBOL2} to fill in a 3x3 grid");
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
                    grid[i, j] = counter++.ToString();  //have tried using Constant.COUNTER+1 (++causes an error) but fills with 11           //checks if i and j are even 
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
                Console.WriteLine("Please choose the positon between 1-9 of the grid you wish to place your symbol");
                string playerInput = Console.ReadLine();
                
                Console.WriteLine();

                int[,] numberedGrid = new int[Constants.ROWS,Constants.COLS];   //mapping 

                for (int row  = 0; row < Constants.ROWS; row++) 
                {
                    for (int col = 0; col < Constants.COLS; col++) 
                    {
                        numberedGrid[row, col] = row * Constants.COLS + col + 1;            
                        //numberedGrid = accesses elemeentt row & col
                        //calculate starting number = row * Constants.COLS(3) + col (adds the current index to row starting value) + 1 (so number starts at 1 not 0, since row & col are 0)  
                    }                
                }                
                //validate input //playerInput is string, need to convert to int (TryParse)
                //out = used to pass argument by reference. Tells TryParse that it can modify this variable and return value through it
                //int position - declares nw int variable to store parsed result
                if (int.TryParse(playerInput, out int position)) //validate
                {
                    if (position >= Constants.FIRST_POSITION && position <= 9) //if both conditions are true, the input is valid (counter in DisplayGrid method to make dynamic???)
                    {
                        return playerInput;                        
                    } 
                }                                    
                
                Console.WriteLine("Invalid selection, please try again");                               
            }
        }
        public static string RowPosition()
        {
            calculate Row -(position - 1) / Constants.ROWS / COLS
            Console.WriteLine(" ");
            return;
        }
        public static string ColPosition() 
        {
            calculate Col -position - 1 % Constants.ROWS / COLS
            Console.WriteLine(" ");
            return;
        }
        //calculation convert 1-9 to 0-8 (position -1)
        //calculate Row - (position -1) / Constants.ROWS/COLS       eg position 5 - 1 = 4 / 3 = 1 
        //calculate Col - position -1 % Constants.ROWS/COLS         eg position 5 -1 % 3 = 4 % 3 =1


    }
    //TO DO

    //convert player position to grid location 
    //check if location is available 
    //update grid
    //check for winner / draw 


    //get location from user
    //make sure it is a valid one
    //update grid, mark symbol
    //check for win(3 in a row)
    //maybe display number in the grid for the user to select location
    //then select a random valid location for the computer to pick

    //refer to slot machines project

}



//PRINT
//for (int row = 0; row < Constants.ROWS; row++)
//{
//    for (int col = 0; col < Constants.COLS; col++)
//    {
//        Console.Write(numberedGrid[row, col] + " ");    //.ToString()
//    }
//    Console.WriteLine();
//}



//var gridMapping = new Dictionary <int, (int, int) >();
//gridMapping.Add(1, (0, 0));
//gridMapping.Add(2, (0, 1));
//gridMapping.Add(3, (0, 2));
//gridMapping.Add(4, (1, 0));
//gridMapping.Add(5, (1, 1));
//gridMapping.Add(6, (1, 2));
//gridMapping.Add(7, (2, 0));
//gridMapping.Add(8, (2, 1));
//gridMapping.Add(9, (2, 2));             
//int row = 3;
//int col = 3;

//var gridMapping = new Dictionary<int, (int, int)>();        //creates a dictionary Key and Value 



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