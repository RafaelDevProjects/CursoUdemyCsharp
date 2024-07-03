using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism.Entities
{
    sealed internal class SavingsAccount : Account // o prefixo sealed não deixa essa classe ser herdada por outra
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // usamos a prefixo override para sobrescrever o método Withdraw da Super Classe
        {
            Balance -= amount;
        }

        // o prefixo sealed não deixa que o método seja sobrescrito novamente em outra classe



    }
}
