using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum DuductionFrequency
    {
        None = 1,
        Daily,
        Monthly,
        EveryTwoMonths,
        Yearly,
    }

    public class Subscription
    {
        DuductionFrequency m_Frequency;
        decimal m_ChargeAmount;

        public Subscription() { }

        public DuductionFrequency GetFrequency() { return m_Frequency; }

        public void SetFrequency(DuductionFrequency InFrequency) { m_Frequency = InFrequency; }

        public decimal GetChargeAmount() { return m_ChargeAmount; }

        public void SetChargeAmount(decimal InChargeAmount) { m_ChargeAmount = InChargeAmount; }
    }
}
