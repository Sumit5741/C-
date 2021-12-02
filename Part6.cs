using System;
namespace PartSixNullableTypes
{
    class Part6
    {
        public static void Main(String [] args)
        {
            String CharacterIsNUllable = null;
            int? TicketsOnSale = null;
            int AvailableTickets;
            Console.WriteLine("Value Type can not be nullable");
            Console.WriteLine("Reference Type can be nullable"); 
            if(TicketsOnSale == null)
            {
                Console.WriteLine("TicketsOnSale is null");
            }
            else
            {
                Console.WriteLine("TicketsOnSale is not null");
            }
            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("AvailableTickets is : {0}", AvailableTickets);
        }
    }
}
