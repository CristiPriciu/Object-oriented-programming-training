using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_training_001
{
    class Program
    {
        static void Main(string[] args)
        {
            MathConstructors();
            InheritedDogs();
            PolymorphedCats();
            AbstractHospital();
            EncapsulatedBank();
        }

        //Constructor Test
        static void MathConstructors()
        {
            MathConstructors mathTestInstance = new MathConstructors(10, 20, 30);
            int firstResult = mathTestInstance.Add2Numbers();
            int secondResult = mathTestInstance.Add3Numbers();

            Console.WriteLine("Math results: ");
            Console.WriteLine("Result of Add2Numbers: " + firstResult);
            Console.WriteLine("Result of Add3Numbers: " + secondResult);
            Console.WriteLine("");
        }

        //Inheritance Test
        public static void InheritedDogs()
        {
            InheritanceDogs dogClass = new InheritanceDogs("Bulldog", 35, "England");
            string breedDescription = dogClass.Description();
            Console.WriteLine(breedDescription);

            Individual individualDog = new Individual("Sparky", "Mr. Johnston", 6, "Beagle");
            string dogInfo = individualDog.IndividualDescription();
            Console.WriteLine(dogInfo);
            Console.WriteLine("");
        }

        //Polymorphism test
        public static void PolymorphedCats()
        {
            PolymorphedCats newCats = new PolymorphedCats("Persian", 10);
            newCats.PrintCatInfo();

            RussianCat russianCat = new RussianCat("Russian Blue");
            russianCat.PrintCatInfo();

            GenericCat newGenericCat = new GenericCat("My generic cat", "is wonderful");
            newGenericCat.PrintCatInfo();
            Console.WriteLine("");
        }

        //Abstract class test
        public static void AbstractHospital()
        {
            Surgeon surgeon = new Surgeon("General Surgery", 5000, 101, "John W", 43, "Surgeon");
            string allInfo = surgeon.GetAllInfo();
            int pay = surgeon.MonthlyPay();
            Console.WriteLine(allInfo);
            Console.WriteLine("His monthly salary is " + pay + "\n");

            Janitor janitor = new Janitor(15, 35, 194, "Dan T", 57, "Hygiene Specialist");
            string janitorInfo = janitor.GetAllInfo();
            string janitorPay = janitor.JanitorPayInfo();
            string abstractFunctionCall = janitor.GetIdAndName();
            Console.WriteLine(janitorInfo);
            Console.WriteLine(janitorPay);
            Console.WriteLine("Also, " + janitor.Name + " can get his Id and name directly " +
                "from the base class if that's what he needs: " + abstractFunctionCall + "\n");
        }

        //Encapsulation Test
        internal static void EncapsulatedBank()
        {
            CurrentAccount accountInfo = new CurrentAccount(101, "John W", 12, 1000);
            string accountSalaryInfo = accountInfo.SalaryInfo();
            Console.WriteLine(accountSalaryInfo);

            List<string> depositedItems = new List<string>
            {
                "gold Bar","silver Ingot","bag of gold coins","family heirloom"
            };
            DepositBoxAccount depositBox = new DepositBoxAccount(86, "David S", 12, depositedItems);
            string boxContents = depositBox.DepositBoxContents();
            string boxOwnerInfo = depositBox.DepositBoxOwnerInfo();
            Console.WriteLine(boxOwnerInfo +"\n" + boxContents);

            Deposit clientDeposit = new Deposit(10, "Mary J", 12, 3.5, 10000);
            string clientDepositInfo = clientDeposit.DepositInfo();
            Console.WriteLine(clientDepositInfo);
        }
    }
}