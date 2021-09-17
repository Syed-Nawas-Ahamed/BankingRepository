using System;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int principle, int years, int RateOfInt)
        {
            int SimpInt = (principle * years * RateOfInt) / 100;
            return SimpInt;
        }
    }
}
