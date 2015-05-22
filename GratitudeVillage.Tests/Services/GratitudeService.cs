using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GratitudeVillage.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GratitudeVillage.Tests.Services
{
    [TestClass]
    public class GratitudeServiceTest
    {
        [TestMethod]
        public void GetTopGratitudes()
        {
            //Arrange
            var service = new GratitudeService();

            //Act
            var list = service.GetTopGratitudes();

            //Assert
            Assert.AreNotEqual(list.Count, 0);
        }
    }
}
