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
            IEducation expected = new Education();
            expected.Teacher = "JensenLärare";
            expected.Feedback = "Blä";
            expected.Students = "Bosse";
            //Act
            IEducation actual = director.Build(builder);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NackaBuilderTest()
        {
            //Arrange
            NackademinBuilder builder = new NackademinBuilder();
            NackademinDirector director = new NackademinDirector();
            IEducation expected = new Education();
            expected.Teacher = "Mattias";
            expected.Feedback = "Bra";
            expected.Students = "Martin, Hans, Martin";
            //Act
            IEducation actual = director.Build(builder);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
