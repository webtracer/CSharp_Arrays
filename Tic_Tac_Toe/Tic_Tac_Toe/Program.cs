using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        // my solution (doesn't quite work but one game works perfectly
        /*
        static string[,] ticTacToe =
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };

        static string playTheGame = "Y";
        static bool winner = false;

        static void Main(string[] args)
        {

        DrawTheBoard();

        while (playTheGame != "N")
        {
            do
            {
                if (winner == false) //Added these to stop the game from asking for a move once theres a winner
                {
                    //Get the square from Player 1
                    PlayTheGame(1);
                    Console.Clear();
                    DrawTheBoard();
                    CheckTheBoard();
                }
                if (winner == false)
                {
                    //Now Player 2
                    PlayTheGame(2);
                    Console.Clear();
                    DrawTheBoard();
                    CheckTheBoard();
                }
            } while (winner == false);

            Console.Write($"Would you like to play again? (Y/N): ");
            playTheGame = Console.ReadLine().ToUpper();
            if(playTheGame == "Y")
            {
                winner = false;
                //reset the board
                DrawTheBoard();
            }

        }
    }

    // DrawTheBoard is the function that prints the board out
    public static void DrawTheBoard()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("-   Tic Tac Toe  -");
        Console.WriteLine("------------------");
        //my solution
        for (int i = 0, j = 0; i < ticTacToe.GetLength(0);i++)
        {
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {ticTacToe[i,j]}  |  {ticTacToe[i,j+1]}  |  {ticTacToe[i,j+2]} ");
            if (i < 2)
            {
                Console.WriteLine($"     |     |     ");
                Console.WriteLine($"_____|_____|_____");
            }
            else
            {
                Console.WriteLine($"     |     |    ");
            }
        }
    }

    public static void PlayTheGame(int player)
    {
        string chosenSquare;
        chosenSquare = GetPlayerChoice(player);
        if(player == 1)
        {
            string mark = "X";
            UpdateTheBoard(Int32.Parse(chosenSquare), mark, player);
        }
        else
        {
            string mark = "O";
            UpdateTheBoard(Int32.Parse(chosenSquare), mark, player);
        }

    }

    public static string GetPlayerChoice(int playerNumber)
    {
        if (playerNumber == 1)
        {
            Console.WriteLine("");
            Console.Write($"Player 1: Choose a square: ");
        }
        else
        {
            Console.WriteLine("");
            Console.Write($"Player 2: Choose a square: ");
        }
        string playerChoice = Console.ReadLine();

        return playerChoice;
    }

    public static void UpdateTheBoard(int square, string blockIt, int playerNumber)
    {
        switch (square)
        {
            case 1:
                if(ticTacToe[0, 0] == "X" || ticTacToe[0, 0] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[0, 0] = blockIt;
                }
                break;                
            case 2:
                if (ticTacToe[0, 1] == "X" || ticTacToe[0, 1] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[0, 1] = blockIt;
                }
                break;
            case 3:
                if (ticTacToe[0, 2] == "X" || ticTacToe[0, 2] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[0, 2] = blockIt;
                }
                break;
            case 4:
                if (ticTacToe[1, 0] == "X" || ticTacToe[1, 0] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[1, 0] = blockIt;
                }
                break;
            case 5:
                if (ticTacToe[1, 1] == "X" || ticTacToe[1, 1] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[1, 1] = blockIt;
                }
                break;
            case 6:
                if (ticTacToe[1, 2] == "X" || ticTacToe[1, 2] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[1, 2] = blockIt;
                }
                break;
            case 7:
                if (ticTacToe[2, 0] == "X" || ticTacToe[2, 0] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[2, 0] = blockIt;
                }
                break;
            case 8:
                if (ticTacToe[2, 1] == "X" || ticTacToe[2, 1] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[2, 1] = blockIt;
                }
                break;
            case 9:
                if (ticTacToe[2, 2] == "X" || ticTacToe[2, 2] == "O")
                {
                    Console.WriteLine("That square is already taken, please try again");
                    PlayTheGame(playerNumber);
                }
                else
                {
                    ticTacToe[2, 2] = blockIt;
                }
                break;
            default:
                Console.WriteLine("You have not entered a valid value, please try again!");
                break;
        }
    }

    public static void CheckTheBoard()
    {
        string diagL1 = "";
        string diagL2 = "";
        string diagL3 = "";
        string diagR1 = "";
        string diagR2 = "";
        string diagR3 = "";
        string winningMark = "";

        for (int i = 0, j = 2; i < ticTacToe.GetLength(0); i++, j--)
        { //this loops through and checks the elements in the diagonals from left to right

            if (i == 0)
            {
                diagL1 = ticTacToe[i, j];
            }
            else if(i == 1)
            {
                diagL2 = ticTacToe[i, j];
            }
            else
            {
                diagL3 = ticTacToe[i, j];
            }
        }

        for (int i = 0; i < ticTacToe.GetLength(0); i++)
        { //this loops through and checks the elements in the diagonals from right to left
            if (i == 0)
            {
                diagR1 = ticTacToe[i, i];
            }
            else if (i == 1)
            {
                diagR2 = ticTacToe[i, i];
            }
            else
            {
                diagR3 = ticTacToe[i, i];
            }
        }

        //Now compare the side to side and up and downs
        if (diagL1 == diagL2 && diagL2 == diagL3)
        {
            winner = true;
            winningMark = diagL1;
        }
        else if (diagR1 == diagR2 && diagR2 == diagR3)
        {
            winner = true;
            winningMark = diagR1;
        }
        else if(ticTacToe[0,0] == ticTacToe[0, 1] && ticTacToe[0, 0] == ticTacToe[0, 2])
        {
            winner = true;
            winningMark = ticTacToe[0, 0];
        }
        else if (ticTacToe[1, 0] == ticTacToe[1, 1] && ticTacToe[1, 0] == ticTacToe[1, 2])
        {
            winner = true;
            winningMark = ticTacToe[1, 0];
        }
        else if (ticTacToe[2, 0] == ticTacToe[2, 1] && ticTacToe[1, 0] == ticTacToe[2, 2])
        {
            winner = true;
            winningMark = ticTacToe[2, 0];
        }
        else if (ticTacToe[0, 0] == ticTacToe[1, 0] && ticTacToe[0, 0] == ticTacToe[2, 0])
        {
            winner = true;
            winningMark = ticTacToe[0, 0];
        }
        else if (ticTacToe[0, 1] == ticTacToe[1, 1] && ticTacToe[0, 1] == ticTacToe[2, 1])
        {
            winner = true;
            winningMark = ticTacToe[0, 1];
        }
        else if (ticTacToe[0, 2] == ticTacToe[1, 2] && ticTacToe[0, 2] == ticTacToe[2, 2])
        {
            winner = true;
            winningMark = ticTacToe[0, 2];
        }

        //if there is a winner, lets tell them!
        if (winner == true)
        {
            if (winningMark == "X")
            {
                Console.WriteLine("Congratulations Player 1!  You Win!");
            }
            else
            {
                Console.WriteLine("Congratulations Player 2!  You Win!");
            }
        }
    }*/

        //his solution

        static char[,] playfield =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;

            SetField();

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('X', input);
                    turns++;
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('O', input);
                    turns++;
                }

                SetField();
                #region
                //check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach(char playerChar in playerChars)
                {
                    if(((playfield[0,0] == playerChar) && (playfield[0,1] == playerChar) && (playfield[0,2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar)))
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 is the winner!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 is the winner!");
                        }
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if(turns == 10)
                    {
                        Console.WriteLine("It's a Draw!  Press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                #endregion

                #region
                // Test if field is already taken
                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field! ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playfield[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playfield[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input, please choose a different field");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion
            } while (true);
        }

        public static void ResetField()
        {
            char[,] playfieldInitial =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };
            playfield = playfieldInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {playfield[0, 0]}  |  {playfield[0, 1]}  |  {playfield[0, 2]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {playfield[1, 0]}  |  {playfield[1, 1]}  |  {playfield[1, 2]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {playfield[2, 0]}  |  {playfield[2, 1]}  |  {playfield[2, 2]} ");
            Console.WriteLine($"     |     |    ");
            //turns++;
        }

        public static void EnterXorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: playfield[0, 0] = playerSign; break;
                case 2: playfield[0, 1] = playerSign; break;
                case 3: playfield[0, 2] = playerSign; break;
                case 4: playfield[1, 0] = playerSign; break;
                case 5: playfield[1, 1] = playerSign; break;
                case 6: playfield[1, 2] = playerSign; break;
                case 7: playfield[2, 0] = playerSign; break;
                case 8: playfield[2, 1] = playerSign; break;
                case 9: playfield[2, 2] = playerSign; break;
            }
        }
    }
}
