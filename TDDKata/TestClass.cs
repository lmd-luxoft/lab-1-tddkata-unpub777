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
        [Test]
        public void Sum_TwoNumber_ShouldReturnSum()
        {
            //Arrange
            var calc = new StringCalc();
            var inputParams = "2,2";
            var expected = 4;

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
