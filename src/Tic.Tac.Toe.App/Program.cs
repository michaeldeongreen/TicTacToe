using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic.Tac.Toe.App.Models.Enumerations;
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
            Console.WriteLine(string.Format("Board 1 Status: {0}.",results1.Status));

            //example 2 no winner
            string[,] board2 = new string[3, 3];
            board2[0, 0] = "X";
            board2[1, 0] = "O";
            board2[2, 0] = "X";
            GameResultService service2 = new GameResultService(board2);
            var results2 = service2.GameResults();
            Console.WriteLine(string.Format("Board 2 Status: {0}.", results2.Status));

            //example 3 deadlock
            string[,] board3 = new string[3, 3];
            board3[0, 0] = "X";
            board3[0, 1] = "O";
            board3[0, 2] = "X";
            board3[1, 0] = "O";
            board3[1, 1] = "X";
            board3[1, 2] = "O";
            board3[2, 0] = "O";
            board3[2, 1] = "X";
            board3[2, 2] = "O";
            GameResultService service3 = new GameResultService(board3);
            var results3 = service3.GameResults();
            Console.WriteLine(string.Format("Board 3 Status: {0}.", results3.Status));

            Console.Read();
        }
    }
}
