﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic.Tac.Toe.App.Models;
using Tic.Tac.Toe.App.Models.Enumerations;

namespace Tic.Tac.Toe.App.Services
{
    public class GameResultService
    {
        private string[,] _board;

        public TicTacToeResult GameStatus(string[,] board)
        {
            _board = board;

            var verticalResults = Vertical();
            if (verticalResults.Type == GameResultType.Winner)
                return verticalResults;

            var horizontalResults = Horizontal();
            if (horizontalResults.Type == GameResultType.Winner)
                return horizontalResults;

            var diagonalResults = Diagonal();
            if (diagonalResults.Type == GameResultType.Winner)
                return diagonalResults;

            return Deadlock();
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
                    return new TicTacToeResult(GameResultType.Winner,directionResult.Name, directionResult.Coordinates);
                }
            }
            return new TicTacToeResult(GameResultType.NoWinner, string.Empty,string.Empty);
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
                    return new TicTacToeResult(GameResultType.Winner, directionResult.Name, directionResult.Coordinates);
                }
            }
            return new TicTacToeResult(GameResultType.NoWinner, string.Empty, string.Empty);
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
                return new TicTacToeResult(GameResultType.Winner, diagonal1Result.Name, diagonal1Result.Coordinates);
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
                return new TicTacToeResult(GameResultType.Winner, diagonal2Result.Name, diagonal2Result.Coordinates);
            }

            return new TicTacToeResult(GameResultType.NoWinner, string.Empty, string.Empty);
        }

        private TicTacToeResult Deadlock()
        {
            int coordinatesChosen = 0;
            for (int row = 0; row <= 2; row++)
            {
                for (int column = 0; column <= 2; column++)
                {
                    if (_board[row, column] == "O" || _board[row, column] == "X")
                        coordinatesChosen++;
                }
            }
            if (coordinatesChosen == 9)
                return new TicTacToeResult(GameResultType.Deadlock, string.Empty, string.Empty);
            else
                return new TicTacToeResult(GameResultType.NoWinner, string.Empty, string.Empty);
        }
    }
}
