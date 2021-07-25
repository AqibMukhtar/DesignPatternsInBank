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
            AboveEighteenAccount myAccount = myAccountBuilder.BuildAccount("Gold", "Gold");

            EBayPurchase ebay = new EBayPurchase();

            myAccount.goldCreditCard.InternationalTransaction(ebay);

            Console.ReadLine();
        }
    }
}
