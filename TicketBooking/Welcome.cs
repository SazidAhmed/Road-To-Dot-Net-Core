using System;

namespace TicketBooking{
    public class Welcome{
        public static void welcome(string conferenceName, int totalTickets, int availableTickets) {

            Console.WriteLine("Welcome to " + conferenceName + " booking application");
            Console.WriteLine("Total Tickets : " + totalTickets);
            Console.WriteLine("Available Tickets : " + availableTickets);
        }
    }
}