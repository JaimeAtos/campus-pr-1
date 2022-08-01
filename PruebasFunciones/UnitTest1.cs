using System;
using System.Collections.Generic;
using Xunit;

namespace PerformanceReviewI.src
{
    public class UnitTest1
    {
        Methods MyMethods = new src.Methods();
        [Fact]
        public void EmailOnlyTest()
        {
            //Arrange
            Persona MyPersona = new Persona("Jaime", "Jaime@jaime.com", new DateTime(2000, 05, 17));
            List<Persona> MyListP = new List<Persona>();
            MyListP.Add(MyPersona);
            string Expected = "Jaime@jaime.com";

            //Act
            List<string> OnlyEmails = MyMethods.OnlyEmails(MyListP);
            //Assert
            Assert.Equal(Expected, OnlyEmails[0]);
        }

        [Theory]
        [InlineData(2000, 12, 25)]
        public void FilteredByBirthdayTest(DateTime dateToCompare)
        {
            //Arrange

            //Act
            //Assert
        }
    }
}
