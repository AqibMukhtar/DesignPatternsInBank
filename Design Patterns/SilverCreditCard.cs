using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SilverCreditCard : CreditCard
    {
        public int CheckCredit()
        {
            Console.WriteLine("Checking Credit for Silver Card");
            return 10;
        }

        public int CheckCreditLimit()
        {
            Console.WriteLine("Checking Credit Limit for Silver Card");
            return 200;
        }
    }
}
