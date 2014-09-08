using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Repositry.Factory;
using Repositry.Model;

namespace UnitTestRepository.Factory
{
    [TestClass]
    public class FloodDeckFactory_Test
    {
 
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "LocationDetails must be a list of LocationDetails")]
        public void ExpectedException_TakesString()
        {
            //Arrange 
            var locationDetails = new List<String>();
            var floodDeckFactory = new FloodDeckFactory();

            //Act 
            var floodDeck = floodDeckFactory.Create(locationDetails);

            //Assert
            //ExpectedException
        }

        [TestMethod]
        public void IsValid_ReturnsTypeOfFloodDeck()
        {
            //Arrange 
            var locationDetailsList = new List<LocationDetails>();
            var cardOne = new LocationDetails(1, "cardOne");
            locationDetailsList.Add(cardOne);


            var floodDeckFactory = new FloodDeckFactory();

            //Act 
            var floodDeck = floodDeckFactory.Create(locationDetailsList);

            //Assert
            Assert.IsInstanceOfType(floodDeck, typeof(FloodDeck));
        }

        [TestMethod]
        public void IsValid_ReturnsTypeOfListCardFlood()
        {
            //Arrange 
            var locationDetailsList = new List<LocationDetails>();
            var cardOne = new LocationDetails(1, "cardOne");
            locationDetailsList.Add(cardOne);
            var floodDeckFactory = new FloodDeckFactory();

            //Act 
            var floodDeck = floodDeckFactory.Create(locationDetailsList);

            //Assert
            Assert.IsInstanceOfType(floodDeck.CardDrawPile, typeof(List<CardFlood>));
        }


        [TestMethod]
        public void IsValid_ReturnsLocationDetails()
        {
            //Arrange 
            var locationDetailsList = new List<LocationDetails>();
            var cardOne = new LocationDetails(1, "cardOne");
            locationDetailsList.Add(cardOne);
            var floodDeckFactory = new FloodDeckFactory();

            //Act 
            var floodDeck = floodDeckFactory.Create(locationDetailsList);

            //Assert
            Assert.AreEqual(floodDeck.CardDrawPile[0].IslandTileid, 1);
            Assert.AreEqual(floodDeck.CardDrawPile[0].IslandTile, "cardOne");
       }

             [TestMethod]
        public void IsValid_Random()
        {
            //Arrange 
            var locationDetailsList = new List<LocationDetails>();
            var cardOne = new LocationDetails(1, "cardOne");
            locationDetailsList.Add(cardOne);
            var floodDeckFactory = new FloodDeckFactory();

            var locationDetails = new LocationDetails(1, "cardOne");
            locationDetailsList.Add(cardOne);
            locationDetails = new LocationDetails(2, "cardTwo");
            locationDetailsList.Add(locationDetails);
            locationDetails = new LocationDetails(3, "cardThree");
            locationDetailsList.Add(locationDetails);
            locationDetails = new LocationDetails(4, "cardFour");
            locationDetailsList.Add(locationDetails);
            locationDetails = new LocationDetails(5, "cardFive");
            locationDetailsList.Add(locationDetails);

            //Act 
            var floodDeck = floodDeckFactory.Create(locationDetailsList);

            //Assert
            //TODO write test for radom
       }

        



    }
}
