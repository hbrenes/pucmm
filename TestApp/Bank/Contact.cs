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
        public BankAccount Account { get; set; }

        public double Balance
        {
            get { return Account.Balance; }
        }

        public Contact(string id, string name, string email, string address, string phoneNumber, string accountId, double initialBalance)
        {
            this.Id = id;
            this.FullName = name;
            this.EmailAddress = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;

            this.Account = new BankAccount(accountId, initialBalance, BankAccountType.Savings);
        }



    }
}
