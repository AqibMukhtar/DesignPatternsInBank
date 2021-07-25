using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface AccountBuilder
    {
        bool VerifyIdentity();
        DebitCard CreateBankDebitCard(BankCard bc);
        CreditCard CreateBankCreditCard(BankCard bc);
      
    }
}
