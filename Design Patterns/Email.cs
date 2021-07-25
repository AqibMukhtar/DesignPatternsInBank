using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class EmailNotifier : Observer
    {
        public void Update()
        {
            Console.WriteLine("Email Observer has been updated");
        }
    }
}
