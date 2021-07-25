using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            UnderEighteenAccountBuilder myAccountBuilder = new UnderEighteenAccountBuilder();
            UnderEighteenAccount myAccount = myAccountBuilder.BuildAccount("Silver", "Gold");
            Console.WriteLine(myAccount.silverDebitCard.CheckDebit());
            Console.WriteLine(myAccount.goldCreditCard.CheckCredit());
            Console.ReadLine();
        }
    }
}
