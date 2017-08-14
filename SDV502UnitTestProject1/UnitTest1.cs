using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace SDV502UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareColourNelsonTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteNelson = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteNelson.GetDestinationZone("Nelson"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourBlenheimTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteBlenheim = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteBlenheim.GetDestinationZone("Blenheim"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourAllTicket()
        {
            ParcelQuoteFromNelson quoteFromNelson = new ParcelQuoteFromNelson();

            string[] pinkZones = new string[] { "Nelson", "Motueka", "Mapua", "Atawhai", "Matai", "Hope", "Brightwater", "Wakefield", "Renwick", "Picton", "Blenheim" };

            foreach (string towns in pinkZones)
            {
                string ticketColour = quoteFromNelson.GetDestinationZone(towns);
                Assert.AreEqual("Pink", ticketColour);
            }
        }

        [TestMethod]
        public void GetTicketPriceOfNelson()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromNelson = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromNelson.CalculateQuote(12, "Pink");

            //assert
            Assert.AreEqual(0, quoteResult.ExcessTickets);
            Assert.AreEqual(4.15m, quoteResult.Price);
        }


    }
}

//CHEESE
