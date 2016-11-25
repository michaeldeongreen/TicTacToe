using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic.Tac.Toe.App.Models.Enumerations;

namespace Tic.Tac.Toe.App.Models
{
    public class TicTacToeResult
    {
        public GameResultType Type { get; private set; }
        public string WinnerName { get; private set; }
        public string WinningCoordinates { get; private set; }

        public TicTacToeResult(GameResultType type, string winnerName, string winningCoordinates)
        {
            Type = type;
            WinnerName = winnerName;
            WinningCoordinates = winningCoordinates;
        }
    }
}
