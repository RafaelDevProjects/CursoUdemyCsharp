using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism.Entities
{
    internal class Account
    {
        public int Number { get; protected set; } // o protected serve para dar acesso apinas para as subclasses dentro e fora do assembly
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        virtual public void Withdraw(double amount) // usamos a palavra virtual para que esse método possa ser sobreposto em uma subclasse
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount; 
        } 
    }
}
