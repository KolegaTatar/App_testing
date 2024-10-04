using BusinessLogic;
namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 8));
            Console.WriteLine(calculator.Substract(9, 10));
        }
    }
}
