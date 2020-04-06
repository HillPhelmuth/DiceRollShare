using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRollShare.Services
{
    public class DieRollService
    {
        public int Result => random.Next(1, 21);
        private Random random;
        public DieRollService()
        {
            random = new Random();
        }
    }
}
