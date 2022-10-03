using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //DONE - Add test data <-------
        [InlineData(12, 13, 15, 40)]
        [InlineData(33, 42, 55, 130)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-12, 13, -15, -14)]
        [InlineData(-12, -13, -15, -40)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // DONE - Start Step 3 here:

            //Arrange
            // DONE - create a Calculator object

            var addTester = new Calculator();

            //Act
            // DONE - call the Add method that is located in the Calculator class
            // DONE - and store its result in a variable named actual

            var actual = addTester.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 12, 3)] // DONE - Add test data <-------
        [InlineData(-15, 12, -27)]
        [InlineData(0, 0, 0)]
        [InlineData(-3, -5, 2)]
        [InlineData(15, -12, 27)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            // DONE - Start Step 5 here:

            //Arrange
            var subtractTester = new Calculator();

            //Act
            var actual = subtractTester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory] 
        [InlineData(1, 2, 2)] // DONE - Add test data <-------
        [InlineData(5, 5, 25)]
        [InlineData(0, 5, 0)]
        [InlineData(-1, 5, -5)]
        [InlineData(-1, -5, 5)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // DONE - Start Step 7 here:

            //Arrange
            var multiplyTester = new Calculator();

            //Act
            var actual = multiplyTester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 1, 5)] // DONE - Add test data <-------
        [InlineData(0, 5, 0)]
        [InlineData(-10, 2, -5)]
        [InlineData(-24, -6, 4)]

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divideTester = new Calculator();

            //Act
            var actual = divideTester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
