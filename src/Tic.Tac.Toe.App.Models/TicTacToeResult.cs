using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic.Tac.Toe.App.Models
{
    public class TicTacToeResult
    {
        public bool IsWinner { get; private set; }
        public string WinnerName { get; private set; }
        public string WinningCoordinates { get; private set; }

        public TicTacToeResult(bool isWinner, string winnerName, string winningCoordinates)
        {
            IsWinner = isWinner;
            WinnerName = winnerName;
            WinningCoordinates = winningCoordinates;
        }
    }
}
