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
            AboveEighteenAccountBuilder myAccountBuilder = new AboveEighteenAccountBuilder();
            AboveEighteenAccount myAccount = myAccountBuilder.BuildAccount("Silver", "Gold");
            Console.WriteLine(myAccount.silverDebitCard.CheckDebit());
            Console.WriteLine(myAccount.goldCreditCard.CheckCredit());
            Console.ReadLine();
        }
    }
}
