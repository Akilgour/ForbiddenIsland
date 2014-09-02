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
            var floodCards = new List<ICardFlood>();
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
            var floodCards = new List<CardFlood>();
           
            var cardOne = new CardFlood();
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
            var floodCards = new List<CardFlood>();

            var cardOne = new CardFlood();
            floodCards.Add(cardOne);
            var cardTwo = new CardFlood();
            floodCards.Add(cardTwo);
            var cardThree = new CardFlood();
            floodCards.Add(cardThree);
            var cardFour = new CardFlood();
            floodCards.Add(cardFour);
            var cardFive = new CardFlood();
            floodCards.Add(cardFive);

            var cardSix = new CardFlood();
            floodCards.Add(cardSix);
            var cardSeven = new CardFlood();
            floodCards.Add(cardSeven);
            var cardEight = new CardFlood();
            floodCards.Add(cardEight);
            var cardNine = new CardFlood();
            floodCards.Add(cardNine);

            var cardTen = new CardFlood();
            floodCards.Add(cardTen);
            var cardEleven = new CardFlood();
            floodCards.Add(cardEleven);
            var cardTwelve = new CardFlood();
            floodCards.Add(cardTwelve);
            var cardThirteen = new CardFlood();
            floodCards.Add(cardThirteen);
            var cardFourteen = new CardFlood();
            floodCards.Add(cardFourteen);
            var cardFifteen = new CardFlood();
            floodCards.Add(cardFifteen);

            var cardSixteen = new CardFlood();
            floodCards.Add(cardSixteen);
            var cardSeventeen = new CardFlood();
            floodCards.Add(cardSeventeen);
            var cardEighteen = new CardFlood();
            floodCards.Add(cardEighteen);
            var cardNineteen = new CardFlood();
            floodCards.Add(cardNineteen);

            var cardTwentyOne = new CardFlood();
            floodCards.Add(cardTwentyOne);
            var cardTwentyTwo = new CardFlood();
            floodCards.Add(cardTwentyTwo);
            var cardTwentyThree = new CardFlood();
            floodCards.Add(cardTwentyThree);
            var cardTwentyFour = new CardFlood();
            floodCards.Add(cardTwentyFour);

            var islandFactory = new IslandFactory();

            //Act 
            var island = islandFactory.Create(floodCards);

            //Assert   
            Assert.AreNotEqual(island.IslandBoard.Rows.Count, 24);
        }

    }
}
