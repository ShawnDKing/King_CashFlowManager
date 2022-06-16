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


        public SalariedEmployee( string FirstName, string LastName, string SSN, LedgerType type, decimal HourlyPay, int HoursWorked) : base (FirstName, LastName, SSN)
        {
            _firstName = FirstName;
            _lastname = LastName;
            _ssn = SSN;
            _hourlyPay = HourlyPay;
            _hoursWorked = HoursWorked;

            switch(_hoursWorked)
            {
                case <=40:
                    _totalAmt = _hourlyPay * _hoursWorked;
                    break;
                case > 40:
                    int _overTime = _hoursWorked - 40;
                    _totalAmt = _hourlyPay * 40;
                    _totalAmt += _overTime *(_hourlyPay * 1.5m);
                    break;
            }
            FinalAmount(_totalAmt);

        }

        //public enum LedgerType
        //{
            //Salaried,
            //Hourly,
            //Invoice
        //}

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
            return type + " employee: " + _firstName + " " + _lastName + "\n" + "SSN: " + _ssn  + "\n" + "Hourly Wage Salary: " + _hourlyPay.ToString("C") + _hoursWorked + "\n" + "Earned: " + _totalAmt.ToString("C") + "\n";
        }


    }
}
