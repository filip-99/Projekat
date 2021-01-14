using Classroom_schedule;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayerTests
{
    [TestClass]
    public class FormMainTests
    {
        [TestMethod]
        public void ShowSchedule()
        {

            //Arrange
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
            var mockSchedulingBusiness = new Mock<ISchedulingBusiness>();
            mockSchedulingBusiness.Setup(x => x.GetAllSchedulings()).Returns(listSchedulings);

            var main = new FormMain(mockSchedulingBusiness.Object, null, null);

            //Act

            PrivateObject obj = new PrivateObject(main);
            obj.Invoke("ShowSchedule");
            ListBox listBoxSchedule = (ListBox)obj.GetFieldOrProperty("listBoxSchedule");

            //Assert
            Assert.AreEqual(2, listBoxSchedule.Items.Count);

            //I sada proveravamo da li su ubacena 2 rasporeda u list box
        }
    }
}
