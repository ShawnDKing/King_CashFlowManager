using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_CashFlowManager
{
    public class Invoice : IPayable 
    {
        private decimal _total;
        private string _partNum;
        private string _partType;
        private int _amount;
        private decimal _cost;

        public Invoice(string PartNum, string PartType, int Amount, decimal Cost, Ledgertype type)
        {
            _partNum = PartNum;
            _partType = PartType;
            _amount = Amount;
            _cost = Cost;
            _total = _cost * _amount;
        }

        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }

        public decimal GetPayableAmount()
        {
            return _total;
        }

        public string PartNum
        {
            get;
        }

        public string PartType
        {
            get;
        }

        public int PartType
        {
            get;
        }

        public decimal Cost
        {
            get;
        }
        public override string ToString()
        {
            return LedgerType + + ": " + _partNum.ToString() + "\n" + "Quantity: " + _amount + "\n" +"Part Description" + "\n" + "Unit Price: " + Cost.ToString() + "\n" + "Extended Price: " + _total.ToString() + "\n";
        }
    }
}
