using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05.Logic
{
    /// <summary>
    /// Extension of numbers with floating points functionallity
    /// </summary>
    
    public static class FloatingPointOperationExtension
    {
        /// <summary>
        /// Extension method for double 
        /// </summary>
        /// <param name="num"> input number</param>
        /// <returns> string of binary (in IEEE 754) </returns>
        public static string GetDoubleIeee(this double num)
        {
            BitArray temp = new BitArray(BitConverter.GetBytes(num));
            StringBuilder a = new StringBuilder(64);
            for (int i = 63; i >= 0; i--)
            {
                a.Append(Convert.ToInt32(temp[i]));
            }
            return a.ToString();
        }
    }
}
