using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skat
{
    public class Player
    {
        public double Balance { get; set; }
        public string Name { get; private set; }

        public Player(string Name, double Balance)
        {
            if (Name == string.Empty)
                throw new ArgumentNullException("Choose a name");
            if (Balance < 0)
                throw new ArgumentOutOfRangeException("Balance is under 0");
            this.Balance = Balance;
            this.Name = Name;
        }

        public Player(string Name)
        {
            if (Name == string.Empty)
                throw new ArgumentNullException("Choose a name");
            this.Name = Name;
        }
    }
}
