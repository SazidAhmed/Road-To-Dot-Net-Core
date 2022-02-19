
namespace TicketBooking
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome.welcome();
      BookTicket.mainMenu();
      BookTicket.selectedInputs();
    }
  }
}