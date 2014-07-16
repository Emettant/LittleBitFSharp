using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFunctionalLibrary;

namespace LittleEconomicTask
{
    abstract class SpecificValueProvider
    {

        protected readonly DateTime IssuanceTime, ReBuyTime;
        protected readonly int Maturity;
        protected readonly decimal RateValue, Amount, Discount;
        protected IRateFactory RateFactory;
        public SpecificValueProvider(DateTime issuanceTime, DateTime reBuy, decimal amount, int maturity, decimal discount, decimal rateValue)
        {
            IssuanceTime = issuanceTime;
            ReBuyTime = reBuy;
            Maturity = maturity;
            Discount = discount;
            RateValue = rateValue;
            Amount = amount;
        }
        public Tuple<decimal, decimal> GetValue()
        {
            return MyFunctionalLibrary.Solution.CalcProfits(
                new Bond(
                    IssuanceTime,
                    RateFactory
                ),
                ReBuyTime,
                Discount,
                Amount
                );
        }
    }
    class ConstantRateValueProvider : SpecificValueProvider, IValueProvider
    {
        public ConstantRateValueProvider(DateTime issuanceTime, DateTime reBuy, decimal amount, int maturity, decimal discount, decimal rateValue)
            : base(issuanceTime,
                  reBuy,
                  amount,
                  maturity,
                  discount,
                  rateValue)
        {
            RateFactory = new ConstantRateFactory(Maturity, RateValue);
        }
    }

    class ExponentialRateValueProvider : SpecificValueProvider, IValueProvider
    {
        protected readonly double RateSpeedGrowth;
        public ExponentialRateValueProvider(DateTime issuanceTime, DateTime reBuy, decimal amount, int maturity, decimal discount, decimal rateValue, double rateSpeedGrowth)
            : base(issuanceTime,
                  reBuy,
                  amount,
                  maturity,
                  discount,
                  rateValue)
        {
            RateSpeedGrowth = rateSpeedGrowth;
            RateFactory = new MyFunctionalLibrary.ExponentialRateFactory(Maturity, RateValue, RateSpeedGrowth);
        }
    }
}
