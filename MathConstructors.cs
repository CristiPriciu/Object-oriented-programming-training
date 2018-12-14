using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_training_001
{
    class MathConstructors
    {
        private readonly int FirstNumber;
        private readonly int SecondNumber;
        private readonly int ThirdNumber;

        public MathConstructors(int firstNumber, int secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        public MathConstructors(int firstNumber, int secondNumber, int thirdNumber)
            :this(firstNumber, secondNumber)
        {
            this.ThirdNumber = thirdNumber;
        }

        public int Add2Numbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int Add3Numbers()
        {
            return FirstNumber + SecondNumber + ThirdNumber;
        }
    }
}