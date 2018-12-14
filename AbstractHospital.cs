using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_training_001
{
    public abstract class AbstractHospital
    {
        public int Id;
        public string Name;
        public int YearsOld;
        public string JobTitle;

        public abstract string GetAllInfo();
        public abstract int MonthlyPay();
        public string GetIdAndName()
        {
            return(Name + " has Id: " + Id);
        }
    }

    public class Surgeon : AbstractHospital
    {
        public string OfficeName;
        public int AnnualSalary;
        public Surgeon(string officeName, int annualSalary, int id, string name, int yearsOld, 
            string jobTitle)
        {
            this.Id = id;
            this.Name = name;
            this.YearsOld = yearsOld;
            this.JobTitle = jobTitle;
            this.OfficeName = officeName;
            this.AnnualSalary = annualSalary;
        }

        public override string GetAllInfo()
        {
            return (Name + " is a " + YearsOld + " years old " + JobTitle + 
                " at Abstract Hospital. He/she works in " + OfficeName + ". He/she has Id " 
                + Id + " and a annual salary of " + AnnualSalary + "." +
                " Also, let's call the function GetIdAndName from the base abstract class: " 
                + GetIdAndName());
        }

        public override int MonthlyPay()
        {
            return AnnualSalary / 12;
        }
    }

    public class Janitor : AbstractHospital
    {
        public int HourlyPay;
        public int HoursWorked;

        public Janitor(int hourlyPay, int hoursWorked, int id, string name, int yearsOld, 
            string jobTitle)
        {
            this.HourlyPay = hourlyPay;
            this.HoursWorked = hoursWorked;
            this.Id = id;
            this.Name = name;
            this.YearsOld = yearsOld;
            this.JobTitle = jobTitle;
        }

        public override string GetAllInfo()
        {
            return (Name + ", Id " + Id + " is a " + YearsOld + " years old " + JobTitle +
                 " working at AbstractHospital");
        }

        public override int MonthlyPay()
        {
            return HourlyPay * HoursWorked;
        }

        public string JanitorPayInfo()
        {
            return (Name + " works " + HoursWorked + " hours a month, earning " + HourlyPay +
                 " per hour. This amounts to " + MonthlyPay() + " for a month");
        }
    }
}