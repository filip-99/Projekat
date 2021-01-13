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
    public class ClassroomBusinessTests
    {
        //*************************************************************************************************
        [TestMethod]
        public void AreReturnedClassrooms()
        {
            //Arrange
            var mockClassroomRepository = new Mock<IClassroomRepository>();
            List<Classroom> listClassrooms = new List<Classroom>();
            listClassrooms.Add(new Classroom
            {
                Number = 101,
                Capacity = 45
            });
            listClassrooms.Add(new Classroom
            {
                Number = 105,
                Capacity = 50
            });
            mockClassroomRepository.Setup(x => x.GetClassrooms()).Returns(listClassrooms);
            var classroomBusiness = new ClassroomBusiness(mockClassroomRepository.Object);


            //Act
            var result = classroomBusiness.GetAllClassrooms();
            Assert.AreEqual(2, result.Count);
        }

        //*************************************************************************************************
        [TestMethod]
        public void IsClassroomInserted()
        {
            //Arrange
            var mockClassroomRepository = new Mock<IClassroomRepository>();
            Classroom c = new Classroom
            {
                Number = 105,
                Capacity = 50
            };
            mockClassroomRepository.Setup(x => x.InsertClassroom(c)).Returns(1);

            var classroomBusiness = new ClassroomBusiness(mockClassroomRepository.Object);

            //Act
            var result = classroomBusiness.InsertOneClassroom(c);

            //Assert
            Assert.IsTrue(result);
        }
        //*************************************************************************************************
        //PROVERA UPDATE
        [TestMethod]
        public void IsClassroomUpdate()
        {
            //Arrange
            var mockClassroomRepository = new Mock<IClassroomRepository>();
            Classroom c = new Classroom
            {
                Number = 105,
                Capacity = 50
            };
            mockClassroomRepository.Setup(x => x.UpdateClassroom(c)).Returns(1);

            var classroomBusiness = new ClassroomBusiness(mockClassroomRepository.Object);

            //Act
            var result = classroomBusiness.UpdateOneClassroom(c);

            //Assert
            Assert.IsTrue(result);
        }

    }
}
