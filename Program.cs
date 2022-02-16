using System;

namespace TicketBooking
{
  class Program
  {
    static void Main(string[] args)
    {
      string conferenceName = "DotNet Core Conference";
      int totalTickets = 10;
      int availableTickets = 10;

      Console.WriteLine("Welcome to " + conferenceName + "booking application");
      Console.WriteLine("We have total of " + totalTickets + " tickets and " + availableTickets + " tickets still available");
      Console.WriteLine("Get your ticket here to attend");
    }
  }
}