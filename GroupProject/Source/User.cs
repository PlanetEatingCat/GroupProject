/********************************************
Name: class Person
Purpose: to encapsulate functionality of a Person
Notes: (here are any special explanations)
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class User
    {
        const uint MAX_AGE = 150;

        string m_Username;
        string m_Password;
        uint m_Age;
        Guid m_ID;

        public User()
        {
            m_Username = "";
            m_Password = "";
            m_Age = 0;
        }

        public User(string InUsername, string InPassword, uint InAge)
        {
            m_ID = Guid.NewGuid();
            SetUsername(InUsername);
            SetPassword(InPassword);
            SetAge(InAge);
        }

        public User(string InUsername, string InPassword, uint InAge, Guid InID)
        {
            m_ID = InID;
            SetUsername(InUsername);
            SetPassword(InPassword);
            SetAge(InAge);
        }

        public void SetUsername(string InUsername) 
        { 
            if (string.IsNullOrWhiteSpace(InUsername))
                throw new ArgumentException("First name connot be empty.");

            m_Username = InUsername.Trim(); 
        }


        public string GetUsername() { return m_Username; }

        public void SetPassword(string InPassword)
        {
            if (string.IsNullOrWhiteSpace(InPassword))
                throw new ArgumentException("Last name connot be empty.");

            m_Password = InPassword.Trim();
        }

        public string GetPassword() { return m_Password; }

        public void SetAge(uint InAge) 
        {
            if (InAge > MAX_AGE)
                throw new ArgumentOutOfRangeException(nameof(InAge), $"Age cannot exceed {MAX_AGE}.");

            m_Age = InAge;
        }

        public uint GetAge() { return m_Age; }
        public Guid GetID() { return m_ID; }

        public void Print() 
        {
            Console.WriteLine($"First name: {m_Username}");
            Console.WriteLine($"Password: {m_Password}");
            Console.WriteLine($"Age: {m_Age}");

        }
    }
}
