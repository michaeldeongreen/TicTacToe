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
        public string Status { get { return ToString(); } }

        public TicTacToeResult(GameResultType type, string winnerName, string winningCoordinates)
        {
            Type = type;
            WinnerName = winnerName;
            WinningCoordinates = winningCoordinates;
        }

        public override string ToString()
        {
            string status = string.Empty;

            switch (Type)
            {
                case GameResultType.Winner:
                    status = string.Format("User {0} has won by choosing the coordinates {1}.  ", WinnerName, WinningCoordinates);
                    break;
                case GameResultType.NoWinner:
                    status = "The game does not have a winner yet.";
                    break;
                case GameResultType.Deadlock:
                    status = "The game is deadlocked.  Please start a new game.";
                    break;
            }
            return status;
        }
    }
}
