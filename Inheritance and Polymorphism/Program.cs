using Inheritance_and_Polymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

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
            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance); // na conta comum sera cobrada uma taxa de 5.00
            //Console.WriteLine(acc2.Balance); // na conta SavingAccount não terá taxa
            #endregion


            #region Exercicio de Fixação

            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            List<Employee> employees = new List<Employee>(); // Lista de Employee que aceita o objeto Employee e o Objeto OutsourceEmployee

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Addictional charge: ");
                    double addictionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, addictionalCharge);
                    employees.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


            #endregion
        }
    }
}
