using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTest
{
    [TestClass]
    public class TestEducationBuilder : IEducation
    {
        [TestMethod]
        public void JensenBuilderTest()
        {
            //Arrange
            JensenBuilder builder = new JensenBuilder();
            JensenDirector director = new JensenDirector();
            IEducation.
            //Act
            IEducation actual = director.Build(builder);
            //Assert
        }

        [TestMethod]
        public void NackaBuilderTest()
        {
            //Arrange

            //Actual

            //Assert
        }

        public string Teacher
        {
            get { return "Mattias"; }
        }

        public string Students
        {
            get { return "Martin, Hans, Martin"; }
        }

        public string Feedback
        {
            get { return "Bra"; }
        }
    }
}
