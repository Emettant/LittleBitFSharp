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
        virtual public Tuple<decimal, decimal> GetValue()
        {
            //return new Tuple<decimal, decimal>(2m, 3m);
            return MyFunctionalLibrary.Solution.CalcProfits(
                new Bond(
                    IssuanceTime,
                    Maturity,
                    Amount,
                    RateFactory
                ),
                ReBuyTime,
                Discount
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
            RateFactory = new ConstantRateFactory(RateValue);
        }
    }

    class DifferentRateValueProvider : SpecificValueProvider, IValueProvider
    {
        protected readonly double RateSpeedGrowth;
        public DifferentRateValueProvider(DateTime issuanceTime, DateTime reBuy, decimal amount, int maturity, decimal discount, decimal rateValue)
            : base(issuanceTime,
                  reBuy,
                  amount,
                  maturity,
                  discount,
                  rateValue)
        {
            RateFactory = new DifferentRateFactory(rateValue);
        }
    }
}
