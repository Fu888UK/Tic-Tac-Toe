using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public static class Logic
    {
        public static string[,] InitializeGrid(string[,] grid) 
        {
            int counter = 1;

            for (int i = 0; i < Constants.ROWS; i++)                                //outer loop i goes through each row 
            {
                for (int j = 0; j < Constants.COLS; j++)                            // inner loop j goes through eacj col 
                {
                    grid[i, j] = counter++.ToString();                              //checks if i and j are even 
                }
            }
            return grid;

        }
        public static bool CheckWin(string[,] grid, string playerSymbol)
        {
            int midLine = Constants.ROWS / 2;
            //bool win = true;
            
            for (int i = 1; i < Constants.COLS; i++)
            {
                if (grid[midLine, i] != playerSymbol)
                {
                    return false;                 
                }                    
            }
            return true;        //placed after loop after checking cols


        }

        public static bool CheckDraw(string[,]grid)
        {

            return true;
        }

    }
}







//bool win = true;
//for (int row = 0; row < Constants.ROWS; row++)
//{
//    if (grid[row, 0]) == playerSymbol && grid[row, 1] == playerSymbol && grid[row, 2] == playerSymbol)
//                {
//    int midLine = Constants.ROWS / 2;
//    for (int i = 1; i < Constants.COLS; i++)
//    {
//        win = false;
//    }
//}
            