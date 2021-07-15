using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.Model
{
    public class CaluModel
    {
        public static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public static double Multiple(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public static double Division(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }

        public static char LastChar(string contentString)
        {
            return contentString[contentString.Length - 1];
        }
    }
}
