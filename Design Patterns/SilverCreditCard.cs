using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SilverCreditCard : CreditCard, Transaction
    {
        LinkedList<Observer> transactionObservers = new LinkedList<Observer>();

        public int CheckCredit()
        {
            Console.WriteLine("Checking Credit for Silver Card");
            return 10;
        }

        public int CheckCreditLimit()
        {
            Console.WriteLine("Checking Credit Limit for Silver Card");
            return 200;
        }

        public void MakeTransaction()
        {
            Console.WriteLine("Transaction has been made from Silver Credit Card");
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
    }
}
