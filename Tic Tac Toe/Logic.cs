using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
                if (grid[0, Constants.COLS -1 -i] != playerSymbol)          //if (grid[0, Constants.COLS -1] != grid[-1, i])
                {
                    return false;
                    //break;
                }
            }
            return true;
        }
        public static bool CheckWin(string[,] grid, string playerSymbol)
        {
            return  CheckMidLine(grid, playerSymbol) ||
                    CheckHorizontalLine(grid, playerSymbol) ||
                    CheckVerticalLine(grid, playerSymbol) ||
                    CheckDiagonalLine1(grid, playerSymbol) ||
                    CheckDiagonalLine2(grid, playerSymbol);

        }
        public static bool CheckDraw(string[,]grid)     //draw method to check to see if the grid is full with no winner 
        {
            for (int i = 0; i < Constants.ROWS; i++) 
            {
                for (int j = 0; j < Constants.COLS; j++) 
                {
                    if (grid[i,j] == " ") 
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static int GetComputerPosition(string[,] grid, string computerSymbol)    //(1-access modifier, 2-static method (can be called), 3-return type, 4-method name, 5-params- 2d string array and symbol the computer uses)
        {
            Random random = new Random();                       //create random number
            List<int> emptyGridPosition = new List<int>();     //create a list to store positions of empty positions 

            for (int i = 0; i < Constants.ROWS; i++)
            {
                for (int j = 0; j < Constants.COLS; j++)
                {
                    if (grid[i, j]  != Constants.SYMBOL1.ToString() && grid[i, j] != Constants.SYMBOL2.ToString())    //look for numbers = empty or look for symbols to identify taken cells
                    {                                                             
                        emptyGridPosition.Add(i * Constants.COLS + j);            
                    }
                }
            }
            if (emptyGridPosition.Count > 0)
            {
                return emptyGridPosition[random.Next(emptyGridPosition.Count)];
            }
            else
            {
                return -1;
            }
            //return emptyGridPosition.Count > 0 ? emptyGridPosition[random.Next(emptyGridPosition.Count)] : -1;    //another way to write if/else
            Logic.ValidatePlayerPosition();
        }
        public static (int row, int col) ValidatePlayerPosition()
        {
            while (true) 
            {
                string playerInput = Console.ReadLine();

                if (int.TryParse(playerInput, out int position)) //validate
                {
                    if (position >= Constants.FIRST_POSITION && position <= Constants.LAST_POSITION) //if both conditions are true, the input is valid (counter in DisplayGrid method to make dynamic???)
                    {
                        int row = (position - 1) / Constants.COLS;
                        int col = (position - 1) % Constants.COLS;
                        return (row, col);
                    }
                    if (position >= 1 && position <= Constants.LAST_POSITION)
                    {
                        int row = (position - 1) / 3;
                        int col = (position - 1) % 3;
                    }
                }
            }
            
        }

        public static string GetComputerSymbol(string playerSymbol)
        {
            if (playerSymbol == Constants.SYMBOL1.ToString())
            {
                return Constants.SYMBOL2.ToString();
            }
            else
            {
                return Constants.SYMBOL1.ToString();                    //should this be in logic file
            }            
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
            