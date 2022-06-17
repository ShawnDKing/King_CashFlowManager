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

        public Invoice(string PartNum, string PartType, int Amount, decimal Cost, LedgerType type)
        {
            _partNum = PartNum;
            _partType = PartType;
            _amount = Amount;
            _cost = Cost;
        }

        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }

        public decimal GetPayableAmount(decimal Cost)
        {
            _total = _cost + _cost;
            return _total;
        }

        public string PartNum
        {
            get {return _partNum;}
        }

        public string PartType
        {
            get  {return _partType;}
        }

        public decimal Cost
        {
            get { return _cost;}
        }
        public override string ToString()
        {
            return LedgerType + ": " + _partNum.ToString() + "\n" + "Quantity: " + _amount + "\n" +"Part Description" + "\n" + "Unit Price: " + "$" + _cost.ToString("C") + "\n" + "Extended Price: " + "$" +_total.ToString("C") + "\n";
        }
    }
}
