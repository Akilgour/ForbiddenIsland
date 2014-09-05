using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using Repositry.Factory;
using Repositry.Model.Interface;
using System.Collections.Generic;
using Repositry.Model;

namespace UnitTestRepository.Factory
{
    [TestClass]
    public class IslandFactory_Test
    {


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "FloodCards must be a list of CardFloods")]
        public void IsValid_TakesEmptyCardList()
        {
            //Arrange 
            var floodCards = new List<String>();
            var islandFactory = new IslandFactory();

            //Act 
            var island = islandFactory.Create(floodCards);

            //Assert
            //ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There must be 24 cards passed into the Island Factory")]
        public void IsValid_TakesCardListWithOneCard()
        {
            //Arrange 
            var floodCards = new List<String>();

            var cardOne = "cardOne";
            floodCards.Add(cardOne);

            var islandFactory = new IslandFactory();

            //Act 
           var island = islandFactory.Create(floodCards);

            //Assert
            //ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There must be 24 cards passed into the Island Factory")]
        public void IsValid_TakesCardListWithTwentyFourCards()
        {
            //Arrange 
            var floodCards = new List<LocationDetails>();
                     
         var cardOne = new LocationDetails(1, "cardOne");
            floodCards.Add(cardOne);
            var cardTwo  = new LocationDetails( 2, "cardTwo");
            floodCards.Add(cardTwo);
            var cardThree  = new LocationDetails( 3, "cardThree");
            floodCards.Add(cardThree);
            var cardFour  = new LocationDetails( 4, "cardFour");
            floodCards.Add(cardFour);
            var cardFive  = new LocationDetails( 5, "cardFive");
            floodCards.Add(cardFive);

            var cardSix  = new LocationDetails(6, "cardSix");
            floodCards.Add(cardSix);
            var cardSeven  = new LocationDetails( 7, "cardSeven");
            floodCards.Add(cardSeven);
            var cardEight  = new LocationDetails( 8, "cardEight");
            floodCards.Add(cardEight);
            var cardNine  = new LocationDetails( 9, "cardNine");
            floodCards.Add(cardNine);

            var cardTen  = new LocationDetails( 10, "cardTen");
            floodCards.Add(cardTen);
            var cardEleven  = new LocationDetails( 11, "cardEleven");
            floodCards.Add(cardEleven);
            var cardTwelve  = new LocationDetails( 12, "cardTwelve");
            floodCards.Add(cardTwelve);
            var cardThirteen  = new LocationDetails( 13, "cardThirteen");
            floodCards.Add(cardThirteen);
            var cardFourteen  = new LocationDetails(14, "cardFourteen");
            floodCards.Add(cardFourteen);
            var cardFifteen  = new LocationDetails( 15, "cardFifteen");
            floodCards.Add(cardFifteen);

            var cardSixteen  = new LocationDetails(16, "cardSixteen");
            floodCards.Add(cardSixteen);
            var cardSeventeen  = new LocationDetails( 17, "cardSeventeen");
            floodCards.Add(cardSeventeen);
            var cardEighteen  = new LocationDetails( 18, "cardEighteen");
            floodCards.Add(cardEighteen);
            var cardNineteen  = new LocationDetails( 19, "cardNineteen");
            floodCards.Add(cardNineteen);

            var cardTwenty  = new LocationDetails( 20, "cardTwenty");
            floodCards.Add(cardTwenty);
            var cardTwentyOne  = new LocationDetails( 21, "cardTwentyOne");
            floodCards.Add(cardTwentyOne);
            var cardTwentyTwo  = new LocationDetails( 22, "cardTwentyTwo");
            floodCards.Add(cardTwentyTwo);
            var cardTwentyThree  = new LocationDetails( 23, "cardTwentyThree");
            floodCards.Add(cardTwentyThree);
            var cardTwentyFour  = new LocationDetails( 24, "cardTwentyFour");
            floodCards.Add(cardTwentyFour);

            var islandFactory = new IslandFactory();

            //Act 
            var island = islandFactory.Create(floodCards);

            //Assert   
            Assert.AreEqual(island.IslandBoard.Count, 24);
        }

    }
}
