using System;

class Program
{
    // Create the Playfield.
    static char[,] playField =
    {
        {'1','2','3' }, // Row Zero
        {'4','5','6'}, // Row One
        {'7','8','9' }  // Row Two
    };

    static int currentPlayer = 1; // Player 1 starts

    static void Main(string[] args)
    {
        bool inputCorrect = true;
        do
        {
            Console.Clear(); // Clear the console

            Console.WriteLine("Player {0}: Enter your selection -", currentPlayer);
            SetField();

            // Get the player's input
            string input = Console.ReadLine();

            // Check if the input is a valid move
            int move;
            bool isValidMove = int.TryParse(input, out move) && move >= 1 && move <= 9 && playField[(move - 1) / 3, (move - 1) % 3] == (char)(move + '0');

            if (isValidMove)
            {
                // Update the playfield with the player's move
                playField[(move - 1) / 3, (move - 1) % 3] = currentPlayer == 1 ? 'X' : 'O';

                // Check for a win
                bool isWin = CheckWin();

                if (isWin)
                {
                    Console.Clear();
                    SetField();
                    Console.WriteLine("Player {0} wins!", currentPlayer);
                    inputCorrect = false;
                }
                else
                {
                    // Switch to the next player
                    currentPlayer = currentPlayer == 1 ? 2 : 1;
                }
            }
            else
            {
                Console.WriteLine("Invalid move! Please try again.");
                Console.ReadLine();
            }
        } while (inputCorrect);
    }

    // Display the playfield
    static void SetField()
    {
        Console.WriteLine("  |   |  ");
        Console.WriteLine("{0} | {1} | {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
        Console.WriteLine("__|___|__");
        Console.WriteLine("  |   |  ");
        Console.WriteLine("{0} | {1} | {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
        Console.WriteLine("__|___|__");
        Console.WriteLine("  |   |  ");
        Console.WriteLine("{0} | {1} | {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
        Console.WriteLine("  |   |  ");
    }

    // Check for a win condition
    static bool CheckWin()
    {
        // Check horizontal lines
        for (int i = 0; i < 3; i++)
        {
            if (playField[i, 0] == playField[i, 1] && playField[i, 1] == playField[i, 2])
            {
                return true;
            }
        }

        // Check vertical lines
        for (int i = 0; i < 3; i++)
        {
            if (playField[0, i] == playField[1, i] && playField[1, i] == playField[2, i])
            {
                return true;
            }
        }

        // Check diagonal lines
        if ((playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2]) ||
            (playField[0, 2] == playField[1, 1] && playField[1, 1] == playField[2, 0]))
        {
            return true;
        }

        return false;
    }
}
