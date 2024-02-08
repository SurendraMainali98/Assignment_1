using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wealthy aunt
            //Taking input from user 
            Console.WriteLine("How much did you receive money ($)?");
            Double amountReceived = Double.Parse(Console.ReadLine());

            Console.WriteLine("Items after Books and supplies:");
            Double numberOfItems = Double.Parse(Console.ReadLine());

            // Calculating input given by User 

            Double booksAndSupplies = amountReceived * 0.75;
            Double remainingAmount = (amountReceived - booksAndSupplies) / numberOfItems;

            int coffees = (int)remainingAmount / 2;
            int flashComputer = (int)remainingAmount / 4;
            int subwayTickets = (int) remainingAmount / 3;
            int remainingDollars = (int)( amountReceived -booksAndSupplies- (coffees * 2 + flashComputer * 4 + subwayTickets * 3));

            // Displaying Result
            Console.WriteLine("Book and Supplies: " + booksAndSupplies + " $");
            Console.WriteLine("You can then buy:");
            Console.WriteLine(coffees + " coffees");
            Console.WriteLine(flashComputer + " Flash Computer Numbers");
            Console.WriteLine(subwayTickets + " subway Tickets");
            Console.WriteLine("and you will have " + remainingDollars + " dollars for the white roses");
        }
    }
}
