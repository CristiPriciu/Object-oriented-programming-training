using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_training_001
{
    public class InheritanceDogs
    {
        public string BreedName;
        public int AverageHeight;
        public string Origin;

        public InheritanceDogs() { }

        public InheritanceDogs(string breedName, int averageHeight, string origin)
        {
            this.BreedName = breedName;
            this.AverageHeight = averageHeight;
            this.Origin = origin;
        }

        public string Description()
        {
            return BreedName + " is " + AverageHeight + 
                " cm height on average and comes from " + Origin;
        }
    }

    public class Individual : InheritanceDogs
    {
        public string IndividualName;
        public string MasterName;
        public int Age;

        public Individual(string individualName, string masterName, int age, string breedName)
        {
            this.IndividualName = individualName;
            this.MasterName = masterName;
            this.Age = age;
            this.BreedName = breedName;
        }

        public string IndividualDescription()
        {
            return MasterName + " has a " + BreedName + " named " + 
                IndividualName + " who is " + Age + " years old";
        }
    }
}