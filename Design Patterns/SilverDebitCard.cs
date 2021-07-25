using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SilverDebitCard : DebitCard, Transaction
    {
        LinkedList<Observer> transactionObservers = new LinkedList<Observer>();
        public int CheckDebit()
        {
            Console.WriteLine("Checking Debit for Silver Card");
            return 100;
        }

        public int CheckDebitLimit()
        {
            Console.WriteLine("Checking Debit Limit for Silver Card");
            return 500;
        }

        public void MakeTransaction()
        {
            Console.WriteLine("Transaction has been made from Silver Debit Card");
        }

        public void Notify()
        {
            foreach(Observer transactionObserver in transactionObservers)
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
