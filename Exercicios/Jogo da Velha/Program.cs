using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; // Jogador 1 começa
    static int choice; // A escolha da posição no tabuleiro

    static int flag = 0; // Verifica o resultado

    static void Main()
    {
        do
        {
            Console.Clear(); // Sempre limpamos a tela para redesenhar o tabuleiro
            Console.WriteLine("Jogador 1: X e Jogador 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("Turno do Jogador 2");
            }
            else
            {
                Console.WriteLine("Turno do Jogador 1");
            }
            Console.WriteLine("\n");
            Board();

            // Verifique se a escolha é válida e se a posição está livre
            bool validChoice = false;
            while (!validChoice)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                }
            }

            // Marque a escolha no tabuleiro
            if (player % 2 == 0)
            {
                board[choice - 1] = 'O';
                player++;
            }
            else
            {
                board[choice - 1] = 'X';
                player++;
            }
            flag = CheckWin();
        }
        while (flag != 1 && flag != -1);

        // Imprime o resultado
        Console.Clear();
        Board();
        if (flag == 1)
        {
            Console.WriteLine("Jogador {0} ganhou!", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Empate!");
        }
        Console.ReadLine();
    }

    // Verifique se há um vencedor ou empate
    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        // Winning Condition For First Row
        if (board[0] == board[1] && board[1] == board[2])
        {
            return 1;
        }
        // Winning Condition For Second Row
        else if (board[3] == board[4] && board[4] == board[5])
        {
            return 1;
        }
        // Winning Condition For Third Row
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        // Winning Condition For First Column
        else if (board[0] == board[3] && board[3] == board[6])
        {
            return 1;
        }
        // Winning Condition For Second Column
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        // Winning Condition For Third Column
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condition
        else if (board[0] == board[4] && board[4] == board[8])
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6])
        {
            return 1;
        }
        #endregion

        #region Checking For Draw
        // If all the cells or values filled with X or O then any player has won the match
        else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' &&
            board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }

    // Tabuleiro de desenho
    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }
}