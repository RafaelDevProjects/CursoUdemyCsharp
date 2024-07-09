using Inheritance_and_Polymorphism.Entities;
using Inheritance_and_Polymorphism.Entities.Enums;
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

            #region Exercicio de Fixação 01

            //Console.Write("Enter the number of employees: ");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //List<Employee> employees = new List<Employee>(); // Lista de Employee que aceita o objeto Employee e o Objeto OutsourceEmployee

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"Employee #{i + 1} data: ");

            //    Console.Write("Outsourced (y/n)? ");
            //    char outsourced = char.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Hours: ");
            //    int hours = int.Parse(Console.ReadLine());
            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    if (outsourced == 'y')
            //    {
            //        Console.Write("Addictional charge: ");
            //        double addictionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, addictionalCharge);
            //        employees.Add(employee);
            //    }
            //    else
            //    {
            //        Employee employee = new Employee(name, hours, valuePerHour);
            //        employees.Add(employee);
            //    }

            //}

            //Console.WriteLine();
            //Console.WriteLine("PAYMENTS:");
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            //}


            #endregion

            #region Exercicio de Fixação 02
            //Console.Write("Enter the number of products: ");
            //int N = int.Parse(Console.ReadLine());

            //List<Product> products = new List<Product>();

            //for (int i = 0; i < N; i++) 
            //{
            //    Console.WriteLine($"Product #{i + 1} data: ");
            //    Console.Write("Common, used, imported (c/u/i): ");
            //    char productType = char.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string productName = Console.ReadLine();
            //    Console.Write("Price: ");
            //    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    if (productType == 'u')
            //    {
            //        Console.Write("Manufacture date (DD/MM/YYYY): ");
            //        DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //        Product product = new UsedProduct(productName, productPrice, manufactureDate);
            //        products.Add(product);
            //    }
            //    else if(productType == 'i')
            //    {
            //        Console.Write("Customs fee: ");
            //        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Product product = new ImportedProduct(productName, productPrice, customsFee);
            //        products.Add(product);
            //    }
            //    else
            //    {
            //        Product product = new Product(productName, productPrice);
            //        products.Add(product);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("PRICE TAGS");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product.PriceTag());
            //}

            #endregion

            #region Classes e Métodos abstratos (Exercicio Resolvido)

            //List<Shape> shapes = new List<Shape>();

            //Console.Write("Enter the nuymber of shapes: ");
            //int N = int.Parse(Console.ReadLine());
            //for (int i = 0; i < N; i++) 
            //{
            //    Console.WriteLine($"Shape #{i + 1}");
            //    Console.Write("Retangle or Cirfle (r/c): ");
            //    char shape = char.Parse(Console.ReadLine());
            //    Console.Write("Color (Black/Blue/Red): ");
            //    Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

            //    if (shape == 'r')
            //    {

            //        Console.Write("Width: ");
            //        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Console.Write("Height: ");
            //        double heigth = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            //        shapes.Add(new Rectangle(width, heigth, color));
            //    }
            //    else
            //    {
            //        Console.Write("Radius: ");
            //        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        shapes.Add(new Circle(radius, color));
            //    }

            //}

            //Console.WriteLine();
            //Console.WriteLine("SHAPE AREAS: ");
            //foreach (var item in shapes)
            //{
            //    Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            //}

            #endregion

            #region Classes e Métodos abstratos (Exercicio 02)

            List<TaxPayers> taxPayers = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) 
            {
                Console.Write($"Tax payer #{i + 1} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double heathExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new FisicalPerson(name,annualIncome, heathExpenditures));
                }
                else if (ch == 'c') 
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double totalTax = 0;
            foreach (var item in taxPayers)
            {
                Console.WriteLine($"{item.Name} : $ {item.TaxCalculation().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTax += item.TaxCalculation();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTax}");
            #endregion
        }
    }
}
