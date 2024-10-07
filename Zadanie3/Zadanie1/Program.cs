using BusinessLogic;
namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(5.0, 8.0));
            Console.WriteLine(calculator.Substract(9.0, 10.0));
            Console.WriteLine(calculator.Division(6.0, 2.0));
            Console.WriteLine(calculator.Multiplication(7.0, 2.0));
            Console.WriteLine(calculator.ThePower(2, 3));
        }
    }
}
