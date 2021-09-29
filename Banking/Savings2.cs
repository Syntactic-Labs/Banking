using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings2                                /*!!!This savings account is an example of Composition!!!*/
    {
        private Account account { get; set; }    //1a)creates account variable with a class type (complex)

        public int Id => account.Id;               //account value was assign in the construtor at the bottom
        public decimal Balance => account.Balance;
        public string Description
        {
            get { return account.Description; }
            set { account.Description = value; }
        }
        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayIntrest(int months)
        {
            var interest = this.account.Balance * (InterestRate / 12) * months;
            this.account.Deposit(interest);
            return interest;
        }
        public bool Deposit(decimal amount)
        {
            return this.account.Deposit(amount);
        }
        public bool Withdraw(decimal amount)
        {
            return this.account.Withdraw(amount);
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            return this.account.Transfer(amount, ToAccount);
        }
        public void Print()
        {
            this.account.Print();
        }

        public Savings2(int id)     //2a)lets you input and int id for your savings accounts
        {
            this.account = new Account();   //1b)Gives account the value of Account
            this.account.Id = id;          //2b)calls id in my console writeline
            this.account.Description = "New Savings 2";
            
        }
    }
}
