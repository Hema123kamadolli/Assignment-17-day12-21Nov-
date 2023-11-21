//PART-1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProperties
{
    public class BankAccount
    {
        // Properties
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private double Balance { get; set; }

        // Static variable to generate unique account numbers
        private static int nextAccountNumber = 10758001;

        // Constructor
        public  BankAccount(string accountHolderName)
        {
            AccountNumber = nextAccountNumber++;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine();
        }
    }
}

