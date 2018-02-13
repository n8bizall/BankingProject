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

            acct1.Deposit(5.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + " should be five dollars");

            acct1.Deposit(-5);
            Console.WriteLine("The balance is " + acct1.GetBalance() + " should be zero");
            


            acct1.Withdraw(5000.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + " should be -4995");


            Console.ReadLine();



        }
    }
}
