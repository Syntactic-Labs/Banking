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
            try
            {
                sav2.Print();
                sav2.Deposit(5000);
                sav2.Withdraw(6000);    //currently not enough money in account to InsufficiantFundsException aka Make more Money happens
                sav2.CalculateAndPayIntrest(1);
                sav2.Print();
            }
            catch (AmmountGreaterThanZeroException)
            {
                Console.WriteLine($"you messed up!");
            }
            catch (InsufficiantFundsException ex)     //ex is a var for InsufficiantFundsException
            {
                Console.WriteLine($"Make more Money");
                Console.WriteLine($"Current balance is {ex.CurrentBalance}");      //pulling CurrentBalance from InsufficiantFundsException
                Console.WriteLine($"Ammount to withdraw is {ex.AmountToWithdraw}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Loser!!");
            }





            //=========================================================================================================================================================================================


            //var n = 1;
            //var d = 0;
            //try                                                      //!!!try | catch block example!!!
            //{
            //    var x = n / d;                                       //statement we are trying
            //} 
            //catch (DivideByZeroException)                            //the error we are looking for
            //{
            //    Console.WriteLine("Divide by zero voided!");         //what will be done if the specified error happens
            //}
            //finally                                                  //rarely used. will probably never use it. in the past it ended the statement.
            //{

            //}


            //=======================================================================================================================================================================================




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
