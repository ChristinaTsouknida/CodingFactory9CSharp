using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Model
{
    internal class Account
    {
        public int Id { get; set; }

        public string? Iban { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Ssn { get; set; }

        public decimal Balance { get; set; }


        // Public API

        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new NegativeAmountException("Amount cannot be negative");
                }
                Balance += amount;

            }
            catch (NegativeAmountException e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }


        public void Withdraw(decimal amount, string? ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidssnException("SSN cannot be null or empty");
                if (ssn != Ssn) throw new InvalidssnException("SSN does not match account holder's SSN");
                if (amount < 0) throw new NegativeAmountException("Amount cannot be negative");
                if (amount > Balance) throw new InsufficientBalanceException("Insufficient balance for withdrawal");

                Balance -= amount;
            }
            catch (Exception e) when (e is NegativeAmountException or InsufficientBalanceException or InvalidssnException)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }



        public decimal GetBalance(string? ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidssnException("SSN cannot be null or empty");
                if (ssn != Ssn) throw new InvalidssnException("SSN does not match account holder's SSN");
                return Balance;
            }
            catch (InvalidssnException e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
        
    }
}
