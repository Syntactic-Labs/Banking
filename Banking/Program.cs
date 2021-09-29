using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav2 = new Savings2(2000);
            sav2.Description = "Mike's Savings2";
            sav2.InterestRate = 0.12m;
            sav2.Print();
            sav2.Deposit(5000);
            sav2.Withdraw(2000);
            sav2.CalculateAndPayIntrest(1);
            sav2.Print();













            //var sav1 = new Savings()
            //{
            //    Id = 1000,
            //    Description = "My First Savings"
            //};
            //var acct1 = new Account()
            //{
            //    Id = 1, Description = "Account 1"
            //};
            //var acct2 = new Account()
            //{
            //    Id = 2,
            //    Description = "Account 2"
            //};
            //var acct3 = new Account()
            //{
            //    Id = 3,
            //    Description = "Account 3"
            //};
            //var acct4 = new Account()
            //{
            //    Id = 4,
            //    Description = "Account 4"
            //};
            //var acct5 = new Account()
            //{
            //    Id = 5,
            //    Description = "Account 5"
            //};
            //var acct6 = new Account()
            //{
            //    Id = 6,
            //    Description = "Account 6"
            //};
            //sav1.InterestRate = 0.12m;
            //sav1.Print();
            //sav1.Deposit(5000);
            //sav1.Withdraw(2000);
            //sav1.CalculateAndPayInterest(1);
            //sav1.Print();
        }
    }
}
