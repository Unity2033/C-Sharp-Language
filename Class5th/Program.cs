namespace Class5th
{
    public delegate void Calculator(int x, int y);

    internal class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine("x + y = " + (x + y));
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine("x - y = " + (x - y));
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine("x * y = " + (x * y));
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine("x / y = " + (x / y));
        }

        static void Main(string[] args)
        {
            #region 델리게이트
            // Calculator calculator;

            //calculator = Add;

            //calculator(10, 20);

            //calculator = Substract;

            //calculator(10, 20);
            #endregion

            #region 델리게이트 체인
            //calculator = Add;
            //calculator += Substract;
            //calculator += Multiply;
            //calculator += Divide;

            //calculator -= Divide;

            //calculator(5, 5);
            #endregion

            #region base 키워드
            Wizard wizard = new Wizard();
            #endregion
        }
    }
}