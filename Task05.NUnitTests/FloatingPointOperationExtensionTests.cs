using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Task05.Logic;
namespace Task05.NUnitTests
{
    [TestFixture]
    public class FloatingPointOperationExtensionTests
    {

        [TestCase(19.0,ExpectedResult = "0100000000110011000000000000000000000000000000000000000000000000")]
        [TestCase(-20.0, ExpectedResult = "1100000000110100000000000000000000000000000000000000000000000000")]
        [TestCase(0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(1, ExpectedResult = "0011111111110000000000000000000000000000000000000000000000000000")]
        public string GetDoubleIeee_Test(double inputNum)
        {
            
           return inputNum.GetDoubleIeee();
        }

    }
}
