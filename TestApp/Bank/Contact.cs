using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Contact
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        protected List<BankAccount> accounts;

        //public BankAccount Account { get; set; }

        public double Balance
        {
            get
            {

                //var res = (from c in accounts
                //          where c.Balance > 1000
                //          select c)


                return accounts.Sum(c => c.Balance);

                //double balance = 0;

                //foreach (var acc in accounts)
                //{
                //    balance += acc.Balance;
                //}

                //return balance;
            }
        }

        public Contact(string id, string name, string email, string address, string phoneNumber, string accountId, double initialBalance)
        {
            this.Id = id;
            this.FullName = name;
            this.EmailAddress = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;

            this.accounts = new List<BankAccount>();
            CreateBankAccount(accountId, initialBalance, BankAccountType.Savings);
        }

        //HACK: este no es el mejor lugar para esto.
        public void CreateBankAccount(string id, double initialBalance, BankAccountType type)
        {
            this.accounts.Add(new BankAccount(id, initialBalance, type));

        }

        public void Deposit(string id, double amount)
        {
            BankAccount acc = this.accounts.Where(c => c.AccountNumber == id).FirstOrDefault();

            if (acc != null)
            {
                acc.Deposit(amount);
            }
        }

        public bool Withdrawl(string id, double amount)
        {
            BankAccount acc = this.accounts.Where(c => c.AccountNumber == id).FirstOrDefault();

            if (acc != null)
            {
                return acc.Withdrawl(amount);
            }
            else
                return false;
        }
    }
}
