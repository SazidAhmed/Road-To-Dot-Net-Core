using System;
using System.Collections.Generic;

namespace TicketBooking
{
  class BookTicket
  {

    public static void userInputs (){
        //
    }
    public static void bookTicket()
    {
      const string conferenceName = "Techminate Conference";
      const int totalTickets = 10;
      int availableTickets = 10;

      List<string> bookings = new List<string>();

      Console.WriteLine("Welcome to " + conferenceName + " booking application");
      Console.WriteLine("Total Tickets : " + totalTickets);
      Console.WriteLine("Available Tickets : " + availableTickets);

      if(availableTickets <= 0){
        Console.WriteLine("All tickets are sold out!");
      }else{
        int i = 0;
        do{
            Console.WriteLine("How many tickets do you want to book ? : ");
            string userTickets = Console.ReadLine();
            int userTicket = Convert.ToInt32(userTickets);
            
            if(userTicket > availableTickets){
                Console.WriteLine("Only " + availableTickets + " tickets available");
                Console.WriteLine("=======================");
                Console.WriteLine("Enter 1 to book the avaialable tickets.");
                Console.WriteLine("Enter 2 to exit.");
                Console.WriteLine("=======================");
                string selectedOption = Console.ReadLine();

                switch (selectedOption){
                    case "1":
                        var info = UserInfo.usInfo();
                        bookings.Add(info.Item1);
                        availableTickets = availableTickets - userTicket;
                        Console.WriteLine("Thank you "+ info.Item1 + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + info.Item2);
                        break;

                    case "2":
                    Console.WriteLine("See you on the next time.");
                    break;
                }
            }else{
                var info = UserInfo.usInfo();
                bookings.Add(info.Item1);
                availableTickets = availableTickets - userTicket;
                Console.WriteLine("Thank you "+ info.Item1 + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + info.Item2);
            }

            if(bookings.Count > 0){
                Console.WriteLine("=======================");
                Console.WriteLine("Available Tickets : " + availableTickets);
                Console.WriteLine("Registered Names are : ");
                Console.WriteLine("=======================");
                foreach(string name in bookings){
                    Console.WriteLine(name);
                }
                Console.WriteLine("=======================");
            }
        }while(i < availableTickets);
      }
    }
  }
}