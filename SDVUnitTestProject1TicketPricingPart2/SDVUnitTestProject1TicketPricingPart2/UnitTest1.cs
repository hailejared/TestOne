using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace SDVUnitTestProject1TicketPricing
{
    [TestClass]
    public class UnitTest1
    {
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

        [TestMethod]
        public void GetTicketPriceOfHavelock()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromHavelock = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromHavelock.CalculateQuote(12, "Blue");
            
            //assert
            Assert.AreEqual(0, quoteResult.ExcessTickets);
            Assert.AreEqual(6.95m, quoteResult.Price);
        }

        [TestMethod]
        public void GetTicketPriceOfMurchison()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromMurchison = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromMurchison.CalculateQuote(12, "Lime");

            //assert
            Assert.AreEqual(0, quoteResult.ExcessTickets);
            Assert.AreEqual(8.70m, quoteResult.Price);
        }

        [TestMethod]
        public void GetTicketPriceOfReefton()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromReefton = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromReefton.CalculateQuote(12, "Orange");

            //assert
            Assert.AreEqual(0, quoteResult.ExcessTickets);
            Assert.AreEqual(12.95m, quoteResult.Price);
        }

        [TestMethod]
        public void GetTicketPriceOfReeftonOno()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromReefton = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromReefton.CalculateQuote(16, "Orange");

            //assert
            Assert.AreEqual(1, quoteResult.ExcessTickets);
            Assert.AreEqual(19.15m, quoteResult.Price);
        }

        [TestMethod]
        public void GetTicketPriceOfReeftonDos()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromReefton = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromReefton.CalculateQuote(22, "Orange");

            //assert
            Assert.AreEqual(2, quoteResult.ExcessTickets);
            Assert.AreEqual(25.35m, quoteResult.Price);
        }

        [TestMethod]
        public void GetTicketPriceOfMurchisonOno()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromMurchison = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromMurchison.CalculateQuote(16, "Lime");

            //assert
            Assert.AreEqual(1, quoteResult.ExcessTickets);
            Assert.AreEqual(14.90m, quoteResult.Price);
        }

        [TestMethod]
        public void GetTicketPriceOfMurchisonDos()
        {
            //arrange
            ParcelQuoteFromNelson quoteFromMurchison = new ParcelQuoteFromNelson();

            //act
            ParcelQuoteResult quoteResult = quoteFromMurchison.CalculateQuote(16, "Lime");

            //assert
            Assert.AreEqual(1, quoteResult.ExcessTickets);
            Assert.AreEqual(14.90m, quoteResult.Price);
        }

    }
}
