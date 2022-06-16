using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_CashFlowManager
{
    public class Employee : IPayable
    {
        private decimal _totalAmt;
        private string _firstName;
        private string _lastName;
        private string _ssn;
    


        public Employee( string FirstName, string LastName, string SSN, LedgerType Type)
        {
            _firstName = FirstName;
            _lastname = LastName;
            _ssn = SSN;
        
        }

        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }

        public string FirstName
        {
            get;
        }

        public string LastName
        { 
            get;
        }

        public string SSN
        {
            get;
        }

        public LedgerType type 
        {
            get;
        }

        public decimal GetPayAmount()
        {
            return _totalAmt;
        }

        protected void FinalAmount (decimal total)
        {
             _totalAmt = total;
        }

        public string ToString()
        {
            return LedgerType(type);
        }

       

    }
    
}
