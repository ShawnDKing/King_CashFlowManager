using System;
// Shawn King
// IT112 

// NOTES: I finally got all of the unsent/pushed stuff erased on GitHub.
// I went back through the phone program, and also looked at
// the GitHub programs that the other students sent you. 
//Once I saw where I made mistakes it was pretty obvious what I should have done.
//One of the worst parts for me is not seing how a problem might be
//solved in the way you want it done, and then tripping along as I piece it together and learn it myself.
//Hopefully this one is much better. I did recieve the Gang of Four book tonight in the mail,
//and will continue to work on learning those designs this Summer since I will have much more time.

// BEHAVIORS NOT IMPLEMENTED AND WHY: Are there any parts of the assignment 
// you did not complete?

// I did not get to finish the choice 4 on the program. I think I have 
// the GetPayAmount part of that big equation. Because I thought there was no way
// to graduate I wasn't pushing as fast as I could have. I did almost this entire program 
// in two days. I am cutting it a couple hours short because I started falling asleep after staying up most
// of the night getting this much done. I did see how Jace and Rayleen were doing their CashFlowManager programs; after you having me look up their RoboDialer ones against mine. 
// Trying to cross-reference syntax from them and StackOverflow, to build mine, just confused me even more I think. 
// I really have to start back with more smaller OOP programs and slowly build up.
// I am not sure if when I go through a for loop to add the new Invoice or Employees if I am doing so correctly.
// To even ask questions, like "Ok, I have this. Now, to get the NEW employee into the array is this how to do it".
// An analogy would be: You are given a box of puzzle pieces, and a picture of what it is supposed to be. 
// Half way through, someone asks, "Do you have any questions?". I know what the puzzle is supposed to look like, and I also know 
// that there are 'concepts for putting the puzzle together', but I haven't finished laying the pieces out to ask,
// "Is this supposed to go here, or am I trying to force this somehow?", because I haven't seen someone put THAT puzzle together.
// I think I finally figured out how to use random in this context, but again it's not like you did it in the lecture. 
// I think I learn better watching how someone else would solve this, and then have a btter idea. I think of it very much like cooking.
// "Here's how to cook spaghetti noodles. Here is how to grate parmesan. This is how to prep a chicken breast a few different ways. Now, make me sundried tomato, basil, ricotta, thyme stuffed chicken parmagiana with parmesan crisps for 4 under $20 and here's a cookbook in Russian to work from".
// I was still also figuring out if the methods for ToString() to print out each LedgerType was correctly done and would be seemless when asking them to be printed out (bringing them together through the program). One issue I find is, as I am putting the pieces together It's like building a bridge from two different sides at the same time..but without a GPS to make sure that it comes together at the same point. As I work on one side the other gets way off track, and then I start messing with it. 
//Each class has syntax issues that I was working on; the workign on two side of the bridge at the same time scenario. I am far from done with this program now that it has me trying to figure out how to make it work.

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



            Random r = new Random(DateTime.Now.Millisecond);
           
        
            IPayable[] payables = new IPayable[20];
            payables[0] = new SalariedEmployee("John", "Smith", "111-11-1111", SalariedEmployee, 800.50m); 
            payables[1] = new SalariedEmployee("Susan", "Matthews", "222-22-2222", SalariedEmployee, 1100m);
            payables[2] = new HourlyEmployee("Karen", "Williams", "444-44-4444", HourlyEmployee, 16.75m, 40);
            payables[3] = new HourlyEmployee("Carol", "Walsh", "333-33-3333", HourlyEmployee, 19.50m, 42);
            payables[4] = new Invoice(r.Next(000000) + "_" + r.Next(0000), "Flux Capacitor", "2", 3655.66m, 7311.32m, Invoice);
            payables[5] = new Invoice(r.Next(000000) + "_" + r.Next(0000), "Flux Capacitor", "3", 14.50m, 43.50m, Invoice);


            Console.WriteLine("Welcome to CashFlow Manager");
            Console.WriteLine("Press 1 to add a Salaried Employee");
            Console.WriteLine("Press 2 to add an Hourly Employee");
            Console.WriteLine("Press 3 to Add an invoice");
            Console.WriteLine("Press 4 to end the program and get totals");
            Console.WriteLine("press 5 to exit");
            choice = Console.ReadLine();
            
           while (choice != 5)
           {
                if (choice == 1)
                {
                    for (int i=0; i < payables.Length;i++)
                    {
                    IPayable[] payables = new IPayable[i];
                    Console.WriteLine("Please enter the first name:");
                    _firstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name: ");
                    _lastName = Console.ReadLine();
                    Console.WriteLine("Please enter the Social Security Number: ");
                    _ssn.ToString() = Console.ReadLine();
                    Console.WriteLine("Please enter the weekly salary: );
                    _salary.ToString() = Console.ReadLine();
                    return payables[i];
                    }
                }

                if (choice == 2)
                { 
                    for (int i=0; i < payables.Length;i++)
                    {
                    IPayable[] payables = new IPayable[i];
                    Console.WriteLine("Please enter the first name:");
                    _firstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name: ");
                    _lastName = Console.ReadLine();
                    Console.WriteLine("Please enter the Social Security Number: ");
                    _ssn.ToString() = Console.ReadLine();
                    Console.WriteLine("Please enter the hourly pay: );
                    _hourlyPay.ToString() = Console.ReadLine();
                        return payables[i];
                    }
                }

                if (choice == 3)
                {
                    for (int i=0; i < payables.Length;i++)
                    {
                    IPayable[] payables = new IPayable[i];
                    Console.WriteLine("Please enter the part type:");
                    _partType = Console.ReadLine();
                    Console.WriteLine("Please enter the quantity(example: 3): ");
                    _amount = Console.ReadLine();
                    Console.WriteLine("Please enter the price(example: 9.99): ");
                    _price.ToString() = Console.ReadLine();
                    Console.WriteLine("Please enter the hourly pay(example: 22.65): ");
                    _hourlyPay.ToString() = Console.ReadLine();
                    return payables[i];
                    }
                }

                if (choice == 4)
                {

                    for (int i=0; i < payables.Length; i++)
                    {                        
                        Console.Clear();
                        Console.WriteLine("Weekly Cash FLow Analysis is as follows: \n");
                        Console.WriteLine()

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
