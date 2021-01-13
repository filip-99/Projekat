using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayerTests
{
    [TestClass]
    public class PeriodBusinessTests
    {
        //*************************************************************************************************
        [TestMethod]
        public void AreReturnedPeriods()
        {
            //Arrange
            var mockPeriodRepository = new Mock<IPeriodRepository>();
            List<Period> listPeriods = new List<Period>();
            listPeriods.Add(new Period
            {
                Id = 6,
                Start_time = TimeSpan.Parse("17:00:00"),
                End_time = TimeSpan.Parse("17:45:00"),
            });
            listPeriods.Add(new Period
            {
                Id = 7,
                Start_time = TimeSpan.Parse("18:00:00"),
                End_time = TimeSpan.Parse("18:45:00")
            });
            mockPeriodRepository.Setup(x => x.GetPeriods()).Returns(listPeriods);
            var periodBusiness = new PeriodBusiness(mockPeriodRepository.Object);


            //Act
            var result = periodBusiness.GetAllPeriods();
            Assert.AreEqual(2, result.Count);
        }

        //*************************************************************************************************
        [TestMethod]
        public void IsPeriodInserted()
        {
            //Arrange
            var mockPeriodRepository = new Mock<IPeriodRepository>();
            Period p = new Period
            {
                Id = 5,
                Start_time = TimeSpan.Parse("18:00:00"),
                End_time = TimeSpan.Parse("18:45:00")
            };
            mockPeriodRepository.Setup(x => x.InsertPeriod(p)).Returns(1);

            var periodBusiness = new PeriodBusiness(mockPeriodRepository.Object);

            //Act
            var result = periodBusiness.InsertOnePeriod(p);

            //Assert
            Assert.IsTrue(result);
        }
        //*************************************************************************************************
        [TestMethod]
        public void IsPeriodUpdate()
        {
            //Arrange
            var mockPeriodRepository = new Mock<IPeriodRepository>();
            Period t = new Period
            {
                Start_time = TimeSpan.Parse("18:00:00"),
                End_time = TimeSpan.Parse("18:45:00"),
            };
            mockPeriodRepository.Setup(x => x.UpdatePeriod(t)).Returns(1);

            var periodBusiness = new PeriodBusiness(mockPeriodRepository.Object);

            //Act
            var result = periodBusiness.UpdateOnePeriod(t);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
