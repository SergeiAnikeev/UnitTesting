namespace CalculatorLibrary
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public float Divide(float a, float b)
        {
            EnsureThatDividerIsNotZero(b);
            return a / b;
        }

        public static void EnsureThatDividerIsNotZero(float c)
        {
            if(c == 0)
            {
                throw new DivideByZeroException();
            }
        }

    }
}
