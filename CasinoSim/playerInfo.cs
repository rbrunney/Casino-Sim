using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSim
{
    class PlayerInfo
    {
        public string Name { get; set; }
        public int BankAmount { get; set; }
        public int ChipAmount { get; set; }

        public PlayerInfo(string name, int bankAmount)
        {
            Name = name;
            BankAmount = bankAmount;
            ChipAmount = 0;
        }
    }
}
