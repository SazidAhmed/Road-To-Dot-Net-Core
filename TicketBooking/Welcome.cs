using System;

namespace TicketBooking{
    public class Welcome{
        public static void welcome() {

            Console.WriteLine("Welcome to ticket booking application");
            Console.WriteLine("=======================");
            Console.WriteLine("Press 1 : to view total number of tickets.");
            Console.WriteLine("Press 2 : to check available tickets.");
            Console.WriteLine("Press 3 : to book tickets.");
            Console.WriteLine("Press 4 : to exit.");
            Console.WriteLine("=======================");
        }
    }
}