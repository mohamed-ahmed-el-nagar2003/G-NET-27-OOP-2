using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsolation_Assignment_02
{
    internal class Cinema
    {
        private Ticket[] Tickets = new Ticket[20];

      
        public Ticket? this[int index]
        {
            get
            {
                if (index >= 0 && index <= 19)
                    return Tickets[index];
                return null;
            }

            set
            {
                if (index >= 0 && index <= 19)
                    Tickets[index] = value;
               

            }
        }

        //    `AddTicket(Ticket t)` 

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i] == null )
                {
                    Tickets[i] = ticket;
                    return true;
                }
                
            }

            return false;
        }

        //Get Movie By movieName
        public Ticket? this[String movieName]
        {
            get
            {
                foreach (var ticket in Tickets)
                {
                    if (ticket != null &&ticket.Movie_NAme == movieName)
                        return ticket;
                    return null;

                }
                return null;
            }
        }


        public void displayTickets()
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                 if(Tickets[i] != null) 
                
                Console.WriteLine(Tickets[i]);
            }

           
        }
    }


}
