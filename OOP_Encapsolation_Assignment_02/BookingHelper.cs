using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsolation_Assignment_02
{
    static class BookingHelper
    {
        private static int counter = 0 ; 

        //       Create CalcGroupDiscount
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = 0;
            if (numberOfTickets >= 5)
            {
                total = (numberOfTickets * pricePerTicket) * .90;
                return total;
            }
            else  
            {
                total = (numberOfTickets * pricePerTicket);
                return total;
            }
        }

        //      Create string GenerateBookingReference()

        public static string GenerateBookingReference()
        {
            counter++;
            return $"BK-{counter}"; 

        }


    }
}
