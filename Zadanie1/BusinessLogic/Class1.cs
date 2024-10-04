using System.Runtime.InteropServices.Marshalling;

namespace BusinessLogic
{
    public class Calculator
    {
        /// <summary>
        /// Kalkulator mający metody służące do dodawania i odejmowania
        /// </summary>
        /// <param name="x">pierwszy argument metody</param>
        /// <param name="y">drugi argument metody</param>
        /// <returns>x+y</returns>
        public int Add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Kalkulator mający metody służące do dodawania i odejmowania
        /// </summary>
        /// <param name="x">pierwszy argument metody</param>
        /// <param name="y">drugi argument metody</param>
        /// <returns>x-y</returns>
        public int Substract(int x, int y)
        {
            return x - y;
        }
    }
}
