using System;

namespace TicTacToe // CSE210 Tic Tac Toe Prove assignment Sept 24 Kevin Allred : Unit 01 Prove: Developer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turnCounter = 0;
            string user = "X";
            Boolean running = true;
            Boolean userInputRunning = true;

            Console.WriteLine("Lets play tic tac toe!");
            List<string> spaces = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", };
            while (running)
            {
                printBoard(spaces);
                while (userInputRunning)
                {
                    Console.WriteLine($"{user}'s turn!");
                    string space = Console.ReadLine();
                    int spaceIndex = spaces.IndexOf(space);
                    if (spaceIndex > -1)
                    {
                        turnCounter++;
                        spaces.RemoveAt(spaceIndex);
                        spaces.Insert(spaceIndex, user);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken. Try again!");
                        printBoard(spaces);
                    }


                }
                //Game Winner Check
                //Horizontal Check
                if (spaces[0] == spaces[1] && spaces[1] == spaces[2])
                {
                    Console.WriteLine($"{spaces[0]} Wins!");
                    printBoard(spaces);
                    break;
                }
                else if (spaces[3] == spaces[4] && spaces[4] == spaces[5])
                {
                    Console.WriteLine($"{spaces[3]} Wins!");
                    printBoard(spaces);
                    break;
                }
                else if (spaces[6] == spaces[7] && spaces[7] == spaces[8])
                {
                    Console.WriteLine($"{spaces[6]} Wins!");
                    printBoard(spaces);
                    break;
                }

                //Vertical check
                else if (spaces[0] == spaces[3] && spaces[3] == spaces[6])
                {
                    Console.WriteLine($"{spaces[0]} Wins!");
                    printBoard(spaces);
                    break;
                }
                else if (spaces[1] == spaces[4] && spaces[4] == spaces[7])
                {
                    Console.WriteLine($"{spaces[1]} Wins!");
                    printBoard(spaces);
                    break;
                }
                else if (spaces[2] == spaces[5] && spaces[5] == spaces[8])
                {
                    Console.WriteLine($"{spaces[2]} Wins!");
                    printBoard(spaces);
                    break;
                }
                //Diagonal Check
                else if (spaces[0] == spaces[4] && spaces[4] == spaces[8])
                {
                    Console.WriteLine($"{spaces[0]} Wins!");
                    printBoard(spaces);
                    break;
                }
                else if (spaces[2] == spaces[4] && spaces[4] == spaces[6])
                {
                    Console.WriteLine($"{spaces[2]} Wins!");
                    printBoard(spaces);
                    break;
                }
                else if (turnCounter > 9)
                {
                    Console.WriteLine("It's a draw!");
                    printBoard(spaces);
                    break;
                }
                //Player switcher
                if (user == "X")
                {
                    user = "O";
                }
                else
                {
                    user = "X";
                }
            }
        }
        static void printBoard(List<string> Spaces)
        {
            Console.WriteLine($"{Spaces[0]}|{Spaces[1]}|{Spaces[2]}");
            Console.WriteLine($"-+-+-");
            Console.WriteLine($"{Spaces[3]}|{Spaces[4]}|{Spaces[5]}");
            Console.WriteLine($"-+-+-");
            Console.WriteLine($"{Spaces[6]}|{Spaces[7]}|{Spaces[8]}");
        }
    }
}