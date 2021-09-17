using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingLibrary;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResult = 1000;//Arrange
            ICalcInterest calc = new CalcInterest();//Act
            int ActualResult = calc.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResult, ActualResult);            //Assert
        }
    }
}
