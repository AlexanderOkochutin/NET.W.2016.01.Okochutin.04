using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04.Logic
{
    /// <summary>
    /// Class MathHelper for different math operations
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Function for take n-th root from number with fixed accuracy 
        /// </summary>
        /// <param name="num">under root number</param>
        /// <param name="n"> we take N-th root</param>
        /// <param name="accuracy">accuracy fixed count of numbers after point</param>
        /// <returns>result of math operation</returns>
        public static double NthRoot(double num,double n,double accuracy)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(num), "input number must be non negative");
            }

            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "n must be in range (0,...)");
            }
            if (accuracy <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(accuracy), "accuracy must be in range (0,...)");
            }

            if (num == 0f)
            {
                return num;
            }

            double x = 1;
            double nx = x;
            while (true)
            {
                nx = (1 / n) * ((n - 1) * x + num / (Math.Pow(x, n - 1)));
                if (Math.Abs(x - nx) <= accuracy)
                {
                    return nx;
                }
                x = nx;
            }
        }

     
    }
}
