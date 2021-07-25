using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface Transaction
    {
        void MakeTransaction();
        void Notify();
        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);

    }
}
