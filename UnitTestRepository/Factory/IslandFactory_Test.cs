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
        [ExpectedException(typeof(ArgumentException), "There must be 24 cards passed into the Island Factory")]
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

    }
}
