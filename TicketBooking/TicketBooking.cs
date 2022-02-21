
using System;
using System.Collections.Generic;

namespace TicketBooking
{
  class BookTicket
  {
    const int totalTickets = 10;
    public static int availableTickets = 10;

    public static List<string> bookings = new List<string>();

    public static void mainMenu(){
        Console.WriteLine("========== Main Menu ==========");
        Console.WriteLine("Press 1 : to view total number of tickets.");
        Console.WriteLine("Press 2 : to check available tickets.");
        Console.WriteLine("Press 3 : to book tickets.");
        Console.WriteLine("Press 4 : to exit.");
        Console.WriteLine("=======================");
    }

    public static string subMenu(){
        Console.WriteLine("Press 1 : to book tickets again");
        Console.WriteLine("Press 0 : back to main menu");
        Console.WriteLine("=======================");
        string selectedOption = Console.ReadLine();
    
        return selectedOption;
    }

    public static void displayBookings (List<string> bookings){
       
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

    public static void bookTicket(int availableTickets)
    {
      

      if(availableTickets <= 0){
        Console.WriteLine("All tickets are sold out!");
        mainMenu();
        selectedInputs();
      }else{
        Console.WriteLine("How many tickets do you want to book ? ");
        string userTickets = Console.ReadLine();
        int userTicket = Convert.ToInt32(userTickets);
        if(userTicket > availableTickets){
            Console.WriteLine("Only " + availableTickets + " tickets available");
            bookTicket(availableTickets);
        }else{
            var info = UserInfo.usInfo();
            bookings.Add(info.Item1);
            availableTickets = availableTickets - userTicket;
            Console.WriteLine("=======================");
            Console.WriteLine("Thank you "+ info.Item1 + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + info.Item2);
            Console.WriteLine("=======================");
            
            string selectedOption = subMenu();
            if(selectedOption == "1"){
                bookTicket(availableTickets);
            }else if(selectedOption == "0"){
                if(bookings.Count > 0){
                    Console.WriteLine("=======================");
                    Console.WriteLine("Available Tickets : " + availableTickets);
                    Console.WriteLine("Registered Names are : ");
                    Console.WriteLine("=======================");
                    displayBookings(bookings);
                }
                mainMenu();
                selectedInputs();
            }

        }
      }
    }
  }
}