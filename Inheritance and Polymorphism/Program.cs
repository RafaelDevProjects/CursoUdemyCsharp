using Inheritance_and_Polymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Upcasting and Downcasting
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1002, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //// DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;

            //if (acc3 is BusinessAccount) // primeiro ele testa para ver se o acc3 é uma BusinessAccount para fazer a converção de Account para BusinessAccount
            //{
            //    BusinessAccount acc5 = (BusinessAccount)acc3;
            //    // BusinessAccount acc5 = acc3 as BusinessAccount; (OUTRA FORMA DE FAZER)
            //    acc5.Loan(100.00);
            //    Console.WriteLine("Loan!");

            //}

            //if (acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update");

            //}
            #endregion

            #region Superposition (Sobreposição)
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance); // na conta comum sera cobrada uma taxa de 5.00
            Console.WriteLine(acc2.Balance); // na conta SavingAccount não terá taxa
            #endregion
        }
    }
}
