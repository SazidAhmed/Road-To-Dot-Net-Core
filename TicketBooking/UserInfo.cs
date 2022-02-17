using System;

namespace TicketBooking{
    public class UserInfo{
        public static Tuple<string, string> usInfo(){

            Console.WriteLine("Enter your name : ");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Enter your email : ");
            string userEmail = Console.ReadLine();

            return Tuple.Create(userName, userEmail);
        }
    }
}