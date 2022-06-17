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
            get;
        }

        public decimal GetPayAmount(decimal total)
        {
            _totalAmt = total;
            return total;
            
        }

        public string ToString()
        {
            
        }

       

    }
    
}
