/********************************************
Name: Subscription
Purpose: Subscription input
Notes: 
********************************************/

using ScottPlot.TickGenerators.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum DeductionFrequency
    {
        None = 1,
        Daily,
        Weekly,
        Monthly,
        Annually,
    }

    public class Subscription
    {

        DeductionFrequency m_Frequency;
        decimal m_ChargeAmount;
        string m_name;

        public Subscription(DeductionFrequency frequency, decimal amount, string name) 
        { 
            this.m_Frequency = frequency;
            this.m_ChargeAmount = amount;
            this.m_name = name;
        }

        public DeductionFrequency GetFrequency() { return m_Frequency; }

        public void SetFrequency(DeductionFrequency InFrequency) { m_Frequency = InFrequency; }

        public decimal GetChargeAmount() { return m_ChargeAmount; }

        public void SetChargeAmount(decimal InChargeAmount) { m_ChargeAmount = InChargeAmount; }

        public string GetName() { return m_name; }

        public void SetName(string Name) { m_name = Name; }

    }
}
