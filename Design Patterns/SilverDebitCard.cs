using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SilverDebitCard : DebitCard
    {
        public int CheckDebit()
        {
            Console.WriteLine("Checking Debit for Silver Card");
            return 100;
        }

        public int CheckDebitLimit()
        {
            Console.WriteLine("Checking Debit Limit for Silver Card");
            return 500;
        }
    }
}
