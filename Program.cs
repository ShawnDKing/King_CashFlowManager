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
            string _firstName;
            string _lastName;
            string _ssn;
            decimal _salary;
            decimal _hourlyPay;
            string _partType;
            string _amount;
            int choice;
            decimal _price;
            decimal _totalAMount;


            Random r = new Random(DateTime).Next;
           
        
            IPayable[] payables = new IPayable[20];
            payables[0] = new SalariedEmployee("John", "Smith", "111-11-1111", SalariedEmployee, 800.50m); 
            payables[1] = new SalariedEmployee("Susan", "Matthews", "222-22-2222", SalariedEmployee, 1100m);
            payables[2] = new HourlyEmployee("Karen", "Williams", "444-44-4444", HourlyEmployee, 16.75m, 40);
            payables[3] = new HourlyEmployee("Carol", "Walsh", "333-33-3333", HourlyEmployee, 19.50m, 42);
            payables[4] = new Invoice(r.Next(000000)"_"r.Next(0000), "Flux Capacitor", "2", 3655.66m, 7311.32m, Invoice);
            payables[5] = new Invoice(r.Next(000000)"_"r.Next(0000), "Flux Capacitor", "3", 14.50m, 43.50m, Invoice);


            Console.WriteLine("Welcome to CashFlow Manager")Console.WriteLine("Welcome to CashFlow Manager");
            Console.WriteLine("Press 1 to add a Salaried Employee");
            Console.WriteLine("Press 2 to add an Hourly Employee");
            Console.WriteLine("Press 3 to Add an invoice");
            Console.WriteLine("Press 4 to end the program and get totals");
            Console.WriteLine("press 5 to continue");
            choice = Console.ReadLine();
            
           while (choice == 5)
           {
                if (choice == 1)
                {
                    for (int i=0; i < payables.Length;i++)
                    {
                    Console.WriteLine("Please enter the first name:");
                    _firstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name: ");
                    _lastName = Console.ReadLine();
                    Console.WriteLine("Please enter the Social Security Number: ");
                    _ssn.ToString() = Console.ReadLine();
                    Console.WriteLine("Please enter the weekly salary: );
                    _salary.ToString() = Console.ReadLine();
                    return payables[i]Ledger.LedgerType.Salaried;
                    }
                }

                if (choice == 2)
                { 
                    for (int i=0; i < payables.Length;i++)
                    {
                    Console.WriteLine("Please enter the first name:");
                    _firstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name: ");
                    _lastName = Console.ReadLine();
                    Console.WriteLine("Please enter the Social Security Number: ");
                    _ssn.ToString() = Console.ReadLine();
                    Console.WriteLine("Please enter the hourly pay: );
                    _hourlyPay.ToString() = Console.ReadLine();
                    return payables[i]Ledger.LedgerType.Hourly;
                    }
                }

                if (choice == 3)
                {
                    for (int i=0; i < payables.Length;i++)
                    {
                    Console.WriteLine("Please enter the part type:");
                    _partType = Console.ReadLine();
                    Console.WriteLine("Please enter the quantity(example: 3): ");
                    _amount = Console.ReadLine();
                    Console.WriteLine("Please enter the price(example: 9.99): ");
                    _price.ToString() = Console.ReadLine();
                    Console.WriteLine("Please enter the hourly pay: );
                    _hourlyPay.ToString() = Console.ReadLine();
                    return payables[i]Ledger.LedgerType.Invoice;
                    }

                    if (choice == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Total Weekly Payout: " );
                        Console.WriteLine("\n");
                        Console.WriteLine("Category Breakdown: ");
                        Console.WriteLine("\tInvoices: ");
                        Console.WriteLine("\tSalaried Payroll: ");
                        Console.WriteLine("\tHourly Payroll: ");  
                    }
                }
           }      
        }
    }
}
