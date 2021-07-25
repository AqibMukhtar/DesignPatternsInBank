using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class AmazonPurchase : InternationalMerchant
    {
        public float ConvertRupeeToDollar(int amountInRupee)
        {
            Console.WriteLine("Converting Dollar to Rupee @ 150/$");
            return amountInRupee / 150.00f;
        }

        public bool CheckGateway()
        {
            Console.WriteLine("Gateway is working for Amazon");
            return true;
        }

        public bool CheckTaxation()
        {
            Console.WriteLine("Taxation has been verified by Amazon");
            return true;
        }

        public void DeductAmount()
        {
            Console.WriteLine("Amount in dollars has been deducted by Amazon");
        }
    }
}
