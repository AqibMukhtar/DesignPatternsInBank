using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class GoldCard : BankCard
    {
        public DebitCard CreateDebitCard()
        {
            return new GoldDebitCard();
        }

        public CreditCard CreateCreditCard()
        {
            return new GoldCreditCard();
        }
    }
}
