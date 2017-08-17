using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace SDV502UnitTestProject1
{
    [TestClass]
    public class PinkZoneTests
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
        public void CompareColourMotuekaTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteMotueka = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteMotueka.GetDestinationZone("Motueka"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourMapuaTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteMapua = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteMapua.GetDestinationZone("Mapua"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourAtawhaiTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteAtawhai = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteAtawhai.GetDestinationZone("Atawhai"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourMataiTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteMatai = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteMatai.GetDestinationZone("Matai"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourHopeTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteHope = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteHope.GetDestinationZone("Hope"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourBrightwaterTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteBrightwater = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteBrightwater.GetDestinationZone("Brightwater"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourWakefieldTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteWakefield = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteWakefield.GetDestinationZone("Wakefield"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourRenwickTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteRenwick = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteRenwick.GetDestinationZone("Renwick"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourPictonTicket()
        {
            //arrange
            ParcelQuoteFromNelson quotePicton = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quotePicton.GetDestinationZone("Picton"); //town name 
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

    }

    [TestClass]
    public class OrangeZoneTests
    {
        [TestMethod]
        public void CompareColourReeftonTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteReefton = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteReefton.GetDestinationZone("Reefton"); //town name 
            //assert
            Assert.AreEqual("Orange", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourHanmerSpringsTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteHanmerSprings = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteHanmerSprings.GetDestinationZone("Hanmer Springs"); //town name 
            //assert
            Assert.AreEqual("Orange", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourKaikouraTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteKaikoura = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteKaikoura.GetDestinationZone("Kaikoura"); //town name 
            //assert
            Assert.AreEqual("Orange", ticketColour); //ticket colour
        }

    }

    [TestClass]
    public class LimeZoneTests
    {
        [TestMethod]
        public void CompareColourMurchisonTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteMurchison = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteMurchison.GetDestinationZone("Murchison"); //town name 
            //assert
            Assert.AreEqual("Lime", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourNelsonLakesTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteNelsonLakes = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteNelsonLakes.GetDestinationZone("Nelson Lakes National Park"); //town name 
            //assert
            Assert.AreEqual("Lime", ticketColour); //ticket colour
        }

    }

    [TestClass]
    public class BlueZoneTests
    {
        [TestMethod]
        public void CompareColourWardTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteWard = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteWard.GetDestinationZone("Ward"); //town name 
            //assert
            Assert.AreEqual("Blue", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourSeddonTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteSeddon = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteSeddon.GetDestinationZone("Seddon"); //town name 
            //assert
            Assert.AreEqual("Blue", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourHavelockTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteHavelock = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteHavelock.GetDestinationZone("Havelock"); //town name 
            //assert
            Assert.AreEqual("Blue", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourWaihopaiValleyTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteWaihopaiValley = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteWaihopaiValley.GetDestinationZone("Waihopai Valley"); //town name 
            //assert
            Assert.AreEqual("Blue", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourRiwakaTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteRiwaka = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteRiwaka.GetDestinationZone("Riwaka"); //town name 
            //assert
            Assert.AreEqual("Blue", ticketColour); //ticket colour
        }

        [TestMethod]
        public void CompareColourTakakaTicket()
        {
            //arrange
            ParcelQuoteFromNelson quoteTakaka = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteTakaka.GetDestinationZone("Takaka"); //town name 
            //assert
            Assert.AreEqual("Blue", ticketColour); //ticket colour
        }
    }

}

