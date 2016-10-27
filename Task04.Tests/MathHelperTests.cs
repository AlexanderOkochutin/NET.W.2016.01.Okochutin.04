using System;
using System.Diagnostics;
using Task04.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task04.Tests
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void NthRoot_num27_nth3_acc001_test()
        {
            double actual = MathHelper.NthRoot(27, 3, 0.001);
            double expected = 3;
            double accuracy = 0.001;
          
           
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }

        [TestMethod]
        public void NthRoot_num81_nth4_acc00001_test()
        {
            double actual = MathHelper.NthRoot(81, 4, 0.00001);
          
            double expected = 3;
            double accuracy = 0.001;
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }

        [TestMethod]
        public void NthRoot_num0_nth4_acc01_test()
        {
            double actual = MathHelper.NthRoot(0, 4, 0.01);
          
            double expected = 0;
            double accuracy = 0.01;
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }

        [TestMethod]
        public void NthRoot_num005_nth2_acc001_test()
        {
            double actual = MathHelper.NthRoot(0.05, 2, 0.001);
       
            double expected = 0.223;
            double accuracy = 0.001;
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }
        [TestMethod]
        public void NthRoot_num1024_nth10_acc001_test()
        {
            double actual = MathHelper.NthRoot(1024, 10, 0.001);
           
            double expected = 2;
            double accuracy = 0.001;
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }

        [TestMethod]
        public void NthRoot_num5_nth05_acc001_test()
        {
            double actual = MathHelper.NthRoot(5, 0.5, 0.001);
            double expected = 25;
            double accuracy = 0.001;
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }

        [TestMethod]
        public void NthRoot_num5_nth03_acc001_test()
        {
            double actual = MathHelper.NthRoot(5, 1f/3f, 0.001);
            double expected = 125;
            double accuracy = 0.001;
            Assert.IsTrue(Math.Abs(actual - expected) <= accuracy);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NthRoot_numMinus1_nth4_acc01_test()
        {
            double actual = MathHelper.NthRoot(-1, 4, 0.01);
      
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NthRoot_num5_nth0_acc01_test()
        {
            double actual = MathHelper.NthRoot(5 , 0, 0.01);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NthRoot_num5_nth0_acc0_test()
        {
            double actual = MathHelper.NthRoot(5, 0, 0);

        }
    }
}
