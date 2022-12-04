using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string operand)
        {
            double result = double.NaN;

            switch (operand) {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
            }
            return result;
        }
    }
}
