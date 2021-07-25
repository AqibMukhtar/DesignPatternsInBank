using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class EBayPurchase : InternationalMerchant
    {
        public float ConvertRupeeToDollar(int amountInRupee)
        {
            Console.WriteLine("Converting Dollar to Rupee @ 160/$");
            return amountInRupee / 160.00f;
        }

        public bool CheckGateway()
        {
            Console.WriteLine("Gateway is working for EBay");
            return true;
        }

        public bool CheckTaxation()
        {
            Console.WriteLine("Taxation has been verified by Ebay");
            return true;
        }

        public void DeductAmount()
        {
            Console.WriteLine("Amount in dollars has been deducted by Ebay");
        }
    }
}
