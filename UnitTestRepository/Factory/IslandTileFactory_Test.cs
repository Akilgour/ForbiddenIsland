using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Model;
using Repositry.Factory;

namespace UnitTestRepository.Factory
{
    [TestClass]
    public class IslandTileFactory_Test
    {
    

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "LocationDetails must be of type LocationDetails")]
        public void ExpectedException_ReturnsTypeOFIslandTile()
        {
            //Arrange 
            var stringVar = "String";
            var islandTileFactory = new IslandTileFactory();

            //Act 
            var islandTile = islandTileFactory.Create(stringVar);

            //Assert
            //ExpectedException
        }

        [TestMethod]
        public void IsValid_ReturnsTypeOFIslandTile()
        {
            //Arrange 
            var locationDetails = new LocationDetails(1, "a");
            var islandTileFactory = new IslandTileFactory();

            //Act 
            var islandTile = islandTileFactory.Create(locationDetails);

            //Assert
            Assert.IsInstanceOfType(islandTile, typeof(IslandTile));
        }

        [TestMethod]
        public void IsValid_LocationDetailsIDName()
        {
            //Arrange 
            var locationDetails = new LocationDetails(1, "a");
            var islandTileFactory = new IslandTileFactory();

            //Act 
            var islandTile = islandTileFactory.Create(locationDetails);

            //Assert
            Assert.AreEqual(islandTile.Id, 1);
            Assert.AreEqual(islandTile.Name, "a");
            Assert.AreEqual(islandTile.StartingTileForPlayer, Repositry.Repository.Enums.PlayerColours.None);
            Assert.AreEqual(islandTile.CanHaveTreasures, Repositry.Repository.Enums.Treasures.None);

        }

        [TestMethod]
        public void IsValid_LocationDetailsIDNameStartingTileForPlayer()
        {
            //Arrange 
            var locationDetails = new LocationDetails(1, "a", Repositry.Repository.Enums.PlayerColours.Blue);
            var islandTileFactory = new IslandTileFactory();

            //Act 
            var islandTile = islandTileFactory.Create(locationDetails);

            //Assert
            Assert.AreEqual(islandTile.Id, 1);
            Assert.AreEqual(islandTile.Name, "a");
            Assert.AreEqual(islandTile.StartingTileForPlayer, Repositry.Repository.Enums.PlayerColours.Blue);
            Assert.AreEqual(islandTile.CanHaveTreasures, Repositry.Repository.Enums.Treasures.None);

        }

        [TestMethod]
        public void IsValid_LocationDetailsIDNameCanHaveTreasures()
        {
            //Arrange 
            var locationDetails = new LocationDetails(1, "a",   Repositry.Repository.Enums.Treasures.TheCrystalOfFire);
            var islandTileFactory = new IslandTileFactory();

            //Act 
            var islandTile = islandTileFactory.Create(locationDetails);

            //Assert
            Assert.AreEqual(islandTile.Id, 1);
            Assert.AreEqual(islandTile.Name, "a");
            Assert.AreEqual(islandTile.StartingTileForPlayer, Repositry.Repository.Enums.PlayerColours.None);
            Assert.AreEqual(islandTile.CanHaveTreasures, Repositry.Repository.Enums.Treasures.TheCrystalOfFire);

        }

    }
}
