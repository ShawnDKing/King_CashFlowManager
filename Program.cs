using System;
// Shawn King
// IT112 

// NOTES: I finally got all of the unsent/pushed stuff erased on GitHub.
// I went back through the phone program, and also looked at the GitHub programs that the other students sent you. 
//Once I saw where I made mistakes it was pretty obvious what I should have done.
//One of the worst parts for me is not seing how a problem might be solved in the way you want it done, and then tripping along as I piece it together.
//Hopefully this one is much better. I did recieve the Gang of Four book tonight in the mail, and will continue to work on learning those designs this Summer since I will have much more time.

// BEHAVIORS NOT IMPLEMENTED AND WHY: Are there any parts of the assignment 
// you did not complete?

namespace King_CashFlowManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize 
            private string _firstName;
            private string _lastName;
            private string _ssn;
            private string _salary;
            private bool _continue = true;
            private bool _toTryParse;
            private string _choice;


            System.Random random = new System.Random();      
            IPayable[] payables = new IPayable[10];
            payables[0] = new SalariedEmployee("John", "Smith", "111-11-1111", Ledger.LedgerType, 800.50m); 
            payables[1] = new SalariedEmployee("Susan", "Matthews", "222-22-2222", Ledger.LedgerType, 1100m);
            payables[2] = new HourlyEmployee("Karen", "Williams", "444-44-4444", Ledger.LedgerType, 16.75m, 40);
            payables[3] = new HourlyEmployee("Carol", "Walsh", "333-33-3333", Ledger.LedgerType, 19.50m, 42
            payables[4] = new Invoice.LedgerType(Console.WriteLine Random.Next(6) + "_" + Random.Next(4));
            payables[5] = new Invoice.(Console.WriteLine( Random.Next(0,10) + "_" + Random.Next(0,10));
            

            // rando console writeline System.Console.WriteLine(random.Next(10,50));
            //next is user initiated data to be introduced into the array and printed.

            Console.WriteLine("Weekly Cash Flow Analysis is as follows: ");
        }
    }
}
