using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_CashFlowManager
{
    interface IPayable
    {
        decimal GetPayAmount
        {
            get;
        }
        string LedgerType
        {
            get;
        }
    }
}
