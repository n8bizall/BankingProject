using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    public class Investment
    {
        public Account account { get; set; }

        public void Deposit(double amount)
        {
            account.Deposit(amount);
        }
        public void Withdraw(double amount)
        {
            account.Withdraw(amount);

        }
        public double GetBalance() => account.GetBalance();
        public Investment()
        {
            account = new Account();

            account.Id = 1000;
            account.Description = "My first Investment ACCT";
            account.Balance = 0.0;
            account.Owner = new Customer(111, "Dave D.");

        }
        public string ToPrint()
        {
            string message = account.ToPrint();
            return message + ", investment account";
        }
    }
}
