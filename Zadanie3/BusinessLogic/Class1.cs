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
        public double Add(double x, double y)
        {
            checked
            {
                return x + y;
            }
            
        }
        /// <summary>
        /// Kalkulator mający metody służące do dodawania i odejmowania
        /// </summary>
        /// <param name="x">pierwszy argument metody</param>
        /// <param name="y">drugi argument metody</param>
        /// <returns>x-y</returns>
        public double Substract(double x, double y)
        {
            return x - y;
        }


        /// <summary>
        /// Kalkulator posiadający funkcje dzielenia
        /// </summary>
        /// <param name="x">pierwszy argument metody</param>
        /// <param name="y">drugi argument metody</param>
        /// <returns>x/y</returns>
        public double Division(double x, double y)
        {
            return x / y;            
        }



        /// <summary>
        /// Kalkulator posiadający funkcje mnożenia
        /// </summary>
        /// <param name="x">pierwszy argument metody</param>
        /// <param name="y">drugi argument metody</param>
        /// <returns>x/y</returns>
        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Kalkulator posiadający funkcje potęgowania
        /// </summary>
        /// <param name="x">pierwszy argument metody</param>
        /// <param name="y">drugi argument metody</param>
        /// <returns>x/y</returns>
        public int ThePower(int x, int y)
        {
            
            int result = x;
            while (y > 1)
            {
                x = x * result;
                y--;
            }
            return x;
        }
    }
}
