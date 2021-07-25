using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class GoldDebitCard : DebitCard
    {
        public int CheckDebit()
        {
            Console.WriteLine("Checking Debit for Gold Card");
            return 0;
        }

        public int CheckDebitLimit()
        {
            Console.WriteLine("Checking Debit Limit for Gold Card");
            return 1000;
        }
    }
}
