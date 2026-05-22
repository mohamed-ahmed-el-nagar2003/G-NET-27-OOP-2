using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Encapsolation_Assignment_02
{
    internal class Ticket
    {
        private string MovieName;
        public TicketType Type { get; set; }
        public Seat seat { get; set; }
        private double Price; 

        // Encapsolation Movie NAme 
        public string Movie_NAme
            {
            get 
            { 
              return MovieName;
            }
           
            set
            { 
                    if (!string.IsNullOrWhiteSpace(value))
                    MovieName = value;  
            }
             
            }

        // Encapsolation Price
        public double price
        {
            get
            {
                return Price;
            }

            set
            {
                if(value > 0 )
                    Price = value;  

            }
        }

        // Calc total Price after TAx
        public double CalcTotal_With_Tax => Price + (Price * .14);

        // ticket Counter 
        public static int TicketCounter { get;private  set; }

        // Ticket ID 

        public int ID { get;private set; }





        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            this.seat = seat;
            Price = price;
            //  Ticket Counter 
            TicketCounter++;
            // Ticket Id
            ID = TicketCounter;

        }
        public Ticket(string movieName) : this(movieName, TicketType.Standard, new Seat(), 50)
        {
            //  Ticket Counter 
            TicketCounter++;
            // Ticket Id
            ID = TicketCounter;
           
        }
        public Ticket()
        {
            //  Ticket Counter 
            TicketCounter++;
            // Ticket Id
            ID = TicketCounter;

      
        }

        //‘GetTotalTicketsSold()’
        public static int GetTotalTicketsSold()
        {
            return TicketCounter;
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Console.WriteLine($"============After Discount=========== ");
                Console.WriteLine($"Discount Before : {discountAmount}");
                Console.WriteLine($"Discount After : {discountAmount = 0}");
                Console.WriteLine($"Movie : {MovieName}");
                Console.WriteLine($"Discount After : {Type}");

            }
            else
            {
                Console.WriteLine($"Non Valid Discount");

            }

        }

        //public void PrintTicket()

        //{
        //    Console.WriteLine("======== TICKET INFO =========");
        //    Console.WriteLine($"Movie : {MovieName} ");
        //    Console.WriteLine($"Type : {Type} ");
        //    // Console.WriteLine($"Seat : {seat.Row} ");
        //    Console.WriteLine($"Seat : {seat.RowandSeatNumber()} ");
        //    Console.WriteLine($"Price : {Price} ");
        //    Console.WriteLine($"Total(14% tax) : {CalcTotal_With_Tax} ");


        //}


        public override string ToString()
        {
            return $" ID : {ID}  ,MovieName : {MovieName}  , ticket Type : {Type} , seat : {seat.RowandSeatNumber()} , Price : {Price} , Total(14% tax) : {CalcTotal_With_Tax}";
        }


    }
}
