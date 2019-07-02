using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace AwesomeCalculatorTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAddition_Input13point4and51point6_Returns65point0()
        {

            //Arrange
            double number1 = 13.4;
            double number2 = 51.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetAddition_Input300point3and200point7_Returns501point0()
        {

            //Arrange
            double number1 = 300.3;
            double number2 = 200.7;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetAddition_Input444point1and20point7_Returns464point8()
        {

            //Arrange
            double number1 = 444.1;
            double number2 = 20.7;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input500point3and100point3_Returns400point0()
        {

            //Arrange
            double number1 = 500.3;
            double number2 = 100.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input5point3and1point3_Returns4point0()
        {

            //Arrange
            double number1 = 5.3;
            double number2 = 1.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input15point3and10point3_Returns5point0()
        {

            //Arrange
            double number1 = 15.3;
            double number2 = 10.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetMultiplication_Input12point0and10point0_Returns120point0()
        {

            //Arrange
            double number1 = 12.0;
            double number2 = 10.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetMultiplication_Input6point0and5point0_Returns30point0()
        {

            //Arrange
            double number1 = 6.0;
            double number2 = 5.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetMultiplication_Input50point0and8point0_Returns400point0()
        {

            //Arrange
            double number1 = 50.0;
            double number2 = 8.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input48point0and8point0_Returns6point0()
        {

            //Arrange
            double number1 = 48.0;
            double number2 = 8.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input480point0and10point0_Returns48point0()
        {

            //Arrange
            double number1 = 480.0;
            double number2 = 10.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input6point0and12point0_Returns0point5()
        {

            //Arrange
            double number1 = 6.0;
            double number2 = 12.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
