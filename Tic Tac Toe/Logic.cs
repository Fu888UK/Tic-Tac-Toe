namespace Tic_Tac_Toe
{
    internal class Logic
    {
        static void Main(string[] args)
        {
            const int ROWS = 3;
            const int COLS = 3;
            const char SYMBOL1 = 'O';
            const char SYMBOL2 = 'X';
            
            
            Random rnd = new Random();              //array
            int[,] grid = new int[ROWS,COLS];

            for (int i = 0; i < ROWS; i++) 
            {
                for (int j = 0; j < COLS; j++) 
                {
                    //refer to 2D arrays project (Mode 3)
                    //Console.WriteLine(grid[i,j] + " ");
                }
            }

        }
    }
}


//3x3 grid 
//set player one to X and computer to O or visa versa, let the player choose which symbol they want 
//take turns choosing symbol in empty space on the grid 
//first one to 3 in a row wins 
//if no player wins its a draw 



//TAKEN FROM 2d ARRAYS PROJECT 
//for (int i = 0; i < rows; i++)                                //outer loop i goes through each row 
//{
//    for (int j = 0; j < cols; j++)                            // inner loop j goes through eacj col 
//    {
//        grid[i, j] = ((i + j) % 2 == 0) ? SYM1 : SYM2;        //checks if i and j are even 
//    }
//}
//Console.Write("+");

//for (int j = 0; j < cols; j++)              //top border 
//{
//    Console.Write("-+");                   //??? added a + but now getting 2 extra -                   
//                                           //Console.Write("+");                   //??? AFTER DUBUGGING FEEL I SHOULD ADD SOMETHING HERE (FOR COL)                     
//}
//Console.WriteLine("");

//for (int i = 0; i < rows; i++)
//{
//    Console.Write("|");
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write(grid[i, j] + "|");    //replaced space with|, but now has extra | at the end 
//    }
//    Console.WriteLine("");

//}

//Console.Write("+");
//for (int j = 0; j < cols; j++)  //bottom border 
//{
//    Console.Write("-+");       //added a +
//}
//Console.WriteLine("");
