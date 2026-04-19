using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day46Logic;

namespace Day46Logic.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoPlusThree_ReturnsFive()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_MinusFourPlusNine_ReturnsFive()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(-4, 9);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_TenPlusTwenty_ReturnsThirty()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(10, 20);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void NumberEven_Ten_ReturnsTrue()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.IsEven(10);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NumberEven_Nine_ReturnsFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.IsEven(9);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Divide_TenByTwo_ReturnsFive()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Divide(10, 2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_TenByZero_ThrowsException()
        {
            // Arrange
            Calculator calculator = new Calculator();

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(10, 0));
        }

        [TestMethod]
        public void GetGrade_NinetyFive_ReturnsA()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.GetGrade(95);

            // Assert
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void GetGrade_EightyFour_ReturnsB()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.GetGrade(84);

            // Assert
            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void GetGrade_SeventyOne_ReturnsC()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.GetGrade(71);

            // Assert
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void GetGrade_Fourty_ReturnsF()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.GetGrade(40);

            // Assert
            Assert.AreEqual("F", result);
        }
    }
}