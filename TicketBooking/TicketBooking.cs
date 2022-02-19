using System;
using System.Collections.Generic;

namespace TicketBooking
{
  class BookTicket
  {
      const int totalTickets = 10;
      public static int availableTickets = 10;

    public static void displayBookings (List<string> bookings, int availableTickets){
        Console.WriteLine("=======================");
        Console.WriteLine("Available Tickets : " + availableTickets);
        Console.WriteLine("Registered Names are : ");
        Console.WriteLine("=======================");
        foreach(string name in bookings){
            Console.WriteLine(name);
        }
        Console.WriteLine("=======================");
    }

    public static void selectedInputs(){

        Console.WriteLine("Enter your choice : ");
        Console.WriteLine("=======================");
        
        string selectedOption = Console.ReadLine();

        if(selectedOption == "1"){
            Console.WriteLine("Total Tickets : " + totalTickets);
            selectedInputs();
        }else if(selectedOption == "2"){
            Console.WriteLine("Available Tickets : " + availableTickets);
            selectedInputs();
        }else if(selectedOption == "3"){
            bookTicket(availableTickets);
        }else{
            Console.WriteLine("See you soon.");
        }
    }

    public static void bookingsTicket(){
        Console.WriteLine("How many tickets do you want to book ? : ");
        string userTickets = Console.ReadLine();
        int userTicket = Convert.ToInt32(userTickets);
        if(userTicket > availableTickets){
            Console.WriteLine("Only " + availableTickets + " tickets available");
        }else{
            var info = UserInfo.usInfo();
            bookings.Add(info.Item1);
            availableTickets = availableTickets - userTicket;
            Console.WriteLine("Thank you "+ info.Item1 + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + info.Item2);
        }
    }

    public static void bookTicket(int availableTickets)
    {
      List<string> bookings = new List<string>();

      if(availableTickets <= 0){
        Console.WriteLine("All tickets are sold out!");
      }else{
        bookingsTicket();

        if(bookings.Count > 0){
            displayBookings(bookings, availableTickets);
        }
      }
    }
  }
}