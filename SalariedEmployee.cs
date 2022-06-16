using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_CashFlowManager
{
    public class SalariedEmployee : Employee
    { 
        private decimal _totalAmt;
        private string _firstName;
        private string _lastName;
        private string _ssn;
        private decimal _weeklySalary;

        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }
        
        public SalariedEmployee( string FirstName, string LastName, string SSN, LedgerType Type, decimal WeeklySalary) : base (FirstName, LastName, SSN)
        {
            _firstName = FirstName;
            _lastname = LastName;
            _ssn = SSN;
            _weeklySalary = WeeklySalary;
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

        public override string ToString()
        {
            return LedgerType.Salaried; 
        }
    }
}
