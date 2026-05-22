using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsolation_Assignment_02
{
    internal struct Seat
    {
        public string Row { get; set; }
        public int Number { get; set; }
        public Seat(string row, int number)
        {
            Row = row;
            Number = number;
        }
        public Seat()
        {

            Row = "A";
            Number = 1;
        }
        public string RowandSeatNumber()
        {
            return $"{Row}{Number}";
        }
    }
}
