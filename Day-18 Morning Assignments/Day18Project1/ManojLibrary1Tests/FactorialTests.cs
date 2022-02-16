using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManojLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManojLibrary1.Tests
{
    [TestClass()]
    public class FactorialTests
    {
        [TestMethod()]
        public void AlgebraTest_Zero_Input()
        {
            //Arrange
            int n = 0;
            int expected = 1;
            //Act
            int actual = Factorial.Algebra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        

        [TestMethod()]
        public void AlgebraTest_Input_ZeroTo_Seven()

        {
            //Arrange
            int n = 5;
            int expected = 120;

            //Act
            int actual = Factorial.Algebra(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void AlgebraTest_GreaterThan_Seven()

        {
            //Arrange
            int n = 8;
            int expected = -999;

            //Act
            int actual = Factorial.Algebra(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void AlgebraTest_Negative_Numbers()

        {
            //Arrange
            int n = -4;
            int expected = -999;

            //Act
            int actual = Factorial.Algebra(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}