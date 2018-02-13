using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    public class Account
    {
     //properties
            public int Id { get; set; }
            public Customer Owner { get; set; }
            public string Description { get; set; }
            public double Balance { get; set; }
    //methods
            public void Deposit(double amount)
        {
           if(!IsAmountNegative(amount))
            {
            
                Balance = Balance + amount;
            }
            //if (amount < 0)                                                                    I created a new method that calls this action so I dont duplicate code
            //{
            //    Console.WriteLine("Amount cannot be negative");
            //    return;
            //}
                                                                    //assignment statement --single equalsign is an assignment 
        }
            public void Withdraw(double amount)
        {
            IsAmountNegative(amount);

            if (amount > Balance)
            {
                Console.WriteLine("Insuffucient Funds");
                return;
            }
            if (!IsAmountNegative(amount))
            {

                Balance = Balance + amount;
            }
            
            
        }
            public double GetBalance()
        {
            return Balance;
        }
        private bool IsAmountNegative(double amount)
        {
             if (amount < 0)
            {
                Console.WriteLine("Amount cannot be negative");
                return true;
            }
            return false;
        }
    }
}
