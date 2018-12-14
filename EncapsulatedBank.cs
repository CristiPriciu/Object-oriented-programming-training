using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_training_001
{
    internal abstract class EncapsulatedBank
    {
        protected int Id;
        protected string Owner;
        protected int AccountFee;

        private DateTime date = DateTime.Now.AddDays(-3);

        public void LogDatePast() {
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }

    internal class CurrentAccount : EncapsulatedBank
    {
        private readonly double DepositedSum;
        internal CurrentAccount(int id, string owner, int accountFee, double depositedSum)
        {
            this.Id = id;
            this.Owner = owner;
            this.AccountFee = accountFee;
            this.DepositedSum = depositedSum;
        }

        internal string SalaryInfo()
        {
            return ("Salary Account " + Id + " belongs to " + Owner + ". He/she has " 
                + DepositedSum + " deposited and pays a monthly fee of " + AccountFee);
        }
    }

    internal class DepositBoxAccount : EncapsulatedBank
    {
        private readonly List<string> DepositBox;
        internal DepositBoxAccount(int id, string owner, int accountFee, List<string> depositBox)
        {
            this.Id = id;
            this.Owner = owner;
            this.AccountFee = accountFee;
            this.DepositBox = depositBox;
        }

        internal string DepositBoxOwnerInfo()
        {
            return (Owner +", with Id " + Id + " pays " + AccountFee 
                + " monthly to store the items:");
        }

        internal string DepositBoxContents()
        {
            string depositedItems = "";
            for (var i = 0; i < DepositBox.Count; i++)
            {
                depositedItems += DepositBox[i] + ", ";
            }
            return depositedItems;
        }
    }

    internal class Deposit : EncapsulatedBank
    {
        private readonly double InterestRate;
        private readonly double DepositedSum;
        internal Deposit(int id, string owner, int accountFee, double interestRate,
            double depositedSum)
        {
            this.Id = id;
            this.Owner = owner;
            this.AccountFee = accountFee;
            this.InterestRate = interestRate;
            this.DepositedSum = depositedSum;
        }

        private string InterestYearly()
        {
            return ((DepositedSum * InterestRate) / 100).ToString();
        }

        internal string DepositInfo()
        {
            return (Owner + ", Id " + Id + " has " + DepositedSum + " deposited." +
                " At a yearly interest rate of " + InterestRate + "%, he/she gains " + InterestYearly());
        }
    }
}