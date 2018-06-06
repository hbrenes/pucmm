using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        
        protected double balance;
        public double Balance
        {
            get { return this.balance; }
        }
        public DateTime CreationDate { get; set; }
        public BankAccountType Type { get; set; }

        public BankAccount(string accountNumber, double initialBalance, BankAccountType type)
        {
            this.AccountNumber = accountNumber;
            this.balance = initialBalance;
            this.CreationDate = DateTime.Now;
            this.Type = type;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        /// <summary>
        /// Withdrawls the amount specified. returns false if there are no funds.
        /// </summary>
        /// <param name="amount">Amount to withdrawl</param>
        /// <returns>returns false if there are no funds</returns>
        public bool Withdrawl(double amount)
        {
            if (amount > this.Balance)
            {
                return false;
            }
            this.balance -= amount;
            return true;
        }
    }
}
