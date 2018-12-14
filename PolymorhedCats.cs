using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_training_001
{
    public class PolymorphedCats
    {
        public string CatBreed;
        public int CatWeight;

        public PolymorphedCats() { }

        public PolymorphedCats(string catBreed, int catWeight)
        {
            this.CatBreed = catBreed;
            this.CatWeight = catWeight;
        }

        public virtual void PrintCatInfo()
        {
            Console.WriteLine("The cat is a " + CatBreed +
                " and her average weight is " + CatWeight + " kg");
        }
    }

    public class RussianCat : PolymorphedCats
    {
        public RussianCat(string catBreed)
        {
            this.CatBreed = catBreed;
        }

        //Static variable to also train static/instance
        public static string OriginCountry = "Russia"; 

        public override void PrintCatInfo()
        {
            Console.WriteLine(CatBreed + " comes from " + OriginCountry);
        }
    }

    public class GenericCat : PolymorphedCats
    {
        public string GenericCatText;

        public GenericCat(string catBreed ,string genericCatText)
        {
            this.CatBreed = catBreed;
            this.GenericCatText = genericCatText;
        }

        public override void PrintCatInfo()
        {
            Console.WriteLine(CatBreed + " " + GenericCatText);
        }
    }
}