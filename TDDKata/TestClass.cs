// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [TestCase("2,2", 4)]
        [TestCase("7", 7)]
        [TestCase("1,2,3,4,5", 15)]
        public void Sum_NumbersSum_ShouldReturnSum(string testCase, int expected)
        {
            //Arrange
            var calc = new StringCalc();

            //Act
            int actual = calc.Sum(testCase);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sum_ParamIsWrongNumber_ShouldReturnError()
        {
            //Arrange
            var calc = new StringCalc();
            var inputParams = "param";
            var expected = -1;

            //Act
            int actual = calc.Sum(inputParams);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sum_NumberIsNegative_ShouldReturnError()
        {
            //Arrange
            var calc = new StringCalc();
            var inputParams = "-3";
            var expected = -1;

            //Act
            int actual = calc.Sum(inputParams);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sum_ParamIsEmptyString_ShouldReturnZero()
        {
            //Arrange
            var calc = new StringCalc();
            var inputParams = string.Empty;
            var expected = 0;

            //Act
            int actual = calc.Sum(inputParams);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
