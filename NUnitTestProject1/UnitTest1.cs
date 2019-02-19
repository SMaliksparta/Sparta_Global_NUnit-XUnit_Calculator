using NUnit.Framework;
using CalculatorApplications;

namespace NunitTests
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAdd()
        {
            Calculator calc = new Calculator();
            double expected = 6.0;
            double actual = calc.Add(2.0, 4.0);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestDivide()
        {
            Calculator calc = new Calculator();
            double expected = 2.0;
            double actual = calc.Divide(4.0, 2.0);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestMultiply()
        {
            Calculator calc = new Calculator();
            double expected = 8.0;
            double actual = calc.Multiply(4.0, 2.0);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestSubtract()
        {
            Calculator calc = new Calculator();
            double expected = 2.0;
            double actual = calc.Subtract(4.0, 2.0);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestModulo()
        {
            Calculator calc = new Calculator();
            double expected = 0.0;
            double actual = calc.Modulo(9.0, 9.0);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestCircle()
        {
            Calculator calc = new Calculator();
            double expected = 28.274333882308138d;
            double actual = calc.Circle(9.0);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestSquare()
        {
            Calculator calc = new Calculator();
            double expected = 9.0;
            double actual = calc.Square(3.0, 3.0);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestRectangle()
        {
            Calculator calc = new Calculator();
            double expected = 9.0;
            double actual = calc.Rectangle(3.0, 3.0);
            Assert.AreEqual(expected, actual);

        }

    }



}