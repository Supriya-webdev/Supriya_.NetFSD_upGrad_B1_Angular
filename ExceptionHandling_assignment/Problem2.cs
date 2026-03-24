using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling_assignment
{
    public class TicketBookingException : Exception
    {
        public TicketBookingException(string message) : base(message) { }
    }

    internal class Problem2
    {
        static void Main()
        {
            int availableTickets = 15;

            Console.Write("Do you want to book tickets? (yes/no): ");
            string choice = Console.ReadLine() ?? "";

            if (choice.ToLower() == "yes")
            {
                try
                {
                    Console.Write("Enter number of tickets to book: ");
                    int ticketsToBook = int.Parse(Console.ReadLine() ?? "0");

                    if (ticketsToBook > availableTickets)
                        throw new TicketBookingException($"Cannot book {ticketsToBook} tickets. Only {availableTickets} available.");

                    availableTickets -= ticketsToBook;
                    Console.WriteLine($"Successfully booked {ticketsToBook} tickets. Remaining: {availableTickets}");
                }
                catch (TicketBookingException ex)
                {
                    Console.WriteLine("Booking Exception: " + ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric value.");
                }
            }
            else
            {
                Console.WriteLine("Booking cancelled.");
            }
        }
    }
}
  