using System;

namespace TicketBooking
{
  class Program
  {
    static void Main(string[] args)
    {
      const string conferenceName = "DotNet Core Conference";
      const int totalTickets = 10;
      int availableTickets = 10;

      Console.WriteLine("Welcome to " + conferenceName + " booking application");
      Console.WriteLine("We have total of " + totalTickets + " tickets and " + availableTickets + " tickets still available");
      Console.WriteLine("Follow the steps to book your tickets");

      Console.WriteLine("Enter your name : ");
      string userName = Console.ReadLine();
      
      Console.WriteLine("Enter your email : ");
      string userEmail = Console.ReadLine();

      Console.WriteLine("How many tickets do you want to book ? : ");
      string userTickets = Console.ReadLine();

      availableTickets = availableTickets - Convert.ToInt32(userTickets);

      Console.WriteLine("Thank you "+ userName + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + userEmail);

      Console.WriteLine(availableTickets + " Tickets available");


    }
  }
}