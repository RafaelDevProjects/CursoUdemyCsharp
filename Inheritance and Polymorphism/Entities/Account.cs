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

        public void Withdraw(double Amount)
        {
            Balance -= Amount;
        }

        public void Deposit(double Amount)
        {
            Balance += Amount; 
        } 
    }
}
