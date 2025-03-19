using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept
{
    class EncapBankAccount
    {
        private decimal balance;

        public EncapBankAccount(decimal balance) {
            Deposit(balance);
        }

        public decimal GetBalance() {
            return balance;
        }

        public void Deposit(decimal amount) {
            if (amount <= 0) {
                throw new ArgumentException("Plase enter a valid amount");
            }
            this.balance = amount;
        }

        public void withdraw(decimal amount) {
            if(amount <= 0) {
                throw new ArgumentException("Withdrawl amount must be positive");
            }
            else if(amount > balance){
                throw new InvalidOperationException("Insufficient fund");
            }
            this.balance -= amount;
        }

    }
}
