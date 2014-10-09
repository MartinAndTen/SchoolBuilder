using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTest
{
    [TestClass]
    public class TestEducationBuilder
    {
        [TestMethod]
        public void JensenBuilderTest()
        {
            //Arrange
            JensenBuilder builder = new JensenBuilder();
            JensenDirector director = new JensenDirector();
            string expectedTeacher = "Lars";
            string expectedFeedback = "Konstig";
            string expectedStudents = "Bosse";
            //Act
            IEducation actual = director.Build(builder);
            //Assert
            Assert.AreEqual(expectedTeacher, actual.Teacher);
            Assert.AreEqual(expectedStudents, actual.Students);
            Assert.AreEqual(expectedFeedback, actual.Feedback);
        }

        [TestMethod]
        public void NackaBuilderTest()
        {
            //Arrange
            NackademinBuilder builder = new NackademinBuilder();
            NackademinDirector director = new NackademinDirector();
            string expectedTeacher = "Mattias";
            string expectedFeedback = "Bra";
            string expectedStudents = "Martin, Hans, Martin";
            //Act
            IEducation actual = director.Build(builder);
            //Assert
            Assert.AreEqual(expectedTeacher, actual.Teacher);
            Assert.AreEqual(expectedStudents, actual.Students);
            Assert.AreEqual(expectedFeedback, actual.Feedback);
        }
    }
}
