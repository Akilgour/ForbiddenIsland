using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using Repositry.Factory;

namespace UnitTestRepository.Factory
{
    [TestClass]
    public class IslandFactory_Test
    {
        [TestMethod]
        public void IsValid_ReturnIsland()
        {
            //Arrange 
            var islandFactory = new IslandFactory();

            //Act 
            var island = islandFactory.Create();

            //Assert
            Assert.AreNotEqual(island, null);
        }
 
    }
}
