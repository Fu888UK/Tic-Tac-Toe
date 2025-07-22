namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            UI_Method.DisplayWelcomeMessage();                  
                     
                       

            UI_Method.GetPlayerSymbol();

            string[,] grid = new string[Constants.ROWS, Constants.COLS];      //defined grid here which will be used across all files 

            

            //string gridString = Convert.ToString(grid);
            UI_Method.DisplayGrid(grid);
            
        }
    }
}


//3x3 grid 
//set player one to X and computer to O or visa versa, let the player choose which symbol they want 
//take turns choosing symbol in empty space on the grid 
//first one to 3 in a row wins 
//if no player wins its a draw 


//char[,] grid = new char[ROWS, COLS];

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
//the for loops should be in UI file




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
//                                           //Console.Write("+");                                        
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
