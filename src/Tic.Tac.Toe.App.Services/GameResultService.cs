using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic.Tac.Toe.App.Models;

namespace Tic.Tac.Toe.App.Services
{
    public class GameResultService
    {
        private string[,] _board;

        public GameResultService(string[,] board)
        {
            _board = board;
        }

        public TicTacToeResult GameResults()
        {
            var verticalResults = Vertical();
            if (verticalResults.IsWinner)
                return verticalResults;

            var horizontalResults = Horizontal();
            if (horizontalResults.IsWinner)
                return horizontalResults;

            var diagonalResults = Diagonal();
            if (diagonalResults.IsWinner)
                return diagonalResults;

            return new TicTacToeResult(false, string.Empty, string.Empty);
        }

        private TicTacToeResult Vertical()
        {
            for (int column = 0; column <= 2; column++)
            {
                var directionResult = new DirectionResult();

                for (int row = 0; row <= 2; row++)
                {
                    directionResult.InspectBoardCoordinate(_board[row, column], row, column);
                }
                if (directionResult.IsThereAWinner())
                {
                    return new TicTacToeResult(directionResult.IsThereAWinner(),directionResult.Name, directionResult.Coordinates);
                }
            }
            return new TicTacToeResult(false, string.Empty,string.Empty);
        }

        private TicTacToeResult Horizontal()
        {
            for (int row = 0; row <= 2; row++)
            {
                var directionResult = new DirectionResult();

                for (int column = 0; column <= 2; column++)
                {
                    directionResult.InspectBoardCoordinate(_board[row, column], row, column);
                }
                if (directionResult.IsThereAWinner())
                {
                    return new TicTacToeResult(directionResult.IsThereAWinner(), directionResult.Name, directionResult.Coordinates);
                }
            }
            return new TicTacToeResult(false, string.Empty, string.Empty);
        }

        private TicTacToeResult Diagonal()
        {
            //first 3x3 diagonal
            var diagonal1Result = new DirectionResult();
            for (int coordinate = 0; coordinate <= 2; coordinate++)
            {
                diagonal1Result.InspectBoardCoordinate(_board[coordinate, coordinate], coordinate, coordinate);
            }
            if (diagonal1Result.IsThereAWinner())
            {
                return new TicTacToeResult(diagonal1Result.IsThereAWinner(), diagonal1Result.Name, diagonal1Result.Coordinates);
            }

            //second 3x3 diagonal
            var diagonal2Result = new DirectionResult();
            int column = 2;
            for (int row = 0; row <= 2; row++)
            {
                diagonal2Result.InspectBoardCoordinate(_board[row, column],row, column);
                column--;
            }
            if (diagonal2Result.IsThereAWinner())
            {
                return new TicTacToeResult(diagonal2Result.IsThereAWinner(), diagonal2Result.Name, diagonal2Result.Coordinates);
            }

            return new TicTacToeResult(false, string.Empty, string.Empty);
        }
    }
}
