using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRollShare.Models
{
    public class DieRollArgs : EventArgs
    {
        public readonly int Result;
        public DieRollArgs(int result)
        {
            Result = result;
        }
    }
}
