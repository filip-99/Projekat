using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class SchedulingBusinessTests
    {
        //*************************************************************************************************
        [TestMethod]
        public void IsSchedulingInserted()
        {
            //Arrange
            var mockSchedulingRepository = new Mock<ISchedulingRepository>();
            Scheduling s = new Scheduling
            {
                Day = 1,
                Period_id = 5,
                Classroom_number = 217,
                Occupied = true,
                Duty_person = "Vlade Urosevic"
            };
            mockSchedulingRepository.Setup(x => x.InsertScheduling(s)).Returns(1);

            var schedulingBusiness = new SchedulingBusiness(mockSchedulingRepository.Object);

            //Act
            var result = schedulingBusiness.InsertOneScheduling(s);

            //Assert
            Assert.IsTrue(result);
        }
        //*************************************************************************************************
        [TestMethod]
        public void AreReturnedSchedulings()
        {
            //Arrange
            var mockSchedulingRepository = new Mock<ISchedulingRepository>();
            List<Scheduling> listSchedulings = new List<Scheduling>();
            listSchedulings.Add(new Scheduling
            {
                Day = 1,
                Period_id = 5,
                Classroom_number = 217,
                Occupied = true,
                Duty_person = "Vlade Urosevic"
            });
            listSchedulings.Add(new Scheduling
            {
                Day = 1,
                Period_id = 6,
                Classroom_number = 217,
                Occupied = true,
                Duty_person = "Vlade Urosevic"
            });
            mockSchedulingRepository.Setup(x => x.GetSchedulings()).Returns(listSchedulings);
            var schedulingBusiness = new SchedulingBusiness(mockSchedulingRepository.Object);


            //Act
            var result = schedulingBusiness.GetAllSchedulings();
            Assert.AreEqual(2, result.Count);
        }
        //*************************************************************************************************
        [TestMethod]
        public void IsRezervacijaDelete()
        {
            //Arrange
            var mockSchedulingRepository = new Mock<ISchedulingRepository>();
            Scheduling s = new Scheduling
            {
                Day = 1,
                Period_id = 5,
                Classroom_number = 217,
                Occupied = true,
                Duty_person = "Vlade Urosevic"
            };
            mockSchedulingRepository.Setup(x => x.DeleteScheduling(s)).Returns(1);

            var schedulingBusiness = new SchedulingBusiness(mockSchedulingRepository.Object);

            //Act
            var result = schedulingBusiness.DeleteOneScheduling(s);

            //Assert
            Assert.IsTrue(result);
        }
        //*************************************************************************************************
        [TestMethod]
        public void IsSchedulingUpdate()
        {
            //Arrange
            var mockSchedulingRepository = new Mock<ISchedulingRepository>();
            Scheduling s = new Scheduling
            {
                Day = 1,
                Period_id = 5,
                Classroom_number = 217,
                Occupied = true,
                Duty_person = "Vlade Urosevic"
            };
            mockSchedulingRepository.Setup(x => x.UpdateScheduling(s)).Returns(1);

            var rezervacijaBusiness = new SchedulingBusiness(mockSchedulingRepository.Object);

            //Act
            var result = rezervacijaBusiness.UpdateOneScheduling(s);

            //Assert
            Assert.IsTrue(result);
        }

    }
}
