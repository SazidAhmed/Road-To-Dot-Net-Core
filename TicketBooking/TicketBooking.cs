using System;
using System.Collections.Generic;

namespace TicketBooking
{
  class BookTicket
  {
    public static void bookTicket()
    {
      const string conferenceName = "Techminate Conference";
      const int totalTickets = 10;
      int availableTickets = 10;

      List<string> bookings = new List<string>();

      Console.WriteLine("Welcome to " + conferenceName + " booking application");
      Console.WriteLine("We have total of " + totalTickets + " tickets and " + availableTickets + " tickets still available");

      if(availableTickets <= 0){
        Console.WriteLine("All tickets are sold out!");
      }else{
        Console.WriteLine("How many tickets do you want to book ? : ");
        string userTickets = Console.ReadLine();
        int userTicket = Convert.ToInt32(userTickets);
        if(userTicket > availableTickets){
            Console.WriteLine("Only " + availableTickets + " tickets available");
        }else{
            Console.WriteLine("Enter your name : ");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Enter your email : ");
            string userEmail = Console.ReadLine();

            bookings.Add(userName);

            Console.WriteLine("Thank you "+ userName + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + userEmail);
        }

        if(bookings.Count > 0){
            Console.WriteLine("Registered Names are : ");
            Console.WriteLine("=======================");
            foreach(string name in bookings){
                Console.WriteLine(name);
            }
        }

        availableTickets = availableTickets - userTicket;
        Console.WriteLine(availableTickets + " Tickets available");

      }
    }
  }
}