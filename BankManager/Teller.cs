using System.Collections.Generic;
using System.Linq;

namespace BankManager
{
    public class Teller
    {
        readonly List<int> _transactions = new List<int>();
        public int CheckBalance()
        {
            return _transactions.Sum();
        }

        public int ProcessTransaction(int amount)
        {
            _transactions.Add(amount);
            return CheckBalance();
        }
    }
}
