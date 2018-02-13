using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Program                                                           //properties and methdods are contained in classes 
    {
        static void Main(string[] args)                                     // operating enviroment looks for this method to start running the program
        {
            
            Account acct1 = new Account();                                  // using the Account type unboxing the Account type--when using class as type use this format
            acct1.Id = 1;
            acct1.Description = "My first checking account!!";
            acct1.Balance = 0.0;
            acct1.Owner = new Customer(100, "Greg Doud");
            Console.WriteLine(acct1.ToPrint());


            acct1.Deposit(5.00);
            Console.WriteLine(acct1.ToPrint());

            acct1.Deposit(-5);
            Console.WriteLine(acct1.ToPrint());



            acct1.Withdraw(5000.00);
            Console.WriteLine(acct1.ToPrint());

            Savings sav2 = new Savings();
            sav2.Id = 2;
            sav2.Description = " My first savings acct";
            sav2.Balance = 0.0;
            sav2.Owner = new Customer(101, "Lisa S");
            sav2.IntRate = .12;

            sav2.Deposit(1000.00);

            Console.WriteLine(sav2.ToPrint());

            Checking ck1 = new Checking();
            ck1.Id = 77;
            ck1.Description = "Another Checking";
            ck1.Balance = 1200.00;
            ck1.Owner = new Customer(102, "Marty B");

            ck1.Deposit(2000);
            Console.WriteLine(ck1.ToPrint());



            Checking ck3 = new Checking();
            ck3.Id = 3;
            ck3.Description = "Another Checking";
            ck3.Balance = 1200.00;
            ck3.Owner = new Customer(102, "Nate B");

            ck3.Deposit(2000);
            Console.WriteLine(ck1.ToPrint());





            Checking ck2 = new Checking();
            ck2.Id = 400;
            ck2.Description = "Another Checking";
            ck2.Balance = 1200.00;
            ck2.Owner = new Customer(103, "Nate B");

            ck2.Deposit(2000);
            Console.WriteLine(ck2.ToPrint());

            Savings sav = new Savings();
            sav.Id = 2;
            sav.Description = " My first savings acct";
            sav.Balance = 0.0;
            sav.Owner = new Customer(108, "Nate B");
            sav.IntRate = .12;

            sav.Deposit(1000.00);

            Account[] accounts = {sav, ck2, ck3};

            double GrandTotal = 0;

            foreach (Account account in accounts)
            {
                double AcctBalance = account.GetBalance();
                GrandTotal = GrandTotal + account.Balance;
                Console.WriteLine(account.ToPrint());
            }


            Console.WriteLine("Grand total is " + GrandTotal.ToString());

            Investment inv = new Investment();
            inv.Deposit(1000.00);
            Console.WriteLine();




            Console.ReadLine();

            



        }
    }
}
