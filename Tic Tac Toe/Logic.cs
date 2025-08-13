using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public static class Logic
    {
        public static void InitializeGrid(string[,] grid) 
        {
            int counter = 1;

            for (int i = 0; i < Constants.ROWS; i++)                                //outer loop i goes through each row 
            {
                for (int j = 0; j < Constants.COLS; j++)                            // inner loop j goes through eacj col 
                {
                    grid[i, j] = counter++.ToString();                              //checks if i and j are even 
                }
            }

        }

    }
}
