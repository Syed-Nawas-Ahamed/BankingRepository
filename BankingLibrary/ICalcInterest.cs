using System;

namespace BankingLibrary
{
    public interface ICalcInterest
    {
        public int Calculate(int principle,int years, int RateOfInt);
    }
}
