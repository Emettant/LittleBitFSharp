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
        
        public Form1()
        {
            InitializeComponent();
            PickRate.Items.Add("ConstantRate");
            PickRate.Items.Add("DifferentRate");
            PickRate.SelectedIndex = 0;
        }

        decimal PickStartValue { get { return PickStart.Value / 1000; } }
        decimal Discount { get { return DiscountBox.Value / 100; } }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            IValueProvider provider;
            if (PickRate.SelectedIndex == 0)
                provider = new ConstantRateValueProvider(
                StartTime.Value,
                EndTime.Value,
                AmountBox.Value,
                (int)MaturityBox.Value,
                Discount,
                PickStartValue);
            else
                provider = new DifferentRateValueProvider(
                StartTime.Value,
                EndTime.Value,
                AmountBox.Value,
                (int)MaturityBox.Value,
                Discount,
                PickStartValue
                );

            var t = provider.GetValue();
            ResultBox.Text = string.Format("1: {0:0.00000}; \n2: {1:0.00000};" ,t.Item1, t.Item2);

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
        }
    }
}
