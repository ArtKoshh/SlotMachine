using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotmachine
{
    internal class BankAccount
    {
        public string Owner { get; }
        public decimal Saldo { get; private set; }
        public BankAccount(string owner, decimal initialSaldo)
        {
            Owner = owner;
            Saldo = initialSaldo;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("");

            Saldo += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Saldo)
                throw new InvalidOperationException(
                    "You don't have enough fund, you poor soul");

            Saldo -= amount;
        }
        public void Transfer(decimal amount, BankAccount other)
        {
            Withdraw(amount);
            other.Deposit(amount);
        }

    }

}
