using System;
using ExceptionHandling.Entities;
using ExceptionHandling.Entities.Exceptions;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region try-catch
            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int result = n1 / n2;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException e) // tipo da exceção ao tentar dividir por 0
            //{
            //    Console.WriteLine($"Error! {e.Message}");
            //}
            //catch (FormatException e) // tipo da exceção ao tentar colocar um formato que não seja um número inteiro
            //{
            //    Console.WriteLine($"Format Error! {e.Message}");
            //}
            #endregion

            #region ApplicationException (exercicio resolvido)

            //try
            //{
            //    Console.Write("Room Number: ");
            //    int roomNumber = int.Parse(Console.ReadLine());
            //    Console.Write("Check-in date: (dd/MM/yyyy): ");
            //    DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date: (dd/MM/yyyy): ");
            //    DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);
                 
            //    Console.WriteLine();
            //    Console.WriteLine("Enter date to update the reservation");
            //    Console.Write("Check-in date: (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date: (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    reservation.UpdateDates(checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);
            //}
            //catch (DomainException ex) //ApplicationException, exceção personalizada
            //{
            //    Console.WriteLine("Error in reservation" + ex.Message);
            //}
            //catch (FormatException ex)
            //{ 
            //    Console.WriteLine("Format error: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Unexpected error: " + ex.Message);
            //}
            #endregion
        }
    }
}