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

        
        public SalariedEmployee( string FirstName, string LastName, string SSN, LedgerType Type, decimal WeeklySalary) : base (FirstName, LastName, SSN)
        {
            _firstName = FirstName;
            _lastname = LastName;
            _ssn = SSN;
            _weeklySalary = WeeklySalary;
            _type = Type;
        } 
        
        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }

        public string FirstName
        {
            get { return _firstName;}
        }

        public string LastName
        { 
            get { return _lastName;};
        }

        public string SSN
        {
            get { return _ssn;}
        }

        string LedgerType
        {
            get { return LedgerType.Salaried; }
        }
        public decimal GetPayAmount(decimal WeeklySalary)
        {
            _totalAmt = Salary * 4;
            return _totalAmt *    
        }


        public override string ToString()
        {
            return LedgerType.Salaried + " employee: " + _firstName + " " + _lastName + "\n" + "SSN: " + _lastName + "\n" + "Weekly Salary: " + "$" + _weeklySalary.ToString("C") + "\n" + "Earned: " + "$"   _totalAmt.ToString("C") + "\n";
        }
    }
}
