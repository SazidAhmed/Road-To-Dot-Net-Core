using System;
using System.Collections.Generic;  
  
namespace Registration
{
  class Customer  
    {
      public string name { get; set; }  
      public string email { get; set; }  
    }

  class Program  
    { 
      const int totalTickets = 3;
      public static int availableTickets = 3;
      public static List<Customer> Customers = new List<Customer>(2);

      public static void mainMenu(){
        Console.WriteLine("========== Main Menu ==========");
        Console.WriteLine("Press 1 : to view total number of tickets.");
        Console.WriteLine("Press 2 : to check available tickets.");
        Console.WriteLine("Press 3 : to book tickets.");
        Console.WriteLine("Press 4 : View list.");
        Console.WriteLine("Press 5 : to exit.");
        Console.WriteLine("=======================");
      }

      public static string subMenu(){
        Console.WriteLine("Press 1 : to book tickets again");
        Console.WriteLine("Press 0 : back to main menu");
        Console.WriteLine("=======================");
        string selectedOption = Console.ReadLine();
    
        return selectedOption;
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
        }else if(selectedOption == "4"){
          displayBookings();
        }
        else{
          Console.WriteLine("See you soon.");
        }
      }

      public static void displayBookings()
      {
        foreach (Customer c in Customers) 
        {
          Console.WriteLine("Name={0}, Email={1}", c.name, c.email);
        }
        Console.WriteLine("=======================");
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
            Console.WriteLine("Enter your name : ");
            string uName = Console.ReadLine();
            Console.WriteLine("Enter your email : ");
            string uEmail = Console.ReadLine();
            
            Customer customer1 = new Customer()  
            {
              name = uName,
              email = uEmail
            };  
            Customers.Add(customer1);

            availableTickets = availableTickets - userTicket;
            Console.WriteLine("Available Tickets : " + availableTickets);
            Console.WriteLine("=======================");
            Console.WriteLine("Thank you "+ uName + " for booking "+ userTickets + " tickets. You will recieve a confirmation email at " + uEmail);
            Console.WriteLine("=======================");

            string selected = subMenu();
            if(selected == "1"){
              bookTicket(availableTickets);
            }else if(selected == "0"){
              if(Customers.Count > 0){
                  Console.WriteLine("=======================");
                  Console.WriteLine("Available Tickets : " + availableTickets);
                  Console.WriteLine("Registered Names are : ");
                  Console.WriteLine("=======================");
                  displayBookings();
              }
              mainMenu();
              selectedInputs();
            }
          }
        }
      }

      static void Main(string[] args)  
      {
        mainMenu();
        selectedInputs();
      }  
    }
}