using BusinessLogic;
namespace BussinesLogic.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatorSumShouldAdd()
        {
            Calculator calculator = new();
            double x = 2;
            double y = 3;
            double expected = 5;

            double result = calculator.Add(x, y);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void CalculatorSubstractSubstractTwoNumbers()
        {
            Calculator calculator = new();
            double x = 2.0;
            double y = 3.0;
            double expected = -1;


            double result = calculator.Substract(x, y);

            Assert.Equal(expected, result);

        }
        /*
        [Fact]
        public void CalculatorAddIntOverflows()
        {
            Calculator calculator = new();

            int x = int.MaxValue;
            int y = int.MaxValue;

            Assert.Throws<OverflowException>(() =>
            {
                calculator.Add(x, y);
            });
        }*/

        [Fact]
        public void CalculatorDivisionToNumbers()
        {
            Calculator calculator = new();

            double x = 3.0;
            double y = 2.0;
            double expected = 1.5;


            double result = calculator.Division(x, y);

            Assert.Equal(expected, result);

        }


        [Fact]
        public void CalculatorMultiplicationToNumbers()
        {
            Calculator calculator = new();

            double x = 5.0;
            double y = 6.5;
            double expected = 32.5;
            double result = calculator.Multiplication(x, y);

            Assert.Equal(expected, result);

        }


        [Fact]
        public void CalculatorThePowerToNumbers()
        {
            Calculator calculator = new();

            int x = 3;
            int y = 4;
            int expected = 81;
            int result = calculator.ThePower(x, y);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(double.MaxValue, 1.0)]
        public void Add_Test_MaxValue(double x, double y)
        {
            Calculator calculator = new();

            double c = calculator.Add(x, y);
            Assert.Equal(x, c);

        }

        [Fact]
        public void TestSth()
        {
            Calculator calculator = new();
            int x = 3;
            int y = int.MaxValue;
            Assert.Throws<OverflowException>(() =>
            {
                calculator.Add(x, y);
            });
        }

        

    }
}