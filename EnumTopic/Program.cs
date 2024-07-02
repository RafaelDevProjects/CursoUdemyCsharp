
using TopicEnum.Entities;
using EnumTopic.Entities.Enums;
using System;
using EnumTopic.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Policy;

namespace CourseEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Enum
            //Order order = new Order
            //{
            //    Id = 1080,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.PendingPayment
            //};

            //Console.WriteLine(order);

            //string txt = OrderStatus.PendingPayment.ToString(); // converte o valor enumerado para string

            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            //Console.WriteLine(os);
            #endregion

            #region Composition employee recruitment

            //Console.Write("Entre department's name: ");
            //string deparmentName = Console.ReadLine();
            //Department department = new Department(deparmentName);

            //Console.WriteLine("Enter worker data: ");
            //Console.Write("Name: ");
            //string workerName = Console.ReadLine();
            //Console.Write("Level (Junior/MidLevel/Senior): ");
            //string workerLevel = Console.ReadLine();
            //WorkerLevel wl = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), workerLevel);
            //Console.Write("Base salary: ");
            //double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Worker worker = new Worker(workerName, wl, workerBaseSalary, department);

            //Console.Write("How many contracts to this worker? ");
            //int qntContracts = int.Parse(Console.ReadLine());

            //for (int i = 0; i < qntContracts; i++)
            //{
            //    Console.WriteLine($"Enter #{i+1} contract data: ");

            //    Console.Write("Date (DD/MM/YYYY): ");
            //    DateTime contractDate = DateTime.Parse(Console.ReadLine());

            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    Console.Write("Duration (hours): ");
            //    int duration = int.Parse(Console.ReadLine());

            //    HourContract hourContract = new HourContract(contractDate, valuePerHour, duration);

            //    worker.AddContract(hourContract);
            //}

            //Console.WriteLine();

            //Console.Write("Enter month and year to calculate income (MM/YYYY)");
            //string monthAndYear = Console.ReadLine();
            //int month = int.Parse(monthAndYear.Substring(0, 2));
            //int year = int.Parse(monthAndYear.Substring(3));


            //double income = worker.income(year, month);
            //Console.WriteLine($"Name: {worker.Name}");
            //Console.WriteLine($"Department: {worker.Department.Name}");
            //Console.WriteLine($"Income for {monthAndYear}: {income}");


            #endregion

            #region SocialPost

            //Post post = new Post("Hello GitHub!!!", "This is a new repositorie");
            //post.PostLike();
            //post.PostLike();
            //post.PostLike();
            //post.PostLike();
            //post.PostLike();
            //Comment comment = new Comment("This is Gratiful");
            //post.PostComment(comment);
            //Console.WriteLine(post.ToString());


            #endregion

            #region Order Soluction Advanced Level

            //Console.WriteLine("Enter Client Data");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Email: ");
            //string email = Console.ReadLine();
            //Console.Write("Birth Date (DD/MM/YYYY): ");
            //string date = Console.ReadLine();
            //DateTime newDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //Client client = new Client(name, email, newDate);

            //Console.WriteLine("Enter Order Data");
            //Console.Write("Status: ");
            //string status = Console.ReadLine();
            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), status);
            //Order order = new Order(os, client);

            //Console.Write("How many itens to this order? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter #{i+1} item data: ");
            //    Console.Write("Product name: ");
            //    string productName = Console.ReadLine();
            //    Console.Write("Product price: ");
            //    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Quantity: ");
            //    int productQuantity = int.Parse(Console.ReadLine());

            //    Product product = new Product(productName, productPrice);

            //    OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

            //    order.AddItem(orderItem);

            //}
            //Console.WriteLine();
            //Console.WriteLine(order);
            #endregion

        }
    }
}
