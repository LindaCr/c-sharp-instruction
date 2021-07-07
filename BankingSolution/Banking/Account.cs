using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {

        private static int NextId = 1;
        public int Id { get; protected set; }
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;

        public Account()
        {
            Id = NextId++;
        }


        public static void Transfer(decimal Amount, Account FromAccount, Account ToAccount)
        {
            FromAccount.Withdraw(Amount);
            ToAccount.Deposit(Amount);
        }

        public void Deposit(decimal Amount)
        {
           if (Amount <= 0)
            {
                throw new Exception("Amount must be positive.");
            }
            Balance += Amount;
        }

        public virtual void Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new Exception("Amount must be positive");
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficient funds!");
                return;
            }
            Balance -= Amount;
        }




    }
}
