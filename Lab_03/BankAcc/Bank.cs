using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    internal class Bank
    {
        int id;
        string name;
        double balance;
        int age;

        public void SetId(int _id)
        {
            if (_id <= 0) Console.WriteLine("ID must greater than 0");
            else id = _id;
        }

        public int GetId() { return id; }

        public void SetName(string _name)
        {
            if (_name.Length >= 3) name = _name;
            else Console.WriteLine("Invalid Name");
        }
        public string GetName() { return name; }

        public void SetBalance(double _balance)
        {
            if (_balance> 0) balance = _balance;
            else Console.WriteLine("Invalid Balance");
        }
        public double GetBalance() { return balance; }

        public Bank(int _id, string _name , double _balance)
        {
            SetId(_id);
            SetName(_name);
            SetBalance(_balance);
        }

        public void Print()
        {
            Console.WriteLine($"ID:- {GetId()}  Name:- {GetName()}  Balance:- {GetBalance()}   ");
        }
    }
}
