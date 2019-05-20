using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCalculator
{
    public class calculate
    {
        public string firstNumber;
        public string secondNumber;
        public string totalString;
        public string signOperation;
        public bool fraction;
        public double result;

        public calculate()
        {
            firstNumber = "";
            secondNumber = "";
            totalString = "";
            signOperation = "";
            fraction = false;
            result = 0;
        }
    }
}