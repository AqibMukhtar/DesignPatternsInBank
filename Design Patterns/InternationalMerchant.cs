using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface InternationalMerchant
    {
        float ConvertRupeeToDollar(int amountInRupee);
        bool CheckGateway();
        bool CheckTaxation();
        void DeductAmount();
    }
}
