using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class GoldCreditCard : CreditCard, Transaction
    {
        LinkedList<Observer> transactionObservers = new LinkedList<Observer>();

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

        public void MakeTransaction()
        {
            Console.WriteLine("Transaction has been made from Gold Credit Card");
        }

        public void Notify()
        {
            foreach (Observer transactionObserver in transactionObservers)
            {
                transactionObserver.Update();
            }
        }
        public void AddObserver(Observer observer)
        {
            transactionObservers.AddLast(observer);
            Console.WriteLine("New Observer has been added");
        }
        public void RemoveObserver(Observer observer)
        {
            transactionObservers.Remove(observer);
            Console.WriteLine("An observer has been removed");
        }

        public void InternationalTransaction(InternationalMerchant merchant)
        {
            if (merchant.CheckGateway() && merchant.CheckTaxation())
            {
                merchant.ConvertRupeeToDollar(1500);
                merchant.DeductAmount();
            }
            else
                throw new Exception("Transaction for Amazon failed");
        }
    }
}
