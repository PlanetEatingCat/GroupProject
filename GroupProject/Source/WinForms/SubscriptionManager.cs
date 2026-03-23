using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/********************************************
Name: SubscriptionManager.cs
Purpose: Manages a users subscriptions. Enables adding, removing, and editing of subscriptions.
Notes: Work in Progress. Authored by Kiefer.
********************************************/

namespace BudgetPlanner
{
    public class SubscriptionManager 
    {
        //Enum to track how often payments are made.
        public enum PaymentCycle
        {
            Weekly,
            Monthly,
            Quarterly,
            Yearly
        }

        //Holds onto all subscription info
        public class Subscription (string name, PaymentCycle frequency, int amount)
        {
            public string subName { get; private set; } = name;
            public PaymentCycle payFrequency { get; private set; } = frequency;
            public int owedAmount { get; private set; } = amount;
        }
        public Dictionary<string, Subscription> UserSubscriptions {  get; private set; }
        
        //This is the number of subscriptions
        public int count {  get; private set; }

        public SubscriptionManager()
        {
            UserSubscriptions = new Dictionary<string, Subscription>();
            count = 0;
        }

        //Adds a subscription to the dictionary
        public void AddSubscription(string subName, PaymentCycle frequency, int amount)
        {
            Subscription newSub = new Subscription(subName, frequency, amount);
            UserSubscriptions.Add(subName, newSub);
            this.count++;
        }

        //Removes a subscription from the dictionary
        public void RemoveSubscription(string subName)
        {
            bool isFound = false;

            foreach (var subscription in UserSubscriptions.Keys)
            {
                if (subName == subscription)
                {
                    UserSubscriptions.Remove(subscription);
                    isFound = true;
                    this.count--;
                }
            }

            if (!isFound)
            {
                //Connect to a textbox in Subscription Manager form that informs user they do not have that subscription
            }
            else
            {
                //Connect to a textbox in Subscription Manager form that informs user the subscription has been removed/cancelled
            }
        }

        //Allows users to pass in information to edit subscriptions already in the dictionary
        public void EditSubscription(string subName, PaymentCycle frequency, int amount)
        {
            bool isFound = false;

            foreach (var subscription in UserSubscriptions.Keys)
            {
                if (subName == subscription)
                {
                    UserSubscriptions[subName] = new Subscription(subName, frequency, amount);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                //Connect to a textbox in Subscription Manager form that informs user they do not have that subscription
            }
            else
            {
                //Connect to a textbox in Subscription Manager form that informs user the subscription has been updated to reflect new information
            }
        }

        //Gets value of all current subscriptions being paid for
        public int GetValueOfSubs()
        {
            int total = 0;
            foreach (var subscription in UserSubscriptions.Keys)
            {
                total += UserSubscriptions[subscription].owedAmount;
            }

            return total;
        }

        //Function returns a string informing users when they are overbudget or on track with budget goals
        public string OverUnderBudget()
        {
            int total = GetValueOfSubs();
            int budget = 0; //Need to pull budget in from user profile

            if (total > budget)
            {
                return $"User is overbudget by ${total - budget}. Consider cancelling some subscriptions to meet budget goals!";
            }
            else if (total <= budget)
            {
                return $"You're on track with your budget goals! You are under budget by ${budget - total}.";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
