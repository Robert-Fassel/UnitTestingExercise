using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(2, 3, 10, 15)]
        [InlineData(2, 3, 0, 5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8,4,4)]//Add test data <-------
        [InlineData(8, 0, 8)]
        [InlineData(8, -4, 12)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Subtract(minuend,subtrhend );
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1)]//Add test data <-------
        [InlineData(1, 2, 2)]
        [InlineData(4, -4, -16)]
        [InlineData(-4, -4, 16)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
           
            //Arrange
            var test = new Calculator();
            //Act
 var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]//Add test data <-------
        [InlineData(10, 2, 5)]
        [InlineData(10, 5, 2)]
        [InlineData(16,4,4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
