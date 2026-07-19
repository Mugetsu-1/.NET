using System;

namespace PartialClassApp
{
    public partial class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
    }
}