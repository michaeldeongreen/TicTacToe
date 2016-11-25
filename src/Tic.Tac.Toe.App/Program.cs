using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic.Tac.Toe.App.Services;

namespace Tic.Tac.Toe.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1 winner
            string[,] board1 = new string[3, 3];
            board1[0, 0] = "X";
            board1[1, 0] = "X";
            board1[2, 0] = "X";
            GameResultService service1 = new GameResultService(board1);
            var results1 = service1.GameResults();
            if (results1.IsWinner)
                Console.WriteLine(string.Format("For Board 1, the Winner Name is: {0} and the Winner Coordinates are: {1}", results1.WinnerName, results1.WinningCoordinates));
            else
                Console.WriteLine("No Winner for Board 1");

            //example 2 no winner
            string[,] board2 = new string[3, 3];
            board2[0, 0] = "X";
            board2[1, 0] = "O";
            board2[2, 0] = "X";
            GameResultService service2 = new GameResultService(board2);
            var results2 = service2.GameResults();
            if (results2.IsWinner)
                Console.WriteLine(string.Format("For Board 2, the Winner Name is: {0} and the Winner Coordinates are: {1}", results2.WinnerName, results2.WinningCoordinates));
            else
                Console.WriteLine("No Winner for Board 2");

            Console.Read();
        }
    }
}
