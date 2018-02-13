using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    public class Savings : Account 
    {
        public double IntRate { get; set; }


        public void CalcAndDeposit(int months)
        {
            double Interest = Balance * (IntRate / 12) * months;
            Deposit(Interest);
        }
        public override string ToPrint()
        {
            string message = base.ToPrint();
            return message + "," + "IntRate = " + IntRate.ToString();
        }
    }

}
