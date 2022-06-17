using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_CashFlowManager
{
    public class HourlyEmployee : Employee
    {
        
        private string _firstName;
        private string _lastName;
        private string _ssn;
        private decimal _totalAmt;
        private decimal _hourlyPay;
        private int _hoursWorked;

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
            get { return LedgerType.Hourly; }
        }

        public HourlyEmployee( string FirstName, string LastName, string SSN, LedgerType Type, decimal HourlyPay, int HoursWorked) : base (FirstName, LastName, SSN)
        {
            _firstName = FirstName;
            _lastname = LastName;
            _ssn = SSN;
            _hourlyPay = HourlyPay;
            _hoursWorked = HoursWorked;
            _type = Type;
        }

        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }

        decimal GetPayAmount(decimal HourlyPay, int HoursWorked)
        {   
             if (_hoursWorked <= 40)
             {
             _totalAmt += _hoursWorked * _hourlyPay;
             return _totalAmt;
             }
             else (_hoursWorked > 40)
             {
             _totalAmt += _hoursWorked * (_hourlyPay * 1.5);
             return _totalAmt;
             }
        }
     
        public override string ToString()
        {
            return _type + " employee: " + _firstName + " " + _lastName + "\n" + "SSN: " + _ssn  + "\n" + "Hourly Wage Salary: " + "$" + _hourlyPay.ToString("C") + _hoursWorked + "\n" + "Earned: " + "$" + _totalAmt.ToString("C") + "\n";
        }


    }
}
