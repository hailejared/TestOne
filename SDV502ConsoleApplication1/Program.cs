using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastwayCourier;

namespace SDV502ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                ParcelQuoteFromNelson quoteFromNelson = new ParcelQuoteFromNelson();
                string[] pinkZones = new string[] { "Nelson", "Motueka", "Mapua", "Atawhai", "Matai", "Hope", "Brightwater", "Wakefield", "Renwick", "Picton", "Blenheim" };

                Console.WriteLine(string.Join(" ", pinkZones));




                foreach (string towns in pinkZones)
                {

                    string ticketColour = quoteFromNelson.GetDestinationZone(towns);

                    Console.WriteLine($"\nPassed test: { towns }");
                }

            Console.ReadLine();



        }

    }
}

