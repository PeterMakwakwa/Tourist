using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Nancy.Json;
using System.Collections.Generic;
using System.Linq;
using Tourist.Dto;
using Tourist.Model;
using Tourist.Repository;
using Tourist.Service;

namespace TouristTesting
{
    [TestClass]
    public class UnitTestItem
    {
        [TestMethod]
        public void CheckAccepted_TotalWeight_ReturnWeight()
        {
            double expectedKG = 3.85;

            UnitTestContext unitTestContext = new UnitTestContext();

            Assert.AreEqual(expectedKG, unitTestContext.ItemDtoMockingContext.TotalWeightKG);


        }
        [TestMethod]
        public void CheckReturned_ItemCount_ReturnWeight()
        {
            int expectedItemcount = 9;

            UnitTestContext unitTestContext = new UnitTestContext();

            Assert.AreEqual(expectedItemcount, unitTestContext.ItemDtoMockingContext.Items.Count());


        }
        [TestMethod]
        public void CheckTheFirstItem_FirstHighestItem_ReturnItem()
        {
            Item expectedItem = new Item {
                Name = "water",
                Weight = 1530,
                Value = 200
            };

            UnitTestContext unitTestContext = new UnitTestContext();
            var firstItem = unitTestContext.ItemDtoMockingContext.Items.FirstOrDefault();
            var serializer = new JavaScriptSerializer();
            var actual = serializer.Serialize(firstItem);
            var expected = serializer.Serialize(expectedItem);            
            Assert.AreEqual(expected, actual);


        }
    }
}
