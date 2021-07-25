using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SilverCard : BankCard
    {
        public DebitCard CreateDebitCard()
        {
            return new SilverDebitCard();
        }

        public CreditCard CreateCreditCard()
        {
            return new SilverCreditCard();
        }
    }
}
