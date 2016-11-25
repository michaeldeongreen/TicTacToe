using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic.Tac.Toe.App.Services
{
    public static class Enumerations
    {
        public enum ResultType
        {
            Winner = 1,
            NoWinner = 2,
            Deadlock = 3
        }
    }
}
