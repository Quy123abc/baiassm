namespace Calculators
{
    public class Class1
    {
        public int Tich(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Bằng 0");

            }
            return a * b;
        }

        public int Thuong(int a, int b)
        {
            if (b == 0)
            {
                throw new ArithmeticException("Không chia được cho 0");

            }
            return a / b;
        }
    }
}
