using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static bool CheckMidLine(string[,] grid, string playerSymbol)
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
        public static bool CheckHorizontalLine(string[,] grid, string playerSymbol) 
        {
            for (int i = 0; i < Constants.ROWS; i++) 
            {
                for (int j = 0; j < Constants.COLS; j++) 
                {
                    if (grid[i,0] != grid[i, j]) 
                    {
                        return false;
                        break;
                    }                
                }            
            }
            return true;

        }
        public static bool CheckVerticalLine(string[,] grid, string playerSymbol)
        {
            for (int i = 0; i < Constants.COLS; i++) 
            {
                for (int j = 0; j < Constants.ROWS; j++)
                {
                    if (grid[j, i] != grid[0, i]) 
                    {
                        return false;
                        break;
                    }
                }
                
            }
            return true;
        }
        
        public static bool CheckDiagonalLine1(string[,] grid, string playerSymbol)
        {            
            for (int i = 0; i < Constants.ROWS; i++)
            {
                if (grid[0, 0] != grid[i, i])
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        public static bool CheckDiagonalLine2(string[,] grid, string playerSymbol)
        {
            for (int i = 0; i < Constants.ROWS; i++)
            {
                if (grid[0, Constants.COLS -1] != grid[-1, i])
                {
                    return false;
                    break;
                }
            }
            return true;
        }


        public static bool CheckDraw(string[,]grid)     //draw method to check to see if the grid is full with no winner 
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
            