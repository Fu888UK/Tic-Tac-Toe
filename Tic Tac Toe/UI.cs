using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tic_Tac_Toe
{
    public static class UI_Method
    {
        public static void DisplayWelcomeMessage() 
        {
            const char SYM1 = 'X';
            const char SYM2 = 'O';
            const int ROW = '3';
            const int COL = '3';


            Console.WriteLine("Hello, welcome to the world of TIC TAC TOE");
            Console.WriteLine("This a game where you take turns against the computer using a symbol X or O to fill in a 3x3 grid");
            Console.WriteLine("The winner of the game is the first one to get 3 symbols in a row");
            Console.WriteLine("Select the symbol you wish to play with, press 1 for X or 2 for O");

            string userSelection = Console.ReadLine();

            Console.WriteLine($"You have chosen to play with {userSelection} ");
                        
                        
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
        }
        

    }
}
