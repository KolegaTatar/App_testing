import org.example.Calculator;
import org.junit.Test;

public class CalculatorTest {
    @Test
    public void testAdd() {
        Calculator calc = new Calculator();
        int result = calc.Add(1,2);
        assert result == 3;
    }

    @Test
    public void testSubstract() {
        Calculator calc = new Calculator();
        int result = calc.Subtract(1,2);
        assert result == -1;
    }

    @Test
    public void testMultiply() {
        Calculator calc = new Calculator();
        int result = calc.Multiply(1,2);
        assert result == 2;
    }

    @Test
    public void testDivide() {
        Calculator calc = new Calculator();
        int result = calc.Divide(4,2);
        assert result == 2;
    }


}
