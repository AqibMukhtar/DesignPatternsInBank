using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class GoldCreditCard : CreditCard
    {
        public int CheckCredit()
        {
            Console.WriteLine("Checking Credit for Gold Card");
            return 50;
        }

        public int CheckCreditLimit()
        {
            Console.WriteLine("Checking Credit Limit for Gold Card");
            return 300;
        }
    }
}
