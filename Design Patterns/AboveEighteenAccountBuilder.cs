using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class AboveEighteenAccountBuilder : AccountBuilder
    {
        public bool VerifyIdentity()
        {
            Console.WriteLine("Identity verified for above eighteen customer");
            return true;
        }

        public DebitCard CreateBankDebitCard(BankCard bc)
        {
            Console.WriteLine("Debit Card created");
            return bc.CreateDebitCard();
        }

        public CreditCard CreateBankCreditCard(BankCard bc)
        {
            Console.WriteLine("Credit Card created");
            return bc.CreateCreditCard();
        }

        public AboveEighteenAccount BuildAccount(string debitCardType, string creditCardType)
        {
            AboveEighteenAccount account = new AboveEighteenAccount();
            SilverCard sc = new SilverCard();
            GoldCard gc = new GoldCard();

            if (VerifyIdentity() != true) throw new Exception();
            if (debitCardType == "Silver")
                account.silverDebitCard = (SilverDebitCard)CreateBankDebitCard(sc);
            else if (debitCardType == "Gold")
                account.goldDebitCard = (GoldDebitCard)CreateBankDebitCard(gc);
            if (creditCardType == "Silver")
                account.silverCreditCard = (SilverCreditCard)CreateBankCreditCard(sc);
            else if (creditCardType == "Gold")
                account.goldCreditCard = (GoldCreditCard)CreateBankCreditCard(gc);

            return account;
        }

    }
}
