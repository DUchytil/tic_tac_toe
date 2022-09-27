// Program: CSE 210 Tic Tac Toe
// Author: David Uchytil

using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Write your code here
            // displayBoard();

            string user = "x";


            //Use this for changing turns
           

            List<string> boardComponents = new List<string>{"1", "2", "3", "4", "5", "6", "7", "8", "9"};

            int gameOver = determineWinner(boardComponents);
            string choice = " ";
            
            Console.WriteLine($"\n{boardComponents[0]}|{boardComponents[1]}|{boardComponents[2]}\n-+-+-\n{boardComponents[3]}|{boardComponents[4]}|{boardComponents[5]}\n-+-+-\n{boardComponents[6]}|{boardComponents[7]}|{boardComponents[8]}");

            while (gameOver < 1)
            {
                 if (user == "x")
                {
                    Console.Write("\nX's turn to choose a square (1-9): ");
                    choice = Console.ReadLine();

                    // string choice = "3";
                    if (choice == "1")
                    {
                        boardComponents[0] = "X";
                    }
                    else if (choice == "2")
                    {
                        boardComponents[1] = "X";
                    }
                    else if (choice == "3")
                    {
                        boardComponents[2] = "X";
                    }
                    else if (choice == "4")
                    {
                        boardComponents[3] = "X";
                    }
                    else if (choice == "5")
                    {
                        boardComponents[4] = "X";
                    }
                    else if (choice == "6")
                    {
                        boardComponents[5] = "X";
                    }
                    else if (choice == "7")
                    {
                        boardComponents[6] = "X";
                    }
                    else if (choice == "8")
                    {
                        boardComponents[7] = "X";
                    }
                    else if (choice == "9")
                    {
                        boardComponents[8] = "X";
                    }
                    user = "o";
                }

                else
                {
                    Console.Write("\nO's turn to choose a square (1-9): ");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        boardComponents[0] = "O";
                    }
                    else if (choice == "2")
                    {
                        boardComponents[1] = "O";
                    }
                    else if (choice == "3")
                    {
                        boardComponents[2] = "O";
                    }
                    else if (choice == "4")
                    {
                        boardComponents[3] = "O";
                    }
                    else if (choice == "5")
                    {
                        boardComponents[4] = "O";
                    }
                    else if (choice == "6")
                    {
                        boardComponents[5] = "O";
                    }
                    else if (choice == "7")
                    {
                        boardComponents[6] = "O";
                    }
                    else if (choice == "8")
                    {
                        boardComponents[7] = "O";
                    }
                    else if (choice == "9")
                    {
                        boardComponents[8] = "O";
                    }
                    user = "x";
                }
                Console.WriteLine($"\n{boardComponents[0]}|{boardComponents[1]}|{boardComponents[2]}\n-+-+-\n{boardComponents[3]}|{boardComponents[4]}|{boardComponents[5]}\n-+-+-\n{boardComponents[6]}|{boardComponents[7]}|{boardComponents[8]}");
                gameOver = determineWinner(boardComponents);
            }


            if (gameOver == 1)
            {
                Console.WriteLine("X's win!!!");
            }
            else
            {
                Console.WriteLine("O's win!!!");
            }
            Console.WriteLine("Good game. Thanks for playing!");

            


            

        }
        
        static int determineWinner(List<string> boardComponents)
        {   
            int gameOver = 0;

            //X's condition check
            if (boardComponents[0] == "X" && boardComponents[1] == "X" && boardComponents[2] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[3] == "X" && boardComponents[4] == "X" && boardComponents[5] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[6] == "X" && boardComponents[7] == "X" && boardComponents[8] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[0] == "X" && boardComponents[4] == "X" && boardComponents[8] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[2] == "X" && boardComponents[4] == "X" && boardComponents[6] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[0] == "X" && boardComponents[3] == "X" && boardComponents[6] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[1] == "X" && boardComponents[4] == "X" && boardComponents[7] == "X")
            {
                gameOver = 1;
            }
            else if (boardComponents[2] == "X" && boardComponents[5] == "X" && boardComponents[8] == "X")
            {
                gameOver = 1;
            }

            //O's condition check
            else if (boardComponents[0] == "O" && boardComponents[1] == "O" && boardComponents[2] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[3] == "O" && boardComponents[4] == "O" && boardComponents[5] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[6] == "O" && boardComponents[7] == "O" && boardComponents[8] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[0] == "O" && boardComponents[4] == "O" && boardComponents[8] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[2] == "O" && boardComponents[4] == "O" && boardComponents[6] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[0] == "O" && boardComponents[3] == "O" && boardComponents[6] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[1] == "O" && boardComponents[4] == "O" && boardComponents[7] == "O")
            {
                gameOver = 2;
            }
            else if (boardComponents[2] == "O" && boardComponents[5] == "O" && boardComponents[8] == "O")
            {
                gameOver = 2;
            }


            return gameOver;//If 2, o's win. If 1, x's win.
        }

    }


}
