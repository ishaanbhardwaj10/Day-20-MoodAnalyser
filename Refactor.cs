using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    [TestClass]
    public class Refactor
    {
        private MoodAnalyser moodAnalyser;
        [TestMethod]
        public void RefactorTC1()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser("I am in Sad Mood");

            //Act
            var result = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual("SAD", result);
        }

        [TestMethod]
        public void RefactorTC2()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser("I am in Happy Mood");

            //Act
            var result = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual("HAPPY", result);
        }

    }
}
