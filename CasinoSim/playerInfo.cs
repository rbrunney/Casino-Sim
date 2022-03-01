using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSim
{
    class PlayerInfo
    {

        private string name;
        private int bankAmount;
        private int chipAmount;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int BankAmount
        {
            get { return bankAmount;  }
            set { bankAmount = value; }
        }

        public int ChipAmount
        {
            get { return chipAmount; }
            set { chipAmount = value; }
        }
    }
}
