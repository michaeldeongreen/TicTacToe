using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic.Tac.Toe.App.Services
{
    internal class DirectionResult
    {
        public int PlayerO { get; private set; }
        public int PlayerX { get; private set; }
        public string Coordinates { get { return _sbCoordinates.ToString().Trim(); } }
        public string Name { get; private set; }

        private StringBuilder _sbCoordinates;

        public DirectionResult()
        {
            _sbCoordinates = new StringBuilder();
        }

        internal void InspectBoardCoordinate(string coordinate, int row, int column)
        {
            if (string.IsNullOrEmpty(coordinate) != true)
            {
                if (coordinate == "O")
                    PlayerO++;
                else
                    PlayerX++;
            }
            _sbCoordinates.Append(string.Format("[{0},{1}] ", row, column));
        }

        internal bool IsThereAWinner()
        {
            if (PlayerO == 3 || PlayerX == 3)
            {
                Name = PlayerO == 3 ? "O" : "X";
                return true;
            }
            else
                return false;
        }
    }
}
