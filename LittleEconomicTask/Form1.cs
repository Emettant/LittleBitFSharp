using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleEconomicTask
{
    public partial class Form1 : Form
    {
        DateTime DefaultReBuyingValue = Convert.ToDateTime("12 Apr 2002");
        
        Control[] RateSpeedGrowthContorls;
        public Form1()
        {
            InitializeComponent();
            PickRate.Items.Add("ConstantRate");
            PickRate.Items.Add("ExponentialRate");
            RateSpeedGrowthContorls = new Control[] { SpeedRateHeader, SpeedRateHelper, PickSpeed };
            PickRate.SelectedIndex = 0;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            IValueProvider provider;
            if (PickRate.SelectedIndex == 0)
                provider = new ConstantRateValueProvider(
                StartTime.Value,
                EndTime.Value,
                AmountBox.Value,
                (int)MaturityBox.Value,
                DiscountBox.Value,
                PickStart.Value);
            else
                provider = new ExponentialRateValueProvider(
                StartTime.Value,
                EndTime.Value,
                AmountBox.Value,
                (int)MaturityBox.Value,
                DiscountBox.Value,
                PickStart.Value,
                (double)PickSpeed.Value
                );

            var t = provider.GetValue();
            ResultBox.Text = t.Item1.ToString() + ", " + t.Item2.ToString();

        }

        private void EndTime_ValueChanged(object sender, EventArgs e)
        {
            if (EndTime.Value > StartTime.Value.AddYears((int)MaturityBox.Value))
            {
                EndTime.Value = DefaultReBuyingValue;
                MessageBox.Show("Wrong end date!");
            }
        }

        private void PickRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var el in RateSpeedGrowthContorls)
                el.Enabled = (PickRate.SelectedIndex == 1);
        }
    }
}
