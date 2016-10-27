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
        /// <returns> BitArray of double (in IEEE 754) </returns>
        public static BitArray GetDoubleIeee(this double num)
        {
            return new BitArray(BitConverter.GetBytes(num));
        }
    }
}
