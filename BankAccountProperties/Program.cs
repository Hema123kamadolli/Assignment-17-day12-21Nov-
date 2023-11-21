using System;
 


//Part-1
namespace BankAccountProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the BankAccount class
            BankAccount myAccount = new BankAccount("Mohan");

            // Displaying initial account details
            Console.WriteLine("Initial Account Details:");
            myAccount.DisplayAccountDetails();

            // Making some transactions
            myAccount.Deposit(5000);
            myAccount.Withdraw(500);

            // Displaying updated account details
            Console.WriteLine("Updated Account Details:");
            myAccount.DisplayAccountDetails();

            Console.ReadKey();
        }
      
    }
}
